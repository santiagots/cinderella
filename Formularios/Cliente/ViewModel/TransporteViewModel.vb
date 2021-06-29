Imports System.ComponentModel
Imports Common.Core.Model

Namespace Formularios.Cliente
    Public Class TransporteViewModel
        Public Property Id As Integer
        Public Property IdDireccion As Integer
        Public Property RazonSocial As String
        Public Property CUIT As String
        Public Property Habilitado As Boolean = True
        Public Property Direccion As String
        Public Property Provincias As BindingList(Of KeyValuePair(Of Provincia, String)) = New BindingList(Of KeyValuePair(Of Provincia, String))()
        Public Property Distritos As BindingList(Of KeyValuePair(Of Distrito, String)) = New BindingList(Of KeyValuePair(Of Distrito, String))()
        Public Property Localidades As BindingList(Of KeyValuePair(Of Localidad, String)) = New BindingList(Of KeyValuePair(Of Localidad, String))()
        Public Property ProvinciasSaleccionada As Provincia
        Public Property DistritosSaleccionada As Distrito
        Public Property LocalidadesSaleccionada As Localidad
        Public Property CodigoPostal As String
    End Class
End Namespace