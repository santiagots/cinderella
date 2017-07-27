Public Class Registros
    Private id_Registro_, id_Sucursal_ As Integer
    Private EmpleadosPresente_ As Object
    Private EmpleadosTarde_ As Object
    Private EmpleadosAusente_ As Object
    Private Fecha_ As String

    Public Property id_Registro() As Integer
        Get
            Return id_Registro_
        End Get
        Set(ByVal value As Integer)
            id_Registro_ = value
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

    Public Property Fecha() As String
        Get
            Return Fecha_
        End Get
        Set(ByVal value As String)
            Fecha_ = value
        End Set
    End Property

    Public Property EmpleadosPresente() As System.Windows.Forms.CheckedListBox
        Get
            Return EmpleadosPresente_
        End Get
        Set(ByVal value As System.Windows.Forms.CheckedListBox)
            EmpleadosPresente_ = value
        End Set
    End Property

    Public Property EmpleadosTarde() As System.Windows.Forms.CheckedListBox
        Get
            Return EmpleadosTarde_
        End Get
        Set(ByVal value As System.Windows.Forms.CheckedListBox)
            EmpleadosTarde_ = value
        End Set
    End Property

    Public Property EmpleadosAusente() As System.Windows.Forms.CheckedListBox
        Get
            Return EmpleadosAusente_
        End Get
        Set(ByVal value As System.Windows.Forms.CheckedListBox)
            EmpleadosAusente_ = value
        End Set
    End Property
End Class
