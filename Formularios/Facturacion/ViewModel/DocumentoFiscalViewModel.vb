Imports Common.Core.Enum

Namespace Formularios.Facturacion
    Public Class DocumentoFiscalViewModel
        Public Property Id As Long
        Public Property Numero As String
        Public Property PuntoVenta As Integer
        Public Property TipoFactura As TipoFactura
        Public Property CondicionIVA As CondicionIVA
        Public Property NombreYApellido As String
        Public Property Direccion As String
        Public Property Localidad As String
        Public Property CUIT As String
        Public Property Monto As Decimal
        Public Property Fecha As DateTime
        Public Property CAE As String
        Public Property FechaVenciminetoCAE As DateTime?

        Public ReadOnly Property HabilitarImprimirFacturaElectronica As Boolean
            Get
                Return TipoFactura = TipoFactura.Electronica
            End Get
        End Property
    End Class
End Namespace
