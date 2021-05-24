<Serializable()>
Public Class Productos

    Private id_Producto_, id_Categoria_, id_Subcategoria_, id_Proveedor_, SubirWeb_, Novedad_, Habilitado_, id_Material_, id_Color_, id_Aroma_ As Integer
    Private Descripcion_, Nombre_, Origen_, Tamano_, Codigo_, Foto_, CodigoBarra_ As String
    Private Precio1_, Precio2_, Precio3_, Precio4_, Precio5_, Precio6_, Costo_ As Double

    <NonSerialized()>
    Private Materiales_ As Object
    <NonSerialized()>
    Private Aromas_ As Object
    <NonSerialized()>
    Private Colores_ As Object
    Private EliminarFoto_ As Boolean

    Public Property id_Producto() As Integer
        Get
            Return id_Producto_
        End Get
        Set(ByVal value As Integer)
            id_Producto_ = value
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

    Public Property id_Subcategoria() As Integer
        Get
            Return id_Subcategoria_
        End Get
        Set(ByVal value As Integer)
            id_Subcategoria_ = value
        End Set
    End Property

    Public Property id_Proveedor() As Integer
        Get
            Return id_Proveedor_
        End Get
        Set(ByVal value As Integer)
            id_Proveedor_ = value
        End Set
    End Property

    Public Property id_Material() As Integer
        Get
            Return id_Material_
        End Get
        Set(ByVal value As Integer)
            id_Material_ = value
        End Set
    End Property

    Public Property id_Color() As Integer
        Get
            Return id_Color_
        End Get
        Set(ByVal value As Integer)
            id_Color_ = value
        End Set
    End Property

    Public Property id_Aroma() As Integer
        Get
            Return id_Aroma_
        End Get
        Set(ByVal value As Integer)
            id_Aroma_ = value
        End Set
    End Property
    Public Property Novedad() As Integer
        Get
            Return Novedad_
        End Get
        Set(ByVal value As Integer)
            Novedad_ = value
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

    Public Property SubirWeb() As Integer
        Get
            Return SubirWeb_
        End Get
        Set(ByVal value As Integer)
            SubirWeb_ = value
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

    Public Property Origen() As String
        Get
            Return Origen_
        End Get
        Set(ByVal value As String)
            Origen_ = value
        End Set
    End Property

    Public Property Tamano() As String
        Get
            Return Tamano_
        End Get
        Set(ByVal value As String)
            Tamano_ = value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return Codigo_
        End Get
        Set(ByVal value As String)
            Codigo_ = value
        End Set
    End Property

    Public Property CodigoBarra() As String
        Get
            Return CodigoBarra_
        End Get
        Set(ByVal value As String)
            CodigoBarra_ = value
        End Set
    End Property

    Public Property Foto() As String
        Get
            Return Foto_
        End Get
        Set(ByVal value As String)
            Foto_ = value
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

    Public Property Precio1() As Double
        Get
            Return Precio1_
        End Get
        Set(ByVal value As Double)
            Precio1_ = value
        End Set
    End Property

    Public Property Precio2() As Double
        Get
            Return Precio2_
        End Get
        Set(ByVal value As Double)
            Precio2_ = value
        End Set
    End Property

    Public Property Precio3() As Double
        Get
            Return Precio3_
        End Get
        Set(ByVal value As Double)
            Precio3_ = value
        End Set
    End Property

    Public Property Precio4() As Double
        Get
            Return Precio4_
        End Get
        Set(ByVal value As Double)
            Precio4_ = value
        End Set
    End Property

    Public Property Precio5() As Double
        Get
            Return Precio5_
        End Get
        Set(ByVal value As Double)
            Precio5_ = value
        End Set
    End Property

    Public Property Precio6() As Double
        Get
            Return Precio6_
        End Get
        Set(ByVal value As Double)
            Precio6_ = value
        End Set
    End Property

    Public Property Costo() As Double
        Get
            Return Costo_
        End Get
        Set(ByVal value As Double)
            Costo_ = value
        End Set
    End Property

    Public Property EliminarFoto() As Boolean
        Get
            Return EliminarFoto_
        End Get
        Set(ByVal value As Boolean)
            EliminarFoto_ = value
        End Set
    End Property
End Class