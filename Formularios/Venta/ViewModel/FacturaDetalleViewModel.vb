Imports System.ComponentModel
Imports Common.Core.Enum
Imports Common.Core.Extension

Namespace Formularios.Venta
    Public Class FacturaDetalleViewModel

        Private tipoCliente As TipoCliente

        Public ReadOnly Property TiposFactura As BindingList(Of TipoFactura)
            Get
                Return New BindingList(Of TipoFactura)([Enum](Of TipoFactura).ToList())
            End Get
        End Property
        Public Property TiposFacturaSeleccionada As TipoFactura
        Public Property EstadoControladorFiscal As String
        Public Property Fecha As DateTime
        Public Property Subtotal As Decimal
        Public Property Descuento As Decimal
        Public Property CostoFinanciero As Decimal
        Public Property Iva As Decimal
        Public Property Total As Decimal
        Public ReadOnly Property CondicionesIVA As BindingList(Of CondicionIVA)
            Get
                Return New BindingList(Of CondicionIVA)([Enum](Of CondicionIVA).ToList())
            End Get
        End Property
        Public Property CondicionesIVASeleccionada As CondicionIVA
        Public Property NombreYApellido As String
        Public Property Direccion As String
        Public Property Localidad As String
        Public Property CUIT As String
        Public Property Numerofactura As String
        Public ReadOnly Property Numerosfacturas As BindingList(Of Integer)
        Public Property LimiteFacturacion As Boolean
        Public ReadOnly Property HabilitarFacturar As Boolean
            Get
                Return Not LimiteFacturacion
            End Get
        End Property

        Public ReadOnly Property HabilitarFacturacionManual As Boolean
            Get
                Return TiposFacturaSeleccionada = TipoFactura.Manual
            End Get
        End Property

        Public ReadOnly Property HabilitarDatosCliente As Boolean
            Get
                Return tipoCliente = TipoCliente.Mayorista
            End Get
        End Property

        Sub New(tipoCliente As TipoCliente)
            Me.tipoCliente = tipoCliente
        End Sub
    End Class
End Namespace
