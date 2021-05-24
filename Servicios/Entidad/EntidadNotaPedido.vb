Imports Common.Core.Enum

Public Class EntidadNotaPedido
    Public Property IdSucursal As Integer
    Public Property TipoPago As TipoPago
    Public Property IdEmpleado As Integer
    Public Property TipoCliente As TipoCliente
    Public Property IdCliente As Integer
    Public Property Items As List(Of EntidadNotaPedidoItems)
End Class

