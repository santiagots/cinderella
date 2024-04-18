Imports SistemaCinderella.Comunes

Namespace Formularios.Comex
    Public Class ComexOrdenCompraItemsViewModel
        Public Property SupplierCode As String
        Public Property ProductType As String
        Public Property QtyOfLights As Integer
        Public Property BoxSize As String
        Public Property Codigo As String
        Public Property Modelo As String
        Public Property Nombre As String
        Public Property Color As String
        Public Property ProductSize As String
        Public Property FOBUSD As Decimal
        Public Property TotalUSD As Decimal
        Public Property FOBRMB As Decimal
        Public Property TotalRMB As Decimal
        Public Property InPacking As Integer
        Public Property Packing As Integer
        Public Property BoxQTY As Integer
        Public Property TotalPCS As Integer
        Public Property UCBM As Integer
        Public Property TotalCBM As Integer

        Public Function Copiar() As ComexOrdenCompraItemsViewModel
            Return DirectCast(Me.MemberwiseClone(), ComexOrdenCompraItemsViewModel)
        End Function
    End Class
End Namespace