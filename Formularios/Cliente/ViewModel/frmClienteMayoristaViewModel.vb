Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Model
Imports Common.Data.Service
Imports Common.Core.Extension
Imports Ventas.Data.Service
Imports AutoMapper
Imports Common.Core.Exceptions
Imports Common.Core.Helper

Namespace Formularios.Cliente
    Public Class frmClienteMayoristaViewModel
        Inherits Comunes.Common

        Private ListaPrecio As BindingList(Of KeyValuePair(Of ListaPrecio, String))
        Private Provincias As BindingList(Of KeyValuePair(Of Provincia, String))

        Public Property Habilitados As BindingList(Of KeyValuePair(Of Boolean?, String)) = New BindingList(Of KeyValuePair(Of Boolean?, String))()
        Public Property CondicionesIVA As BindingList(Of KeyValuePair(Of CondicionIVA?, String)) = New BindingList(Of KeyValuePair(Of CondicionIVA?, String))()
        Public Property Corredores As BindingList(Of KeyValuePair(Of Integer?, String)) = New BindingList(Of KeyValuePair(Of Integer?, String))()
        Public Property Empresas As BindingList(Of KeyValuePair(Of Integer?, String)) = New BindingList(Of KeyValuePair(Of Integer?, String))()
        Public Property ListasPrecios As BindingList(Of KeyValuePair(Of ListaPrecio, String)) = New BindingList(Of KeyValuePair(Of ListaPrecio, String))()

        Public Property FiltroRazonSocial As String
        Public Property FiltroCuit As String
        Public Property FiltroEmpresaSaleccionada As KeyValuePair(Of Integer?, String) = New KeyValuePair(Of Integer?, String)(Nothing, "Seleccione una opción")
        Public Property FiltroHabilitadoSaleccionada As KeyValuePair(Of Boolean?, String) = New KeyValuePair(Of Boolean?, String)(Nothing, "Todos")
        Public Property FiltroCorredorSaleccionada As KeyValuePair(Of Integer?, String) = New KeyValuePair(Of Integer?, String)(Nothing, "Seleccione una opción")
        Public Property FiltroCondicionesIVASaleccionada As KeyValuePair(Of CondicionIVA?, String) = New KeyValuePair(Of CondicionIVA?, String)(Nothing, "Todos")
        Public Property FiltroListaPreciosSaleccionada As KeyValuePair(Of ListaPrecio, String) = New KeyValuePair(Of ListaPrecio, String)(Nothing, "Todos")
        Public Property FiltroClientes As BindingList(Of ClienteMayoristaItem) = New BindingList(Of ClienteMayoristaItem)()
        Public Property AltaClientes As ClienteMayoristaDetalleViewModel = New ClienteMayoristaDetalleViewModel()
        Public Property ModificacionClientes As ClienteMayoristaDetalleViewModel = New ClienteMayoristaDetalleViewModel()
        Public Property FiltroTotalSaldo As Decimal
        Public ReadOnly Property SinResultados As Boolean
            Get
                Return Not FiltroClientes.Any()
            End Get
        End Property
        Public Property OrdenadoPor As String = "Id"
        Public Property DireccionOrdenamiento As OrdenadoDireccion
        Public Property PaginaActual As Integer = 1
        Public Property ElementosPorPagina As Integer
        Public Property TotalElementos As Integer

        Dim _Visible As Boolean = True
        Public Property Visible As Boolean
            Set(value As Boolean)
                _Visible = value
                NotifyPropertyChanged(NameOf(Me.Visible))
            End Set
            Get
                Return _Visible
            End Get
        End Property

        Sub New()
            CargarEmpresas()
            CargarCorredores()
            CargarCondicionesIva()
            CargarHabilitado()
        End Sub

        Friend Async Function BuscarAsync() As Task
            Dim clientes As List(Of ClienteMayorista) = Await ClienteMayoristaService.BuscarAsync(TipoBase.Remota,
                                                                                                    FiltroRazonSocial,
                                                                                                    FiltroCuit,
                                                                                                    FiltroCondicionesIVASaleccionada.Key,
                                                                                                    FiltroListaPreciosSaleccionada.Key?.Id,
                                                                                                    FiltroCorredorSaleccionada.Key,
                                                                                                    FiltroEmpresaSaleccionada.Key,
                                                                                                    FiltroHabilitadoSaleccionada.Key,
                                                                                                    OrdenadoPor,
                                                                                                    DireccionOrdenamiento,
                                                                                                    PaginaActual,
                                                                                                    ElementosPorPagina,
                                                                                                    TotalElementos)

            Dim ClienteMayoristaItemLista As List(Of ClienteMayoristaItem) = New List(Of ClienteMayoristaItem)

            For Each ciente As ClienteMayorista In clientes
                Dim montoTotalNotaPedidoPendientes As Decimal = Await Task.Run(Function() NotaPedidoService.ObtenerMontoTotalClienteMayorista(TipoBase.Remota, ciente.Id))
                ClienteMayoristaItemLista.Add(New ClienteMayoristaItem(ciente, montoTotalNotaPedidoPendientes, 0))
            Next

            FiltroClientes = New BindingList(Of ClienteMayoristaItem)(ClienteMayoristaItemLista)
            NotifyPropertyChanged(NameOf(Me.FiltroClientes))
        End Function

        Friend Async Function GuardarAsync() As Task
            ValidarRequeridos(AltaClientes)
            Dim clientes As ClienteMayorista = Mapper.Map(Of ClienteMayorista)(AltaClientes)
            Await ClienteMayoristaService.GuardarAsync(TipoBase.Remota, clientes)
        End Function

        Friend Async Function ActualizarAsync() As Task
            ValidarRequeridos(ModificacionClientes)
            Dim clientes As ClienteMayorista = Mapper.Map(Of ClienteMayorista)(ModificacionClientes)
            Await ClienteMayoristaService.ActualizarAsync(TipoBase.Remota, clientes)
        End Function

        Private Sub CargarHabilitado()
            Habilitados.Add(New KeyValuePair(Of Boolean?, String)(Nothing, "Todos"))
            Habilitados.Add(New KeyValuePair(Of Boolean?, String)(True, "Si"))
            Habilitados.Add(New KeyValuePair(Of Boolean?, String)(False, "No"))
        End Sub

        Private Sub CargarCondicionesIva()
            Dim keyValueCondicionesIVA As List(Of KeyValuePair(Of CondicionIVA?, String)) = [Enum](Of CondicionIVA).ToKeyValuePairList()
            keyValueCondicionesIVA.Insert(0, New KeyValuePair(Of CondicionIVA?, String)(Nothing, "Todos"))

            CondicionesIVA = New BindingList(Of KeyValuePair(Of CondicionIVA?, String))(keyValueCondicionesIVA)

            keyValueCondicionesIVA = [Enum](Of CondicionIVA).ToKeyValuePairList()
            keyValueCondicionesIVA.Insert(0, New KeyValuePair(Of CondicionIVA?, String)(Nothing, "Seleccione una opción"))

            AltaClientes.CondicionesIVA = New BindingList(Of KeyValuePair(Of CondicionIVA?, String))(keyValueCondicionesIVA)
        End Sub

        Private Sub CargarCorredores()
            Corredores.Add(New KeyValuePair(Of Integer?, String)(Nothing, "Seleccione una opción"))
        End Sub

        Private Sub CargarEmpresas()
            Empresas.Add(New KeyValuePair(Of Integer?, String)(Nothing, "Seleccione una opción"))
        End Sub

        Public Async Function CargarListaPreciosAsync() As Task
            Dim listaPrecioModel As List(Of ListaPrecio) = Await ListaPrecioService.ObtenerMayoristaAsync()

            Dim keyValueListaPrecio As List(Of KeyValuePair(Of ListaPrecio, String)) = listaPrecioModel.Select(Function(x) New KeyValuePair(Of ListaPrecio, String)(x, x.Nombre)).ToList()
            keyValueListaPrecio.Insert(0, New KeyValuePair(Of ListaPrecio, String)(Nothing, "Todos"))

            ListasPrecios = New BindingList(Of KeyValuePair(Of ListaPrecio, String))(keyValueListaPrecio)

            keyValueListaPrecio = listaPrecioModel.Select(Function(x) New KeyValuePair(Of ListaPrecio, String)(x, x.Nombre)).ToList()
            keyValueListaPrecio.Insert(0, New KeyValuePair(Of ListaPrecio, String)(Nothing, "Seleccione una opción"))

            AltaClientes.ListasPrecios = New BindingList(Of KeyValuePair(Of ListaPrecio, String))(keyValueListaPrecio)
        End Function

        Public Async Function CargarProvinciasAsync() As Task
            Dim provinciasModel As List(Of Provincia) = Await DomicilioService.ObtenerProvinciaAsync()

            Dim keyValueProvincias As List(Of KeyValuePair(Of Provincia, String)) = provinciasModel.Select(Function(x) New KeyValuePair(Of Provincia, String)(x, x.Descripcion)).ToList()

            Provincias = New BindingList(Of KeyValuePair(Of Provincia, String))(keyValueProvincias)

            AltaClientes.EntregaProvincias = Provincias
            AltaClientes.FacturacionProvincias = Provincias

            AltaClientes.EntregaProvinciasSaleccionada = keyValueProvincias.FirstOrDefault().Key
            AltaClientes.FacturacionProvinciasSaleccionada = keyValueProvincias.FirstOrDefault().Key
        End Function

        Public Async Function CargarDistritoAsync(proviencia As Provincia) As Task(Of BindingList(Of KeyValuePair(Of Distrito, String)))
            Dim idProvincia As Integer = If(proviencia Is Nothing, -1, proviencia.Id)

            Dim distritosModel As List(Of Distrito) = Await DomicilioService.ObtenerDistritoAsync(idProvincia)

            Dim keyValueDistitos As List(Of KeyValuePair(Of Distrito, String)) = distritosModel.Select(Function(x) New KeyValuePair(Of Distrito, String)(x, x.Descripcion)).ToList()

            Return New BindingList(Of KeyValuePair(Of Distrito, String))(keyValueDistitos)
        End Function

        Public Async Function CargarLocalidadAsync(distrito As Distrito) As Task(Of BindingList(Of KeyValuePair(Of Localidad, String)))
            Dim idDistrito As Integer = If(distrito Is Nothing, -1, distrito.Id)

            Dim localidadesModel As List(Of Localidad) = Await DomicilioService.ObtenerLocalidadAsync(idDistrito)

            Dim keyValueLocalidades As List(Of KeyValuePair(Of Localidad, String)) = localidadesModel.Select(Function(x) New KeyValuePair(Of Localidad, String)(x, x.Descripcion)).ToList()

            Return New BindingList(Of KeyValuePair(Of Localidad, String))(keyValueLocalidades)
        End Function

        Friend Async Function CargarClienteAsync(clienteMayorista As ClienteMayorista) As Task
            ModificacionClientes = Mapper.Map(Of ClienteMayoristaDetalleViewModel)(clienteMayorista)

            ModificacionClientes.CondicionesIVA = New BindingList(Of KeyValuePair(Of CondicionIVA?, String))(AltaClientes.CondicionesIVA)

            ModificacionClientes.ListasPrecios = New BindingList(Of KeyValuePair(Of ListaPrecio, String))(AltaClientes.ListasPrecios)

            ModificacionClientes.EntregaProvincias = Provincias
            ModificacionClientes.FacturacionProvincias = Provincias

            ModificacionClientes.FacturacionDistritos = Await CargarDistritoAsync(clienteMayorista.DomicilioFacturacion?.Provincia)
            ModificacionClientes.FacturacionLocalidades = Await CargarLocalidadAsync(clienteMayorista.DomicilioFacturacion?.Distrito)

            ModificacionClientes.EntregaDistritos = Await CargarDistritoAsync(clienteMayorista.DomicilioEntrega?.Provincia)
            ModificacionClientes.EntregaLocalidades = Await CargarLocalidadAsync(clienteMayorista.DomicilioEntrega?.Distrito)
        End Function

        Private Sub ValidarRequeridos(clienteMayoristaDetalleViewModel As ClienteMayoristaDetalleViewModel)

            Dim hayError As Boolean = False

            hayError = String.IsNullOrEmpty(clienteMayoristaDetalleViewModel.RazonSocial) OrElse hayError
            hayError = String.IsNullOrEmpty(clienteMayoristaDetalleViewModel.Nombre) OrElse hayError
            hayError = String.IsNullOrEmpty(clienteMayoristaDetalleViewModel.Cuit) OrElse hayError
            hayError = Not clienteMayoristaDetalleViewModel.CondicionesIVASaleccionada.Key.HasValue OrElse hayError
            hayError = clienteMayoristaDetalleViewModel.ListaPreciosSaleccionada.Key Is Nothing OrElse hayError
            hayError = String.IsNullOrEmpty(clienteMayoristaDetalleViewModel.FacturacionDireccion) OrElse hayError
            hayError = clienteMayoristaDetalleViewModel.FacturacionProvinciasSaleccionada Is Nothing OrElse hayError
            hayError = clienteMayoristaDetalleViewModel.FacturacionDistritosSaleccionada Is Nothing OrElse hayError
            hayError = clienteMayoristaDetalleViewModel.EntregaLocalidadesSaleccionada Is Nothing OrElse hayError
            hayError = String.IsNullOrEmpty(clienteMayoristaDetalleViewModel.FacturacionCodigoPostal) OrElse hayError

            If (hayError) Then
                Throw New NegocioException(My.Resources.ErrorCamposRequeridos)
            End If

            If Not Cuit.EsValido(clienteMayoristaDetalleViewModel.Cuit) Then
                Throw New NegocioException(My.Resources.ErrorCuitInvalido)
            End If
        End Sub
    End Class
End Namespace
