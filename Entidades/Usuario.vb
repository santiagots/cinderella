Public Class Usuario
    'Campos de la entidad
    Private id_Usuario_fld As Integer
    Private id_Perfil_fld As Integer
    Private Usuario_fld As String
    Private PWD_fld As String
    Private Nombre_fld As String
    Private Mail_fld As String
    Private Apellido_fld As String
    Private Fecha_fld As Date
    Private Habilitado_fld As Integer
    Private Patentes_arr As Array

    'Propiedades de la entidad
    Public Property id_Usuario() As Integer
        Get
            Return id_Usuario_fld
        End Get
        Set(ByVal value As Integer)
            id_Usuario_fld = value
        End Set
    End Property

    Public Property id_Perfil() As Integer
        Get
            Return id_Perfil_fld
        End Get
        Set(ByVal value As Integer)
            id_Perfil_fld = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return Usuario_fld
        End Get
        Set(ByVal value As String)
            Usuario_fld = value
        End Set
    End Property

    Public Property PWD() As String
        Get
            Return PWD_fld
        End Get
        Set(ByVal value As String)
            PWD_fld = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Nombre_fld
        End Get
        Set(ByVal value As String)
            Nombre_fld = value
        End Set
    End Property

    Public Property Apellido() As String
        Get
            Return Apellido_fld
        End Get
        Set(ByVal value As String)
            Apellido_fld = value
        End Set
    End Property

    Public Property Mail() As String
        Get
            Return Mail_fld
        End Get
        Set(ByVal value As String)
            Mail_fld = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return Fecha_fld
        End Get
        Set(ByVal value As Date)
            Fecha_fld = value
        End Set
    End Property

    Public Property Habilitado() As Integer
        Get
            Return Habilitado_fld
        End Get
        Set(ByVal value As Integer)
            Habilitado_fld = value
        End Set
    End Property

End Class