Imports System.ComponentModel
Imports Common.Core.[Enum]
Imports Common.Core.Model

Namespace Formularios.Facturacion
    Public Class PercepcionDetalleViewModel
        Public Property Id As Integer
        Public Property TipoClienteSeleccionado As KeyValuePair(Of TipoCliente?, String)
        Public Property TiposCliente As BindingList(Of KeyValuePair(Of TipoCliente?, String)) = New BindingList(Of KeyValuePair(Of TipoCliente?, String))()
        Public Property TipoCondicionIVASeleccionado As KeyValuePair(Of CondicionIVA?, String)
        Public Property TipoCondicionIVA As BindingList(Of KeyValuePair(Of CondicionIVA?, String)) = New BindingList(Of KeyValuePair(Of CondicionIVA?, String))()
        Public Property TipoPrecepcionSeleccionado As KeyValuePair(Of TipoPercepcionFactura?, String)
        Public Property TiposPrecepcion As BindingList(Of KeyValuePair(Of TipoPercepcionFactura?, String)) = New BindingList(Of KeyValuePair(Of TipoPercepcionFactura?, String))()
        Public Property ProvinciaSeleccionado As KeyValuePair(Of Provincia, String)
        Public Property HabilitarProvincia As Boolean
        Public Property Provincias As BindingList(Of KeyValuePair(Of Provincia, String)) = New BindingList(Of KeyValuePair(Of Provincia, String))()
        Public Property Descripcion As String
        Public Property MontoDesde As Decimal
        Public Property Alicuota As Decimal
        Public Property Habilitada As Boolean
    End Class
End Namespace
