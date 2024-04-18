Imports Modelo = Comex.Core.Model.ComexAggregate

Namespace Formularios.Comex
    Public Class BuscarProductoComexItemViewModel
        Public ReadOnly Producto As Modelo.Producto

        Public ReadOnly Property SupplierCode As String
            Get
                Return Producto.SupplierProductCode
            End Get
        End Property

        Public ReadOnly Property ProductType As String
            Get
                Return If(Producto.ProductType IsNot Nothing, Producto.ProductType.Nombre, String.Empty)
            End Get
        End Property

        Public ReadOnly Property QtyOfLights As Integer
            Get
                Return Producto.QtyOfLights
            End Get
        End Property

        Public ReadOnly Property BoxSize As String
            Get
                Return If(Producto.BoxSize IsNot Nothing, $"{Producto.BoxSize.X} X {Producto.BoxSize.Y} X {Producto.BoxSize.Z}", String.Empty)
            End Get
        End Property

        Public ReadOnly Property Codigo As String
            Get
                Return Producto.Codigo
            End Get
        End Property

        Public ReadOnly Property Modelo As String
            Get
                Return Producto.Modelo
            End Get
        End Property

        Public ReadOnly Property Nombre As String
            Get
                Return Producto.Nombre
            End Get
        End Property

        Public ReadOnly Property Color As String
            Get
                Return If(Producto.Color IsNot Nothing, Producto.Color.Nombre, String.Empty)
            End Get
        End Property

        Public ReadOnly Property ProductSize As String
            Get
                Return If(Producto.ProductSize IsNot Nothing, $"{Producto.ProductSize.X} X {Producto.ProductSize.Y} X {Producto.ProductSize.Z}", String.Empty)
            End Get
        End Property

        Public ReadOnly Property FOBUSD As Decimal
            Get
                Return Producto.FOBUSD
            End Get
        End Property

        Public ReadOnly Property FOBRMB As Decimal
            Get
                Return Producto.FOBRMB
            End Get
        End Property

        Public ReadOnly Property InPacking As Integer
            Get
                Return Producto.InPacking
            End Get
        End Property

        Public ReadOnly Property Packing As Integer
            Get
                Return Producto.Packing
            End Get
        End Property

        Public ReadOnly Property UCBM As Integer
            Get
                Return Producto.UCBM
            End Get
        End Property

        Sub New(producto As Modelo.Producto)
            Me.Producto = producto
        End Sub

    End Class
End Namespace
