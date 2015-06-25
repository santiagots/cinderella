Public Class Productos_Subcategorias
    Private id_Categoria_, id_Subcategoria_, Habilitado_ As Integer
    Private Descripcion_ As String

    Public Property id_Subcategoria() As Integer
        Get
            Return id_Subcategoria_
        End Get
        Set(ByVal value As Integer)
            id_Subcategoria_ = value
        End Set
    End Property

    Public Property id_Categoria() As Integer
        Get
            Return id_Categoria_
        End Get
        Set(ByVal value As Integer)
            id_Categoria_ = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return Descripcion_
        End Get
        Set(ByVal value As String)
            Descripcion_ = value
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
