Public Class Registros
    Private id_Registro_, id_Sucursal_ As Integer
    Private Empleados_ As Object
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

    Public Property Empleados() As System.Windows.Forms.CheckedListBox
        Get
            Return Empleados_
        End Get
        Set(ByVal value As System.Windows.Forms.CheckedListBox)
            Empleados_ = value
        End Set
    End Property
End Class
