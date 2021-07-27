Namespace Comunes
    Public Class VentaItemViewModel
        Public Property Codigo As String
        Public Property Nombre As String
        Public Property PorcentajeBonificacion As Decimal
        Public Property PorcentajePago As Decimal
        Public Property Cantidad As Integer
        Public Property Monto As Decimal
        Public Property Iva As Decimal
        Public Property Total As Decimal

        Public Sub New()
        End Sub

        Public Function Copiar() As VentaItemViewModel
            Return DirectCast(Me.MemberwiseClone(), VentaItemViewModel)
        End Function

        Public Overrides Function Equals(obj As Object) As Boolean

            Dim VentaItemViewModel As VentaItemViewModel = CType(obj, VentaItemViewModel)

            Return Codigo = VentaItemViewModel.Codigo AndAlso
                   PorcentajeBonificacion = VentaItemViewModel.PorcentajeBonificacion AndAlso
                   PorcentajePago = VentaItemViewModel.PorcentajePago AndAlso
                   Cantidad = VentaItemViewModel.Cantidad AndAlso
                   Monto = VentaItemViewModel.Monto AndAlso
                   Iva = VentaItemViewModel.Iva AndAlso
                   Total = VentaItemViewModel.Total
        End Function
    End Class
End Namespace
