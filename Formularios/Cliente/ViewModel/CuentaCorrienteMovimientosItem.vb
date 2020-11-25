Imports Common.Core.Enum
Imports Ventas.Core.Model.CuentaCorrienteAggregate

Namespace Formularios.Cliente
    Public Class CuentaCorrienteMovimientosItem
        Public ReadOnly Movimiento As Movimiento

        Public ReadOnly Property Fecha As DateTime
            Get
                Return Movimiento.Fecha
            End Get
        End Property

        Public ReadOnly Property Sucursal As String
            Get
                Return Movimiento.Sucursal.Nombre
            End Get
        End Property

        Public ReadOnly Property TipoMovimientoCuentaCorriente As TipoMovimientoCuentaCorriente
            Get
                Return Movimiento.TipoMovimientoCuentaCorriente
            End Get
        End Property

        Public ReadOnly Property TipoAccionCuentaCorriente As TipoAccionCuentaCorriente
            Get
                Return Movimiento.TipoAccionCuentaCorriente
            End Get
        End Property

        Public ReadOnly Property NumeroComprobante As String
            Get
                Return Movimiento.NumeroComprobante
            End Get
        End Property

        Public ReadOnly Property Monto As Decimal
            Get
                Return Movimiento.Monto
            End Get
        End Property

        Public ReadOnly Property Saldo As Decimal
            Get
                Return Movimiento.Saldo
            End Get
        End Property

        Sub New(movimiento As Movimiento)
            Me.Movimiento = movimiento
        End Sub
    End Class
End Namespace
