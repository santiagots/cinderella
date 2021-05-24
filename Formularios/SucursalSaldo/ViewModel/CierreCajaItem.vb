Imports Ventas.Core.Enum

Namespace Formularios.SucursalSaldo
    Public Class CierreCajaItem
        Public Property Fecha As DateTime
        Public Property Monto As Decimal
        Public Property Diferencia As Decimal
        Public Property Situacion As CierreCajaSituacion
        Public Property Comentarios As String
    End Class
End Namespace