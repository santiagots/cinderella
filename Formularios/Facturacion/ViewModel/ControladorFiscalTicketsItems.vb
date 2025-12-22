Imports Model = Ventas.Core.Model.VentaAggregate

Namespace Formularios.Facturacion
    Public Class ControladorFiscalTicketsItems
        Private Factura As Model.Factura

        Public ReadOnly Property Numero As String
            Get
                Return Factura.NumeroFactura?.FirstOrDefault()?.Numero.ToString()
            End Get
        End Property
        Public ReadOnly Property PuntoVenta As Integer
            Get
                Return Factura.PuntoVenta
            End Get
        End Property
        Public ReadOnly Property TipoFactura As String
            Get
                Return Factura.TipoFactura.ToString()
            End Get
        End Property
        Public ReadOnly Property CondicionIVA As String
            Get
                Return Factura.CondicionIVA.ToString()
            End Get
        End Property
        Public ReadOnly Property CUIT As String
            Get
                Return Factura.CUIT
            End Get
        End Property
        Public ReadOnly Property Nombre As String
            Get
                Return Factura.NombreYApellido
            End Get
        End Property
        Public ReadOnly Property Direccion As String
            Get
                Return Factura.Direccion
            End Get
        End Property
        Public ReadOnly Property Localidad As String
            Get
                Return Factura.Localidad
            End Get
        End Property
        Public ReadOnly Property Provincia As String
            Get
                Return Factura.Provincia
            End Get
        End Property
        Public ReadOnly Property Fecha As Date
            Get
                Return Factura.Fecha
            End Get
        End Property
        Public ReadOnly Property Subtotal As Decimal
            Get
                Return Factura.SubTotal
            End Get
        End Property
        Public ReadOnly Property Iva As Decimal
            Get
                Return Factura.Iva
            End Get
        End Property
        Public ReadOnly Property Total As Decimal
            Get
                Return Factura.Total
            End Get
        End Property
        Public ReadOnly Property Impuestos As List(Of ControladorFiscalImpuestoItem)
            Get
                Return Factura.Percepciones?.Select(Function(x) New ControladorFiscalImpuestoItem With {.Descripcion = x.Comcepto, .Monto = x.Monto}).ToList()
            End Get
        End Property

        Sub New(factura As Model.Factura)
            Me.Factura = factura
        End Sub
    End Class

    Public Class ControladorFiscalImpuestoItem
        Public Property Descripcion As String
        Public Property Monto As Decimal
    End Class
End Namespace
