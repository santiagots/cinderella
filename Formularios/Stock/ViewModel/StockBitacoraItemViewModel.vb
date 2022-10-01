Imports Model = Stock.Core.Model.BaseAgreggate

Namespace Formularios.Stock
    Public Class StockBitacoraItemViewModel
        Public Property Bitacora As Model.Bitacora

        Public ReadOnly Property Fecha As String
            Get
                Return Bitacora.Fecha
            End Get
        End Property

        Public ReadOnly Property ProductoCodigo As String
            Get
                Return Bitacora.Producto.Codigo
            End Get
        End Property

        Public ReadOnly Property ProductoNombre As String
            Get
                Return Bitacora.Producto.Nombre
            End Get
        End Property

        Public ReadOnly Property StockActualAnterior As Integer
            Get
                Return Bitacora.StockActualAnterior
            End Get
        End Property

        Public ReadOnly Property StockActual As Integer
            Get
                Return Bitacora.StockActual
            End Get
        End Property

        Public ReadOnly Property StockMinimoAnterior As Integer
            Get
                Return Bitacora.StockMinimoAnterior
            End Get
        End Property

        Public ReadOnly Property StockMinimo As Integer
            Get
                Return Bitacora.StockMinimo
            End Get
        End Property

        Public ReadOnly Property StockOptimoAnterior As Integer
            Get
                Return Bitacora.StockOptimoAnterior
            End Get
        End Property

        Public ReadOnly Property StockOptimo As Integer
            Get
                Return Bitacora.StockOptimo
            End Get
        End Property

        Public ReadOnly Property usuario As String
            Get
                Return Bitacora.Usuario?.UsuarioNombre
            End Get
        End Property

        Public ReadOnly Property Motivo As String
            Get
                Return Bitacora.Motivo
            End Get
        End Property

        Public ReadOnly Property Accion As String
            Get
                Return Bitacora.Accion.ToString()
            End Get
        End Property

        Public ReadOnly Property Total As Decimal
            Get
                Return Bitacora.Total
            End Get
        End Property

        Sub New(bitacora As Model.Bitacora)
            Me.Bitacora = bitacora
        End Sub
    End Class
End Namespace
