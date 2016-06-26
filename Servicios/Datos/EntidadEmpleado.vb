Public Class EntidadEmpleado

    Private id_Empleado_ As Integer
    Private Nombre_, Apellido_ As String

    Public Property id_Empleado() As Integer
        Get
            Return id_Empleado_
        End Get
        Set(ByVal value As Integer)
            id_Empleado_ = value
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
End Class


