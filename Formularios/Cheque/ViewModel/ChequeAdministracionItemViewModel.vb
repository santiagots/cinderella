Imports Common.Core.Enum

Namespace Formularios.Cheque
    Public Class ChequeAdministracionItemViewModel
        Property Id As Long
        Property NumeroOrden As Integer
        Property NumeroCheque As Integer
        Property MarcaFacturado As Boolean
        Property FechaIngreso As DateTime
        Property ClienteNombre As String
        Property LibradorNombre As String
        Property BancoEmisor As String
        Property Monto As Decimal
        Property FechaDesposito As DateTime
        Property FechaVencimiento As DateTime
        Property FechaSalida As DateTime?
        Property Estado As EstadoCheque
        Property DestinoSalida As DestinoSalidaCheque
    End Class
End Namespace