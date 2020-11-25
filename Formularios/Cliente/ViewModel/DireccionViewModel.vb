Imports Common.Core.Model

Namespace Formularios.Cliente
    Public Class DireccionViewModel
        Public Property Direccion As String
        Public Property ProvinciasSaleccionada As KeyValuePair(Of Provincia, String)
        Public Property Provincias As SortableBindingList(Of KeyValuePair(Of Provincia, String))
        Public Property DistritosSaleccionada As KeyValuePair(Of Distrito, String)
        Public Property Distritos As SortableBindingList(Of KeyValuePair(Of Distrito, String))
        Public Property LocalidadesSaleccionada As KeyValuePair(Of Localidad, String)
        Public Property Localidades As SortableBindingList(Of KeyValuePair(Of Localidad, String))
        Public Property CodigoPostal As String
        Public Property Telefono As String
        Public Property Mail As String
    End Class
End Namespace
