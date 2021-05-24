Public Enum MoviminetoSocios
    Retiro
    Aporte
End Enum


Public Class MovSocios
    Public Property id_Movimiento As Int64
    Public Property id_Sucursal As Integer
    Public Property Monto As Double
    Public Property Descripcion As String
    Public Property Encargado As String
    Public Property Persona As String
    Public Property Fecha As Date
    Public Property IdTipoPago As String
    Public Property IdCheque As Int64
    Public Property FechaEdicion As DateTime
End Class
