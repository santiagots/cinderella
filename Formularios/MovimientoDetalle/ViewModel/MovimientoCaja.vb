Imports Ventas.Core.Enum

Namespace Formularios.MovimientoDetalle
    Public Class MovimientoCaja
        Public Property Fecha As DateTime
        Public Property Monto As Decimal
        Public Property Diferencia As Decimal
        Public Property Estado As CierreCajaEstado
        Public Property Comentarios As String
    End Class
End Namespace
