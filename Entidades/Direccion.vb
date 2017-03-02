Public Class Direccion

    Private Id_ As Integer
    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
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

    Private IdProviencia_ As Integer
    Public Property IdProvincia() As Integer
        Get
            Return IdProviencia_
        End Get
        Set(ByVal value As Integer)
            IdProviencia_ = value
        End Set
    End Property

    Private IdDistrito_ As Integer
    Public Property IdDistito() As Integer
        Get
            Return IdDistrito_
        End Get
        Set(ByVal value As Integer)
            IdDistrito_ = value
        End Set
    End Property

    Private IdLocalidad_ As Integer
    Public Property IdLocalidad() As Integer
        Get
            Return IdLocalidad_
        End Get
        Set(ByVal value As Integer)
            IdLocalidad_ = value
        End Set
    End Property

    Private CodigoPostal_ As String
    Public Property CodigoPostal() As String
        Get
            Return CodigoPostal_
        End Get
        Set(ByVal value As String)
            CodigoPostal_ = value
        End Set
    End Property

    Private Telefono_ As String
    Public Property Telefono() As String
        Get
            Return Telefono_
        End Get
        Set(ByVal value As String)
            Telefono_ = value
        End Set
    End Property

    Private Email_ As String
    Public Property Email() As String
        Get
            Return Email_
        End Get
        Set(ByVal value As String)
            Email_ = value
        End Set
    End Property


    Sub New()
        Id_ = 0
        Direccion_ = String.Empty
        IdProviencia_ = -1
        IdDistrito_ = -1
        IdLocalidad_ = -1
        CodigoPostal_ = String.Empty
        Telefono_ = String.Empty
        Email_ = String.Empty
    End Sub
End Class
