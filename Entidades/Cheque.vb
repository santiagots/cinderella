Public Enum ChequeEstado
    Ingresado = 0
    Salido = 1
    Reingresado = 2
End Enum

Public Enum ChequeDestinoSalida
    SinSalida = 0
    Depositado = 1
    Pasado = 2
    Devuelto = 3
    Otro = 4
End Enum

Public Class Cheque
    Public Property IdCheque As Int64
    Public Property NumeroOrden As Integer
    Public Property MarcaFacturado As Boolean
    Public Property FechaIngreso As Date
    Public Property ClienteId As Integer
    Public Property ClienteNombre As String
    Public Property LibradorId As Integer
    Public Property LibradorNombre As String
    Public Property BancoEmisorId As Integer
    Public Property NumeroCheque As Integer
    Public Property FechaDesposito As Date
    Public Property FechaVencimiento As Date
    Public Property Importe As Double
    Public Property FechaSalida As Date?
    Public Property DetalleSalida As String
    Public Property SucursalId As Integer
    Public Property Estado As ChequeEstado
    Public Property DestinoSalida As ChequeDestinoSalida
    Public Property FechaEdicion As DateTime
End Class
