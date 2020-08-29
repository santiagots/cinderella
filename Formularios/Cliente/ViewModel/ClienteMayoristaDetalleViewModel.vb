Imports System.ComponentModel
Imports Common.Core.Enum
Imports Common.Core.Model

Namespace Formularios.Cliente
    Public Class ClienteMayoristaDetalleViewModel

        Public Property Id As Integer
        Public Property RazonSocial As String
        Public Property Nombre As String
        Public Property Cuit As String
        Public Property CondicionesIVASaleccionada As KeyValuePair(Of CondicionIVA?, String) = New KeyValuePair(Of CondicionIVA?, String)(Nothing, "Seleccione una opción")
        Public Property CorredorSaleccionada As KeyValuePair(Of Integer?, String) = New KeyValuePair(Of Integer?, String)(Nothing, "Seleccione una opción")
        Public Property Comision As Decimal 
        Public Property Transporte As String
        Public Property Bonificacion As Decimal
        Public Property Lista As Decimal
        Public Property CondicionPago As String
        Public Property EmpresaSaleccionada As KeyValuePair(Of Integer?, String) = New KeyValuePair(Of Integer?, String)(Nothing, "Seleccione una opción")
        Public Property ListaPreciosSaleccionada As KeyValuePair(Of Integer?, String) = New KeyValuePair(Of Integer?, String)(Nothing, "Seleccione una opción")
        Public Property Observaciones As String
        Public Property FacturacionId As Integer
        Public Property FacturacionDireccion As String
        Public Property FacturacionProvincias As BindingList(Of KeyValuePair(Of Provincia, String)) = New BindingList(Of KeyValuePair(Of Provincia, String))()
        Public Property FacturacionDistritos As BindingList(Of KeyValuePair(Of Distrito, String)) = New BindingList(Of KeyValuePair(Of Distrito, String))()
        Public Property FacturacionLocalidades As BindingList(Of KeyValuePair(Of Localidad, String)) = New BindingList(Of KeyValuePair(Of Localidad, String))()
        Public Property FacturacionProvinciasSaleccionada As Provincia
        Public Property FacturacionDistritosSaleccionada As Distrito
        Public Property FacturacionLocalidadesSaleccionada As Localidad
        Public Property FacturacionCodigoPostal As String
        Public Property FacturacionTelefono As String
        Public Property FacturacionMail As String
        Public Property EntregaId As Integer
        Public Property EntregaDireccion As String
        Public Property EntregaProvincias As BindingList(Of KeyValuePair(Of Provincia, String)) = New BindingList(Of KeyValuePair(Of Provincia, String))()
        Public Property EntregaDistritos As BindingList(Of KeyValuePair(Of Distrito, String)) = New BindingList(Of KeyValuePair(Of Distrito, String))()
        Public Property EntregaLocalidades As BindingList(Of KeyValuePair(Of Localidad, String)) = New BindingList(Of KeyValuePair(Of Localidad, String))()
        Public Property EntregaProvinciasSaleccionada As Provincia
        Public Property EntregaDistritosSaleccionada As Distrito
        Public Property EntregaLocalidadesSaleccionada As Localidad
        Public Property EntregaCodigoPostal As String
    End Class
End Namespace
