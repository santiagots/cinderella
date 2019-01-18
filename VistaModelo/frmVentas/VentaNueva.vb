Imports System.ComponentModel
Imports Model = Ventas.Core.Model.VentaAggregate
Imports ValueObjects = Ventas.Core.Model.ValueObjects

Namespace VistaModelo.frmVentas
    Public Class VentaNueva
        Inherits Common

        Private ventaModel As Model.Venta

        Public Sub New()
            ventaModel = New Model.Venta()
        End Sub

        Public ReadOnly Property VentaItem As BindingList(Of Model.VentaItem)
            Get
                Return New BindingList(Of Model.VentaItem)(ventaModel.VentaItems.ToList())
            End Get
        End Property

        Public ReadOnly Property TotalVentaItem As ValueObjects.MontoProducto
            Get
                Return ventaModel.MontoTotal
            End Get
        End Property

        Public ReadOnly Property Pagos As BindingList(Of Model.Pago)
            Get
                Return New BindingList(Of Model.Pago)(ventaModel.Pagos.ToList())
            End Get
        End Property

        Public ReadOnly Property TotalPago As ValueObjects.MontoPago
            Get
                Return ventaModel.PagoTotal
            End Get
        End Property

    End Class
End Namespace
