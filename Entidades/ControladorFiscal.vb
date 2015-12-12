Public Class ControladorFiscal
    Dim CUIT_, RI_, NCUIT_, LREMITO1_, LREMITO2_, NCOMP1_, NCOMP2_, DCOMP1_, DCOMP2_, DCOMP3_, DE1_, DE2_, DE3_, DE4_, DPPAL_, CANTIDAD_, PUNITARIO_, TIVA_, IIF_, IIP_, COLAR3_, COLAR2_, COLAR1_ As String

    Public Property NCOMP1() As String
        Get
            Return NCOMP1_
        End Get
        Set(ByVal value As String)
            NCOMP1_ = value
        End Set
    End Property

    Public Property NCOMP2() As String
        Get
            Return NCOMP2_
        End Get
        Set(ByVal value As String)
            NCOMP2_ = value
        End Set
    End Property

    Public Property DCOMP1() As String
        Get
            Return DCOMP1_
        End Get
        Set(ByVal value As String)
            DCOMP1_ = value
        End Set
    End Property

    Public Property DCOMP2() As String
        Get
            Return DCOMP2_
        End Get
        Set(ByVal value As String)
            DCOMP2_ = value
        End Set
    End Property

    Public Property DCOMP3() As String
        Get
            Return DCOMP3_
        End Get
        Set(ByVal value As String)
            DCOMP3_ = value
        End Set
    End Property

    Public Property DE1() As String
        Get
            Return DE1_
        End Get
        Set(ByVal value As String)
            DE1_ = value
        End Set
    End Property

    Public Property DE2() As String
        Get
            Return DE2_
        End Get
        Set(ByVal value As String)
            DE2_ = value
        End Set
    End Property

    Public Property DE3() As String
        Get
            Return DE3_
        End Get
        Set(ByVal value As String)
            DE3_ = value
        End Set
    End Property

    Public Property DE4() As String
        Get
            Return DE4_
        End Get
        Set(ByVal value As String)
            DE4_ = value
        End Set
    End Property

    Public Property DPPAL() As String
        Get
            Return DPPAL_
        End Get
        Set(ByVal value As String)
            DPPAL_ = value
        End Set
    End Property

    Public Property CANTIDAD() As String
        Get
            Return CANTIDAD_
        End Get
        Set(ByVal value As String)
            CANTIDAD_ = value
        End Set
    End Property

    Public Property PUNITARIO() As String
        Get
            Return PUNITARIO_
        End Get
        Set(ByVal value As String)
            PUNITARIO_ = value
        End Set
    End Property

    Public Property TIVA() As String
        Get
            Return TIVA_
        End Get
        Set(ByVal value As String)
            TIVA_ = value
        End Set
    End Property

    Public Property IIF() As String
        Get
            Return IIF_
        End Get
        Set(ByVal value As String)
            IIF_ = value
        End Set
    End Property

    Public Property IIP() As String
        Get
            Return IIP_
        End Get
        Set(ByVal value As String)
            IIP_ = value
        End Set
    End Property

    Public Property COLAR1() As String
        Get
            Return COLAR1_
        End Get
        Set(ByVal value As String)
            COLAR1_ = value
        End Set
    End Property

    Public Property COLAR2() As String
        Get
            Return COLAR2_
        End Get
        Set(ByVal value As String)
            COLAR2_ = value
        End Set
    End Property

    Public Property COLAR3() As String
        Get
            Return COLAR3_
        End Get
        Set(ByVal value As String)
            COLAR3_ = value
        End Set
    End Property

    Public Property CUIT() As String
        Get
            Return CUIT_
        End Get
        Set(ByVal value As String)
            CUIT_ = value
        End Set
    End Property

    Public Property NCUIT() As String
        Get
            Return NCUIT_
        End Get
        Set(ByVal value As String)
            NCUIT_ = value
        End Set
    End Property

    Public Property RI() As String
        Get
            Return RI_
        End Get
        Set(ByVal value As String)
            RI_ = value
        End Set
    End Property

    Public Property LREMITO1() As String
        Get
            Return LREMITO1_
        End Get
        Set(ByVal value As String)
            LREMITO1_ = value
        End Set
    End Property

    Public Property LREMITO2() As String
        Get
            Return LREMITO2_
        End Get
        Set(ByVal value As String)
            LREMITO2_ = value
        End Set
    End Property

    Private COMPROBANTEORIGEN_ As String
    Public Property COMPROBANTEORIGEN() As String
        Get
            Return ComprobanteOrigen_
        End Get
        Set(ByVal value As String)
            ComprobanteOrigen_ = value
        End Set
    End Property

End Class
