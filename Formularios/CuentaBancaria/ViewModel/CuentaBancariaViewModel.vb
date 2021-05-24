Imports System.ComponentModel
Imports Model = Common.Core.Model

Namespace Formularios.CuentaBancaria
    Public Class CuentaBancariaViewModel
        Public Property Id As Integer
        Public Property Bancos As BindingList(Of KeyValuePair(Of Model.Banco, String)) = New BindingList(Of KeyValuePair(Of Model.Banco, String))
        Public Property BancoSeleccionado As KeyValuePair(Of Model.Banco, String) = New KeyValuePair(Of Model.Banco, String)(Nothing, My.Resources.ComboOpcionSelecioneUnaOpcion)
        Public Property BancoNombre As String
        Public Property CBU As String
        Public Property NumeroCuenta As String
        Public Property CBUAlias As String
        Public Property Titular As String
        Public Property CUIT As String
        Public Property EsCuentaCorriente As Boolean
        Public Property Habilitado As Boolean = True
    End Class
End Namespace
