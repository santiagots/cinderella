Imports System.ComponentModel
Imports System.Threading.Tasks
Imports AutoMapper
Imports Common.Core.Enum
Imports Common.Core.Model
Imports Common.Data.Service

Namespace Formularios.Cliente
    Public Class frmTrasporteViewModel
        Inherits Comunes.Common

        Private provinciasModel As List(Of Provincia)

        Public Property BuscarRazonSocial As String
        Public Property BuscarCUIT As String
        Public Property BuscarHabilitado As Boolean = True
        Public Property Transportes As BindingList(Of TransporteViewModel)
        Public Property TransportesAlta As TransporteViewModel = New TransporteViewModel()
        Public Property TransportesModificacion As TransporteViewModel = New TransporteViewModel()

        Public Property OrdenadoPor As String = "RazonSocial"
        Public Property DireccionOrdenamiento As OrdenadoDireccion
        Public Property PaginaActual As Integer = 1
        Public Property ElementosPorPagina As Integer
        Public Property TotalElementos As Integer

        Friend Async Function AgregarAsync() As Task
            Dim transporte As Transporte = Mapper.Map(Of Transporte)(TransportesAlta)
            transporte.EstadoEntidad = EstadoEntidad.Nuevo
            transporte.Domicilio.EstadoEntidad = EstadoEntidad.Nuevo
            Await TrasporteService.Guardar(TipoBase.Remota, transporte)

            Limpiar(TransportesAlta)
        End Function

        Private Sub Limpiar(transportes As TransporteViewModel)
            transportes.CodigoPostal = String.Empty
            transportes.Direccion = String.Empty
            transportes.CUIT = String.Empty
            transportes.Habilitado = True
            transportes.RazonSocial = String.Empty
            transportes.Distritos.Clear()
            transportes.DistritosSaleccionada = Nothing
            transportes.Localidades.Clear()
            transportes.LocalidadesSaleccionada = Nothing

            If (provinciasModel IsNot Nothing) Then
                transportes.ProvinciasSaleccionada = provinciasModel.First()
            Else
                transportes.ProvinciasSaleccionada = Nothing
            End If
        End Sub

        Friend Function ModificarAsync() As Task
            Dim transporte As Transporte = Mapper.Map(Of Transporte)(TransportesModificacion)
            transporte.EstadoEntidad = EstadoEntidad.Modificado
            transporte.Domicilio.EstadoEntidad = EstadoEntidad.Modificado
            Return TrasporteService.Guardar(TipoBase.Remota, transporte)
        End Function

        Friend Function CargarDatosAsync() As Task
            Return Task.WhenAll(BuscarAsync(), CargarProvinciasAsync(TransportesAlta, True))
        End Function

        Public Async Function BuscarAsync() As Task
            Dim TransportesModel As List(Of Transporte) = Await TrasporteService.Buscar(TipoBase.Remota, BuscarRazonSocial, BuscarCUIT, BuscarHabilitado, OrdenadoPor, DireccionOrdenamiento, PaginaActual, ElementosPorPagina, TotalElementos)

            Transportes = New BindingList(Of TransporteViewModel)(Mapper.Map(Of List(Of TransporteViewModel))(TransportesModel))

            NotifyPropertyChanged(NameOf(Me.Transportes))
        End Function

        Public Async Function CargarProvinciasAsync(transporteViewModel As TransporteViewModel, reset As Boolean) As Task

            If (provinciasModel Is Nothing) Then
                provinciasModel = Await DomicilioService.ObtenerProvinciaAsync()
            End If

            Dim keyValueProvincias As List(Of KeyValuePair(Of Provincia, String)) = provinciasModel.Select(Function(x) New KeyValuePair(Of Provincia, String)(x, x.Descripcion)).ToList()

            transporteViewModel.Provincias = New BindingList(Of KeyValuePair(Of Provincia, String))(keyValueProvincias)

            If (reset) Then
                transporteViewModel.ProvinciasSaleccionada = keyValueProvincias.First().Key
            End If

            NotifyPropertyChanged(NameOf(transporteViewModel))
        End Function

        Public Async Function CargarDistritoAsync(transporteViewModel As TransporteViewModel, proviencia As Provincia, reset As Boolean) As Task
            Dim idProvincia As Integer = If(proviencia Is Nothing, -1, proviencia.Id)

            Dim distritosModel As List(Of Distrito) = Await DomicilioService.ObtenerDistritoAsync(idProvincia)

            Dim keyValueDistitos As List(Of KeyValuePair(Of Distrito, String)) = distritosModel.Select(Function(x) New KeyValuePair(Of Distrito, String)(x, x.Descripcion)).ToList()

            transporteViewModel.Distritos = New BindingList(Of KeyValuePair(Of Distrito, String))(keyValueDistitos)

            If (reset) Then
                transporteViewModel.DistritosSaleccionada = keyValueDistitos.First().Key
            End If

            NotifyPropertyChanged(NameOf(transporteViewModel))
        End Function

        Public Async Function CargarLocalidadAsync(transporteViewModel As TransporteViewModel, distrito As Distrito, reset As Boolean) As Task
            Dim idDistrito As Integer = If(distrito Is Nothing, -1, distrito.Id)

            Dim localidadesModel As List(Of Localidad) = Await DomicilioService.ObtenerLocalidadAsync(idDistrito)

            Dim keyValueLocalidades As List(Of KeyValuePair(Of Localidad, String)) = localidadesModel.Select(Function(x) New KeyValuePair(Of Localidad, String)(x, x.Descripcion)).ToList()

            transporteViewModel.Localidades = New BindingList(Of KeyValuePair(Of Localidad, String))(keyValueLocalidades)

            If (reset) Then
                transporteViewModel.LocalidadesSaleccionada = keyValueLocalidades.First().Key
            End If

            NotifyPropertyChanged(NameOf(transporteViewModel))
        End Function

        Friend Async Function ModificarAsync(transporteViewModel As TransporteViewModel) As Task
            Dim TransporteModel As Transporte = Await TrasporteService.Obtener(TipoBase.Remota, transporteViewModel.Id)

            TransportesModificacion = Mapper.Map(Of TransporteViewModel)(TransporteModel)

            Await CargarProvinciasAsync(TransportesModificacion, False)
            Await CargarDistritoAsync(TransportesModificacion, TransportesModificacion.ProvinciasSaleccionada, False)
            Await CargarLocalidadAsync(TransportesModificacion, TransportesModificacion.DistritosSaleccionada, False)

            NotifyPropertyChanged(NameOf(Me.TransportesModificacion))

        End Function
    End Class
End Namespace
