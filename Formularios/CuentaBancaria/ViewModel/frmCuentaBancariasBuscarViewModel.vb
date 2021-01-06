Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Model = Common.Core.Model
Imports Common.Data.Service
Imports Common.Core.Enum
Imports AutoMapper

Namespace Formularios.CuentaBancaria
    Public Class frmCuentaBancariasBuscarViewModel
        Inherits Comunes.Common

        Public Property BancosBusqueda As BindingList(Of KeyValuePair(Of Model.Banco, String)) = New BindingList(Of KeyValuePair(Of Model.Banco, String))
        Public Property BancoBusquedaSeleccionado As KeyValuePair(Of Model.Banco, String)

        Public Property CuentasBancariasListado As BindingList(Of CuentaBancariaItem) = New BindingList(Of CuentaBancariaItem)
        Public ReadOnly Property SinResultados As Boolean
            Get
                Return Not CuentasBancariasListado.Any()
            End Get
        End Property

        Friend Async Function BuscarAsync() As Task
            CuentasBancariasListado.Clear()
            Dim cuentasBancarias As List(Of Model.CuentaBancaria) = Await CuentaBancariaService.ObtenerAsync(TipoBase.Local, BancoBusquedaSeleccionado.Key?.Id, True)
            cuentasBancarias.ForEach(Sub(x) CuentasBancariasListado.Add(New CuentaBancariaItem(x)))

            NotifyPropertyChanged(NameOf(Me.SinResultados))
        End Function

        Friend Sub Limpiar()
            BancoBusquedaSeleccionado = BancosBusqueda.First()
        End Sub

        Friend Async Function CargarBancosAsync() As Task
            Dim bancosModel As List(Of Model.Banco) = Await BancoService.ObtenerAsync(TipoBase.Local)

            BancosBusqueda.Add(New KeyValuePair(Of Model.Banco, String)(Nothing, My.Resources.ComboOpcionTodos))
            bancosModel.ForEach(Sub(x) BancosBusqueda.Add(New KeyValuePair(Of Model.Banco, String)(x, x.Nombre)))
        End Function
    End Class
End Namespace