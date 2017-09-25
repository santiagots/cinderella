Imports Datos

Public Class Tabla
    Public Property Nombre As String
    Public Property ClaveSincronizacion As String
    Public Property ClavePrimaria As String
    Public Property ClaveForanea As String()
    Public Property ColumnaOrden As String
    Public Property ColumnaSeleccion As String
    Public Property DatosSincronizar As DataTable
    Public Property TablaRelacionada As IList(Of Tabla)
    Public Property Sincronizar As Sincronizar
    Public Property IdAcualizados As IList(Of KeyValuePair(Of Integer, Integer))
    Public Property valorBusqueda As String
    Public Property SQLObtenerDatosLocal As String
    Public Property SQLObtenerDatosRemoto As String
End Class
