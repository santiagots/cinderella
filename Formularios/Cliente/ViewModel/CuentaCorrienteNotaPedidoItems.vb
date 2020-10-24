Imports Ventas.Core.Enum
Imports Ventas.Core.Model.NotaPedidoAgreggate

Namespace Formularios.Cliente
    Public Class CuentaCorrienteNotaPedidoItems

        Public ReadOnly Movimiento As NotaPedido

        Public ReadOnly Property Numero As Integer
            Get
                Return Movimiento.Numero
            End Get
        End Property

        Public ReadOnly Property Vendedor As String
            Get
                Return Movimiento.Vendedor.ApellidoYNombre
            End Get
        End Property

        Public ReadOnly Property MontoTotal As Decimal
            Get
                Return Movimiento.MontoTotal.toDecimal()
            End Get
        End Property

        Public ReadOnly Property Fecha As DateTime
            Get
                Return Movimiento.Fecha
            End Get
        End Property

        Public ReadOnly Property Estado As NotaPedidoEstado
            Get
                Return Movimiento.Estado
            End Get
        End Property

        Sub New(movimiento As NotaPedido)
            Me.Movimiento = movimiento
        End Sub
    End Class
End Namespace
