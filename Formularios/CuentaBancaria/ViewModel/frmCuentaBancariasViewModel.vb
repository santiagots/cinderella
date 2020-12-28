Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Model = Common.Core.Model
Imports Common.Data.Service
Imports Common.Core.Enum
Imports AutoMapper
Imports Common.Core.Exceptions
Imports Common.Core.Helper

Namespace Formularios.CuentaBancaria
    Public Class frmCuentaBancariasViewModel
        Inherits Comunes.Common

        Private bancosModel As List(Of Model.Banco)

        Public Property BancosBusqueda As BindingList(Of KeyValuePair(Of Model.Banco, String)) = New BindingList(Of KeyValuePair(Of Model.Banco, String))
        Public Property BancoBusquedaSeleccionado As KeyValuePair(Of Model.Banco, String)
        Public Property Habilitados As BindingList(Of KeyValuePair(Of Boolean?, String)) = New BindingList(Of KeyValuePair(Of Boolean?, String))
        Public Property HabilitadosSeleccionado As KeyValuePair(Of Boolean?, String)

        Public Property CuentasBancariasListado As BindingList(Of CuentaBancariaViewModel) = New BindingList(Of CuentaBancariaViewModel)
        Public Property CuentaBancariaAlta As CuentaBancariaViewModel = New CuentaBancariaViewModel()
        Public Property CuentaBancariaModificar As CuentaBancariaViewModel = New CuentaBancariaViewModel()

        Friend Async Function BuscarAsync() As Task
            CuentasBancariasListado.Clear()
            Dim cuentasBancarias As List(Of Model.CuentaBancaria) = Await CuentaBancariaService.ObtenerAsync(TipoBase.Remota, BancoBusquedaSeleccionado.Key?.Id, HabilitadosSeleccionado.Key)
            cuentasBancarias.ForEach(Sub(x) CuentasBancariasListado.Add(Mapper.Map(Of CuentaBancariaViewModel)(x)))
        End Function

        Friend Async Function CargarBancosAsync() As Task
            bancosModel = Await BancoService.ObtenerAsync(TipoBase.Remota)

            BancosBusqueda.Clear()
            CuentaBancariaAlta.Bancos.Clear()
            CuentaBancariaModificar.Bancos.Clear()

            BancosBusqueda.Add(New KeyValuePair(Of Model.Banco, String)(Nothing, My.Resources.ComboOpcionTodos))
            CuentaBancariaAlta.Bancos.Add(New KeyValuePair(Of Model.Banco, String)(Nothing, My.Resources.ComboOpcionSelecioneUnaOpcion))
            CuentaBancariaModificar.Bancos.Add(New KeyValuePair(Of Model.Banco, String)(Nothing, My.Resources.ComboOpcionSelecioneUnaOpcion))

            bancosModel.ForEach(Sub(x) BancosBusqueda.Add(New KeyValuePair(Of Model.Banco, String)(x, x.Nombre)))
            bancosModel.ForEach(Sub(x) CuentaBancariaAlta.Bancos.Add(New KeyValuePair(Of Model.Banco, String)(x, x.Nombre)))
            bancosModel.ForEach(Sub(x) CuentaBancariaModificar.Bancos.Add(New KeyValuePair(Of Model.Banco, String)(x, x.Nombre)))
        End Function

        Friend Sub CargarHabilitado()
            Habilitados.Add(New KeyValuePair(Of Boolean?, String)(Nothing, "Todos"))
            Habilitados.Add(New KeyValuePair(Of Boolean?, String)(True, "Si"))
            Habilitados.Add(New KeyValuePair(Of Boolean?, String)(False, "No"))
        End Sub

        Friend Async Function AgregarAsync() As Task
            ValidarRequeridos(CuentaBancariaAlta)
            Dim cuentaBancaria As Model.CuentaBancaria = Mapper.Map(Of Model.CuentaBancaria)(CuentaBancariaAlta)
            Await CuentaBancariaService.GuardarAsync(TipoBase.Remota, cuentaBancaria)
        End Function

        Friend Async Function ModificarAsync() As Task
            ValidarRequeridos(CuentaBancariaModificar)
            Dim cuentaBancaria As Model.CuentaBancaria = Mapper.Map(Of Model.CuentaBancaria)(CuentaBancariaModificar)
            Await CuentaBancariaService.ActualizarAsync(TipoBase.Remota, cuentaBancaria)
        End Function

        Friend Sub Cargar(cuentaBancariaViewModel As CuentaBancariaViewModel)
            CuentaBancariaModificar = cuentaBancariaViewModel
        End Sub

        Private Sub ValidarRequeridos(cuentaBancariaViewModel As CuentaBancariaViewModel)

            Dim hayError As Boolean = False

            hayError = cuentaBancariaViewModel.BancoSeleccionado.Key Is Nothing OrElse hayError
            hayError = String.IsNullOrEmpty(cuentaBancariaViewModel.CBU) OrElse hayError
            hayError = String.IsNullOrEmpty(cuentaBancariaViewModel.NumeroCuenta) OrElse hayError
            hayError = String.IsNullOrEmpty(cuentaBancariaViewModel.CBUAlias) OrElse hayError
            hayError = String.IsNullOrEmpty(cuentaBancariaViewModel.Titular) OrElse hayError
            hayError = String.IsNullOrEmpty(cuentaBancariaViewModel.CUIT) OrElse hayError

            If (hayError) Then
                Throw New NegocioException(My.Resources.ErrorCamposRequeridos)
            End If

            If Not Cuit.EsValido(cuentaBancariaViewModel.CUIT) Then
                Throw New NegocioException(My.Resources.ErrorCuitInvalido)
            End If
        End Sub
    End Class
End Namespace
