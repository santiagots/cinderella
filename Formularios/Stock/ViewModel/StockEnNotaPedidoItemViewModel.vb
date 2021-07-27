
Imports Ventas.Core.Model.NotaPedidoAgreggate

Namespace Formularios.Stock
    Public Class StockEnNotaPedidoItemViewModel
        Private IdProducto As Integer
        Private _NotaPedido As NotaPedido
        Public ReadOnly Property NotaPedido As NotaPedido
            Get
                Return _NotaPedido
            End Get
        End Property

        Public ReadOnly Property Fecha As Date
            Get
                Return NotaPedido.Fecha
            End Get
        End Property

        Public ReadOnly Property Cliente As String
            Get
                Return If(NotaPedido.TipoCliente = Common.Core.Enum.TipoCliente.Mayorista, NotaPedido.ClienteMayorista.RazonSocial, "Cliente Minorista")
            End Get
        End Property

        Public ReadOnly Property Estado As String
            Get
                Return NotaPedido.Estado.ToString()
            End Get
        End Property

        Public ReadOnly Property Cantidad As Integer
            Get
                Dim cant As Integer? = NotaPedido.NotaPedidoItems.FirstOrDefault(Function(x) x.IdProducto = IdProducto)?.Cantidad
                Return If(cant.HasValue, cant.Value, 0)
            End Get
        End Property

        Public ReadOnly Property NumeroNotaPedido As Integer
            Get
                Return NotaPedido.Numero
            End Get
        End Property

        Public Sub New(idProducto As Integer, notaPedido As NotaPedido)
            Me.IdProducto = idProducto
            Me._NotaPedido = notaPedido
        End Sub
    End Class
End Namespace