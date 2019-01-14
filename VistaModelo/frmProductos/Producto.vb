Imports System.ComponentModel
Imports Entidades
Imports SistemaCinderella.VistaModelo

Namespace VistaModelo.frmProductos
    Public Class Producto
        Inherits Common

        Dim NegProductos As New Negocio.NegProductos
        Dim NegErrores As New Negocio.NegManejadorErrores
        Dim NegProductosCat As New Negocio.NegProductosCategorias
        Dim NegProductosSubCat As New Negocio.NegProductosSubcategorias
        Dim NegProveedores As New Negocio.NegProveedores
        Dim NegAromas As New Negocio.NegAromas
        Dim NegMateriales As New Negocio.NegMateriales
        Dim NegColores As New Negocio.NegColores

        Private _Id As Integer
        Public Property Id() As Integer
            Get
                Return _Id
            End Get
            Set(ByVal value As Integer)
                If (value <> _Id) Then
                    _Id = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _Nombre As String
        Public Property Nombre() As String
            Get
                Return _Nombre
            End Get
            Set(ByVal value As String)
                If (value <> _Nombre) Then
                    _Nombre = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _Origen As String
        Public Property Origen() As String
            Get
                Return _Origen
            End Get
            Set(ByVal value As String)
                If (value <> _Origen) Then
                    _Origen = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _Tamanio As String
        Public Property Tamanio() As String
            Get
                Return _Tamanio
            End Get
            Set(ByVal value As String)
                If (value <> _Tamanio) Then
                    _Tamanio = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _Codigo As String
        Public Property Codigo() As String
            Get
                Return _Codigo
            End Get
            Set(ByVal value As String)
                If (value <> _Codigo) Then
                    _Codigo = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _Costo As Decimal
        Public Property Costo() As Decimal
            Get
                Return _Costo
            End Get
            Set(ByVal value As Decimal)
                If (value <> _Costo) Then
                    _Costo = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _FotoRuta As String
        Public Property FotoRuta() As String
            Get
                Return _FotoRuta
            End Get
            Set(ByVal value As String)
                If (value <> _FotoRuta) Then
                    _FotoRuta = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _Categorias As BindingList(Of KeyValuePair(Of Integer, String))
        Public Property Categorias() As BindingList(Of KeyValuePair(Of Integer, String))
            Get
                Return _Categorias
            End Get
            Set(ByVal value As BindingList(Of KeyValuePair(Of Integer, String)))
                _Categorias = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _CategoriasSeleccionada As Integer
        Public Property CategoriasSeleccionada() As Integer
            Get
                Return _CategoriasSeleccionada
            End Get
            Set(ByVal value As Integer)
                _CategoriasSeleccionada = value
            End Set
        End Property

        Private _Subcategorias As BindingList(Of KeyValuePair(Of Integer, String))
        Public Property Subcategorias() As BindingList(Of KeyValuePair(Of Integer, String))
            Get
                Return _Subcategorias
            End Get
            Set(ByVal value As BindingList(Of KeyValuePair(Of Integer, String)))
                _Subcategorias = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _SubcategoriasSeleccionada As Integer
        Public Property SubcategoriasSeleccionada() As Integer
            Get
                Return _SubcategoriasSeleccionada
            End Get
            Set(ByVal value As Integer)
                _SubcategoriasSeleccionada = value
            End Set
        End Property

        Private _Proveedores As BindingList(Of KeyValuePair(Of Integer, String))
        Public Property Proveedores() As BindingList(Of KeyValuePair(Of Integer, String))
            Get
                Return _Proveedores
            End Get
            Set(ByVal value As BindingList(Of KeyValuePair(Of Integer, String)))
                _Proveedores = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _ProveedoresSeleccionada As Integer
        Public Property ProveedoresSeleccionada() As Integer
            Get
                Return _ProveedoresSeleccionada
            End Get
            Set(ByVal value As Integer)
                _ProveedoresSeleccionada = value
            End Set
        End Property

        Private _Habilitado As Boolean
        Public Property Habilitado() As Boolean
            Get
                Return _Habilitado
            End Get
            Set(ByVal value As Boolean)
                If (value <> _Habilitado) Then
                    _Habilitado = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _SubirAWeb As Boolean
        Public Property SubirAWeb() As Boolean
            Get
                Return _SubirAWeb
            End Get
            Set(ByVal value As Boolean)
                If (value <> _SubirAWeb) Then
                    _SubirAWeb = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _Novedad As Boolean
        Public Property Novedad() As Boolean
            Get
                Return _Novedad
            End Get
            Set(ByVal value As Boolean)
                If (value <> _Novedad) Then
                    _Novedad = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _EliminarFoto As Boolean
        Public Property EliminarFoto() As Boolean
            Get
                Return _EliminarFoto
            End Get
            Set(ByVal value As Boolean)
                If (value <> _EliminarFoto) Then
                    _EliminarFoto = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _Descripcion As String
        Public Property Descripcion() As String
            Get
                Return _Descripcion
            End Get
            Set(ByVal value As String)
                If (value <> _Descripcion) Then
                    _Descripcion = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _ListaTigre As Double
        Public Property ListaTigre() As Double
            Get
                Return _ListaTigre
            End Get
            Set(ByVal value As Double)
                If (value <> _ListaTigre) Then
                    _ListaTigre = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _PorcentajeDescuentoTigre As Double
        Public Property PorcentajeDescuentoTigre() As Double
            Get
                Return _PorcentajeDescuentoTigre
            End Get
            Set(ByVal value As Double)
                If (value <> _PorcentajeDescuentoTigre) Then
                    _PorcentajeDescuentoTigre = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _ListaCapital As Double
        Public Property ListaCapital() As Double
            Get
                Return _ListaCapital
            End Get
            Set(ByVal value As Double)
                If (value <> _ListaCapital) Then
                    _ListaCapital = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _PorcentajeDescuentoCapital As Double
        Public Property PorcentajeDescuentoCapital() As Double
            Get
                Return _PorcentajeDescuentoCapital
            End Get
            Set(ByVal value As Double)
                If (value <> _PorcentajeDescuentoCapital) Then
                    _PorcentajeDescuentoCapital = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _Mayorista As Double
        Public Property Mayorista() As Double
            Get
                Return _Mayorista
            End Get
            Set(ByVal value As Double)
                If (value <> _Mayorista) Then
                    _Mayorista = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _Alternativo As Double
        Public Property Alternativo() As Double
            Get
                Return _Alternativo
            End Get
            Set(ByVal value As Double)
                If (value <> _Alternativo) Then
                    _Alternativo = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property

        Private _CodigoBarras As String
        Public Property CodigoBarras() As String
            Get
                Return _CodigoBarras
            End Get
            Set(ByVal value As String)
                If (value <> _CodigoBarras) Then
                    _CodigoBarras = value
                    NotifyPropertyChanged()
                End If
            End Set
        End Property


        Private _CodigoBarrasImagen As Image
        Public Property CodigoBarrasImagen() As Image
            Get
                Return _CodigoBarrasImagen
            End Get
            Set(ByVal value As Image)
                _CodigoBarrasImagen = value
                NotifyPropertyChanged()
            End Set
        End Property

        Private _Foto As Image
        Public Property Foto() As Image
            Get
                Return _Foto
            End Get
            Set(ByVal value As Image)
                _Foto = value
                NotifyPropertyChanged()
            End Set
        End Property

        Public Sub New()
            Me.Nombre = String.Empty
            Me.Origen = String.Empty
            Me.Tamanio = String.Empty
            Me.Codigo = String.Empty
            Me.FotoRuta = String.Empty
            Me.Descripcion = String.Empty
            Me.Categorias = New BindingList(Of KeyValuePair(Of Integer, String))(ObtenerOpcionesParaCombo(NegProductosCat.ListadoCategorias().Tables(0), "id_Categoria", "Descripcion"))
            Me.Subcategorias = New BindingList(Of KeyValuePair(Of Integer, String))()
            Me.Subcategorias.Add(New KeyValuePair(Of Integer, String)(0, "No hay opciones disponibles."))
            Me.Proveedores = New BindingList(Of KeyValuePair(Of Integer, String))(ObtenerOpcionesParaCombo(NegProveedores.ListadoProveedores().Tables(0), "id_Proveedor", "RazonSocial"))
        End Sub

        Public Sub Limpiar()
            Me.Nombre = String.Empty
            Me.Origen = String.Empty
            Me.Tamanio = String.Empty
            Me.Costo = 0
            Me.Codigo = String.Empty
            Me.ListaTigre = 0
            Me.PorcentajeDescuentoTigre = 0
            Me.ListaCapital = 0
            Me.PorcentajeDescuentoCapital = 0
            Me.Mayorista = 0
            Me.Alternativo = 0
            Me.FotoRuta = String.Empty
            Me.Descripcion = String.Empty
            Me.CategoriasSeleccionada = 0
            Me.SubcategoriasSeleccionada = 0
            Me.Subcategorias.Clear()
            Me.Subcategorias.Add(New KeyValuePair(Of Integer, String)(0, "No hay opciones disponibles."))
            Me.ProveedoresSeleccionada = 0
            Me.Habilitado = False
            Me.Novedad = False
            Me.SubirAWeb = False
            Me.EliminarFoto = False
        End Sub

        Private Function ObtenerEntidad() As Entidades.Productos
            Return New Entidades.Productos() With {
                .id_Producto = Me.Id,
                .Nombre = Me.Nombre,
                .Origen = Me.Origen,
                .Tamano = Me.Tamanio,
                .Costo = Me.Costo,
                .Codigo = Me.Codigo,
                .Precio1 = Me.ListaTigre,
                .Precio2 = Me.PorcentajeDescuentoTigre,
                .Precio3 = Me.ListaCapital,
                .Precio4 = Me.PorcentajeDescuentoCapital,
                .Precio5 = Me.Mayorista,
                .Precio6 = Me.Alternativo,
                .Foto = Me.FotoRuta,
                .Descripcion = Trim(Me.Descripcion).Replace(vbCrLf, "<br />"),
                .id_Categoria = Me.CategoriasSeleccionada,
                .id_Subcategoria = Me.SubcategoriasSeleccionada,
                .id_Proveedor = Me.ProveedoresSeleccionada,
                .Habilitado = Convert.ToInt32(Me.Habilitado),
                .Novedad = Convert.ToInt32(Me.Novedad),
                .SubirWeb = Convert.ToInt32(Me.SubirAWeb),
                .CodigoBarra = Me.CodigoBarras,
                .EliminarFoto = Me.EliminarFoto}
        End Function

        Public Sub Actualizar(eProducto As Productos)
            Me.Id = eProducto.id_Producto
            Me.Nombre = eProducto.Nombre
            Me.Origen = eProducto.Origen
            Me.Tamanio = eProducto.Tamano
            Me.Costo = eProducto.Costo
            Me.Codigo = eProducto.Codigo
            Me.ListaTigre = eProducto.Precio1
            Me.PorcentajeDescuentoTigre = eProducto.Precio2
            Me.ListaCapital = eProducto.Precio3
            Me.PorcentajeDescuentoCapital = eProducto.Precio4
            Me.Mayorista = eProducto.Precio5
            Me.Alternativo = eProducto.Precio6
            Me.FotoRuta = eProducto.Foto
            Me.Descripcion = Trim(eProducto.Descripcion).Replace("<br />", vbCrLf)
            Me.CategoriasSeleccionada = eProducto.id_Categoria
            Me.SubcategoriasSeleccionada = eProducto.id_Subcategoria
            Me.Subcategorias = New BindingList(Of KeyValuePair(Of Integer, String))(ObtenerOpcionesParaCombo(NegProductosSubCat.ListadoSubcategorias(Me.CategoriasSeleccionada).Tables(0), "id_Subcategoria", "Descripcion"))
            Me.ProveedoresSeleccionada = eProducto.id_Proveedor
            Me.CodigoBarras = eProducto.CodigoBarra
            Me.Habilitado = Convert.ToInt32(eProducto.Habilitado)
            Me.Novedad = Convert.ToInt32(eProducto.Novedad)
            Me.SubirAWeb = Convert.ToInt32(eProducto.SubirWeb)

            'Realizo el codigo de barras y lo asigno al picture
            'esto lo uso para los seteos, no cambiarlos, mandar estos tal cual. 
            Dim seteos As New CodigoBarras.Ean13Settings
            seteos.BarCodeHeight = 80
            seteos.BarWidth = 1
            seteos.BottomMargin = 5
            seteos.LeftMargin = 5
            seteos.RightMargin = 5
            seteos.TopMargin = 10
            seteos.Font = New Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular)

            Try
                'aca genero el codigo
                Dim CodigoBarras As New CodigoBarras.Ean13(eProducto.CodigoBarra, Me.Nombre, Me.Codigo, "$" & Me.ListaTigre, seteos)
                Me.CodigoBarrasImagen = CodigoBarras.Paint()
            Catch ex As Exception

            End Try

            Me.Foto = My.Resources.Recursos.Sinfoto

            ''Cargo la imagen en el picture
            'Try
            '    Dim client As New System.Net.WebClient()
            '    Dim stream As New System.IO.MemoryStream()
            '    Dim data As Byte() = client.DownloadData("http://www.cinderelladecoracion.com/www/software_cinderella/imagenes/" & eProducto.Foto)
            '    client.Dispose()
            '    stream.Write(data, 0, data.Length)
            '    Me.Foto = Image.FromStream(stream)
            'Catch
            '    Me.Foto = My.Resources.Recursos.Sinfoto
            'End Try
        End Sub

        Friend Function Alta() As String
            Return NegProductos.AltaProducto(ObtenerEntidad())
        End Function

        Friend Function Modificar() As String
            Return NegProductos.ModificacionProducto(ObtenerEntidad())
        End Function

        Friend Function Eliminar(id_Producto As Integer) As String
            Return NegProductos.EliminarProducto(id_Producto)
        End Function

        Friend Function Cargar(id_Producto As Integer) As String
            'lleno la entidad productos
            Dim EProductos As Entidades.Productos = NegProductos.TraerProducto(id_Producto)
            EProductos = NegProductos.TraerPrecios(EProductos)

            Me.Actualizar(EProductos)
        End Function


        Private Function ObtenerOpcionesParaCombo(dataTable As DataTable, campoValor As String, campoDescripcion As String, Optional leyendaInicial As String = "Seleccione una opción", Optional leyendaSinDatos As String = "No hay opciones disponibles.") As List(Of KeyValuePair(Of Integer, String))
            Dim Opciones As List(Of KeyValuePair(Of Integer, String)) = New List(Of KeyValuePair(Of Integer, String))()

            For Each items As DataRow In dataTable.Rows
                Opciones.Add(New KeyValuePair(Of Integer, String)(items(campoValor), items(campoDescripcion)))
            Next

            If (Opciones.Count = 0) Then
                Opciones.Insert(0, New KeyValuePair(Of Integer, String)(0, leyendaSinDatos))
            ElseIf (Not String.IsNullOrEmpty(leyendaInicial)) Then
                Opciones.Insert(0, New KeyValuePair(Of Integer, String)(0, leyendaInicial))
            End If

            Return Opciones
        End Function

        Public Sub ActualizarSubcategorias()
            Me.SubcategoriasSeleccionada = 0
            Me.Subcategorias = New BindingList(Of KeyValuePair(Of Integer, String))(ObtenerOpcionesParaCombo(NegProductosSubCat.ListadoSubcategorias(Me.CategoriasSeleccionada).Tables(0), "id_Subcategoria", "Descripcion"))
        End Sub

        Friend Sub ActualizarFoto(RutaFoto As String)
            'guardo la ruta de la imagen en el txt
            Me.FotoRuta = RutaFoto

            'Cargo la imagen en el picturebox.
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(RutaFoto, IO.FileMode.Open, IO.FileAccess.Read)
            Me.Foto = System.Drawing.Image.FromStream(fs)
            fs.Close()
        End Sub
    End Class
End Namespace
