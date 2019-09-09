Imports System.ComponentModel
Imports Common.Core.Enum
Imports SistemaCinderella.VistaModelo.Ventas

Namespace VistaModelo.Ventas
    Public Class VentaDetalleViewModel
        Public Property Sucursal As String
        Public Property TipoCliente As TipoCliente
        Public Property NombreClienteMayorista As String
        Public Property PorcentajeFacturacion As Decimal
        Public Property Fecha As DateTime
        Public Property NombreVendedor As String
        Public Property NombreEncargado As String
        Public Property VentaItems As BindingList(Of VentaItemViewModel)
        Public Property TotalVentaItem As BindingList(Of VentaItemViewModel)
        Public Property Pagos As BindingList(Of PagoViewModel)
        Public Property TotalPago As BindingList(Of PagoViewModel)

        Sub New()
            VentaItems = New BindingList(Of VentaItemViewModel)()
            TotalVentaItem = New BindingList(Of VentaItemViewModel)()
            Pagos = New BindingList(Of PagoViewModel)()
            TotalPago = New BindingList(Of PagoViewModel)()
        End Sub

    End Class
End Namespace
