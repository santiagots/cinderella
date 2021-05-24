Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Common.Core.Model

Namespace Formularios.Cheque
    Public Class ChequeDetalleViewModel
        Inherits Comunes.Common
        Property Id As Long
        Property NumeroOrden As Integer
        Property NumeroCheque As Integer
        Property MarcaFacturado As Boolean
        Property FechaIngreso As DateTime
        Property IdCliente As Integer?
        Property ClienteNombre As String
        Property IdLibrador As Integer
        Property LibradorNombre As String
        Property BancosEmisores As BindingList(Of KeyValuePair(Of Integer?, String))
        Property BancoEmisorSeleccionado As KeyValuePair(Of Integer?, String)
        Property Monto As Decimal
        Property FechaDesposito As DateTime
        Property FechaVencimiento As DateTime

        Sub New()
            BancosEmisores = New BindingList(Of KeyValuePair(Of Integer?, String))()
            FechaIngreso = DateTime.Now
            FechaDesposito = DateTime.Now
            FechaVencimiento = FechaIngreso.AddDays(30)
            BancoEmisorSeleccionado = New KeyValuePair(Of Integer?, String)(Nothing, "Selecciones una opción")
        End Sub
    End Class
End Namespace
