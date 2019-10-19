Imports Producto.Core.Model.ProductoAgreggate
Imports System.ComponentModel

Namespace Formularios.Producto
    Public Class ProductoDetalleViewModel
        Public Property Id As Integer
        Public Property Nombre As String
        Public Property Origen As String
        Public Property Tamanio As String
        Public Property Codigo As String
        Public Property Costo As Decimal
        Public Property FotoRuta As String
        Public Property Categoria As Categoria
        Public Property SubCategoria As SubCategoria
        Public Property Proveedor As Proveedor
        Public Property Habilitado As Boolean
        Public Property SubirAWeb As Boolean
        Public Property Novedad As Boolean
        Public Property EliminarFoto As Boolean
        Public Property Descripcion As String
        Public Property ListaTigre As Decimal
        Public Property PorcentajeDescuentoTigre As Decimal
        Public Property ListaCapital As Decimal
        Public Property PorcentajeDescuentoCapital As Decimal
        Public Property Mayorista As Decimal
        Public Property Alternativo As Decimal
        Public Property CodigoBarras As String
        Public Property CodigoBarrasImagen As Image
        Public Property Foto As Image

    End Class
End Namespace
