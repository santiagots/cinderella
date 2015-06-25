Public Class Mail
    Private Fromm_, Too_, Subject_, Body_, CC_, CCO_, ReplyTo_ As String

    Public Property Fromm() As String
        Get
            Return Fromm_
        End Get
        Set(ByVal value As String)
            Fromm_ = value
        End Set
    End Property

    Public Property Too() As String
        Get
            Return Too_
        End Get
        Set(ByVal value As String)
            Too_ = value
        End Set
    End Property

    Public Property CC() As String
        Get
            Return CC_
        End Get
        Set(ByVal value As String)
            CC_ = value
        End Set
    End Property

    Public Property CCO() As String
        Get
            Return CCO_
        End Get
        Set(ByVal value As String)
            CCO_ = value
        End Set
    End Property

    Public Property ReplyTo() As String
        Get
            Return ReplyTo_
        End Get
        Set(ByVal value As String)
            ReplyTo_ = value
        End Set
    End Property

    Public Property Subject() As String
        Get
            Return Subject_
        End Get
        Set(ByVal value As String)
            Subject_ = value
        End Set
    End Property

    Public Property Body() As String
        Get
            Return Body_
        End Get
        Set(ByVal value As String)
            Body_ = value
        End Set
    End Property
End Class
