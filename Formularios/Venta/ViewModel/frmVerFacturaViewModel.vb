Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Ventas.Core.Model.VentaAggregate

Namespace Formularios.Venta
    Public Class frmVerFacturaViewModel
        Inherits SistemaCinderella.VistaModelo.Common

        Private IdFactura As Long

        Public Property Fecha As DateTime
        Public Property Monto As Decimal
        Public Property NumerosFacturas As Decimal
        Public Property CondicionIVA As CondicionIVA
        Public Property NombreYApellido As String
        Public Property Direccion As String
        Public Property Localidad As String
        Public Property Cuit As String

        Sub New(idFactura As Long)
            Me.IdFactura = idFactura
        End Sub

        Friend Async Function CargarFacturaAsync() As Task
            Dim factura As Factura = Await Task.Run(Function() Servicio.ObtenerFactura(IdFactura))
            Fecha = factura.Venta.Fecha
            NotifyPropertyChanged(NameOf(Me.Fecha))

            Monto = factura.Venta.PagoTotal.Total
            NotifyPropertyChanged(NameOf(Me.Monto))

            NumerosFacturas = String.Join("; ", factura.NumeroFactura.Select(Function(x) x.Numero))
            NotifyPropertyChanged(NameOf(Me.NumerosFacturas))

            NombreYApellido = factura.NombreYApellido
            NotifyPropertyChanged(NameOf(Me.NombreYApellido))

            Direccion = factura.Direccion
            NotifyPropertyChanged(NameOf(Me.Direccion))

            Localidad = factura.Localidad
            NotifyPropertyChanged(NameOf(Me.Localidad))

            Cuit = factura.CUIT
            NotifyPropertyChanged(NameOf(Me.Cuit))
        End Function

    End Class
End Namespace