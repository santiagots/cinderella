Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Model
Imports Common.Data.Service
Imports Common.Core.Extension
Imports Ventas.Data.Service
Imports AutoMapper

Namespace Formularios.Cliente
    Public Class frmClienteMayoristaViewModel
        Inherits Comunes.Common

        Private Provincias As BindingList(Of KeyValuePair(Of Provincia, String))

        Public Property Habilitados As List(Of KeyValuePair(Of Boolean?, String)) = New List(Of KeyValuePair(Of Boolean?, String))()
        Public Property FiltroCondicionesIVA As List(Of KeyValuePair(Of CondicionIVA?, String)) = New List(Of KeyValuePair(Of CondicionIVA?, String))()
        Public Property CondicionesIVA As List(Of KeyValuePair(Of CondicionIVA?, String)) = New List(Of KeyValuePair(Of CondicionIVA?, String))()
        Public Property Corredores As List(Of KeyValuePair(Of Integer?, String)) = New List(Of KeyValuePair(Of Integer?, String))()
        Public Property Empresas As List(Of KeyValuePair(Of Integer?, String)) = New List(Of KeyValuePair(Of Integer?, String))()
        Public Property FiltroListasPrecios As List(Of KeyValuePair(Of Integer?, String)) = New List(Of KeyValuePair(Of Integer?, String))()
        Public Property ListasPrecios As List(Of KeyValuePair(Of Integer?, String)) = New List(Of KeyValuePair(Of Integer?, String))()

        Public Property FiltroRazonSocial As String
        Public Property FiltroCuit As String
        Public Property FiltroEmpresaSaleccionada As KeyValuePair(Of Integer?, String) = New KeyValuePair(Of Integer?, String)(Nothing, "Seleccione una opción")
        Public Property FiltroHabilitadoSaleccionada As KeyValuePair(Of Boolean?, String) = New KeyValuePair(Of Boolean?, String)(Nothing, "Todos")
        Public Property FiltroCorredorSaleccionada As KeyValuePair(Of Integer?, String) = New KeyValuePair(Of Integer?, String)(Nothing, "Seleccione una opción")
        Public Property FiltroCondicionesIVASaleccionada As KeyValuePair(Of CondicionIVA?, String) = New KeyValuePair(Of CondicionIVA?, String)(Nothing, "Todos")
        Public Property FiltroListaPreciosSaleccionada As KeyValuePair(Of Integer?, String) = New KeyValuePair(Of Integer?, String)(Nothing, "Todos")
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
        Public Property DireccionOrdenamiento As DireccionOrdenamiento
        Public Property PaginaActual As Integer = 1
        Public Property ElementosPorPagina As Integer
        Public Property TotalElementos As Integer

        Sub New()
            CargarEmpresas()
            CargarCorredores()
            CargarPrecios()
            CargarCondicionesIva()
            CargarHabilitado()
        End Sub

        Friend Async Function BuscarAsync() As Task
            Dim clientes As List(Of ClienteMayorista) = Await ClienteMayoristaService.BuscarAsync(TipoBase.Remota,
                                                                                                    FiltroRazonSocial,
                                                                                                    FiltroCuit,
                                                                                                    FiltroCondicionesIVASaleccionada.Key,
                                                                                                    FiltroListaPreciosSaleccionada.Key,
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
            Dim clientes As ClienteMayorista = Mapper.Map(Of ClienteMayorista)(AltaClientes)
            Await ClienteMayoristaService.GuardarAsync(TipoBase.Remota, clientes)
        End Function

        Friend Async Function ActualizarAsync() As Task
            Dim clientes As ClienteMayorista = Mapper.Map(Of ClienteMayorista)(ModificacionClientes)
            Await ClienteMayoristaService.ActualizarAsync(TipoBase.Remota, clientes)
        End Function

        Private Sub CargarHabilitado()
            Habilitados.Add(New KeyValuePair(Of Boolean?, String)(Nothing, "Todos"))
            Habilitados.Add(New KeyValuePair(Of Boolean?, String)(True, "Si"))
            Habilitados.Add(New KeyValuePair(Of Boolean?, String)(False, "No"))
        End Sub

        Private Sub CargarCondicionesIva()
            FiltroCondicionesIVA.AddRange([Enum](Of CondicionIVA).ToKeyValuePairList().Where(Function(x) x.Key <> CondicionIVA.Consumidor_Final))
            FiltroCondicionesIVA.Insert(0, New KeyValuePair(Of CondicionIVA?, String)(Nothing, "Todos"))

            CondicionesIVA.AddRange([Enum](Of CondicionIVA).ToKeyValuePairList().Where(Function(x) x.Key <> CondicionIVA.Consumidor_Final))
            CondicionesIVA.Insert(0, New KeyValuePair(Of CondicionIVA?, String)(Nothing, "Seleccione una opción"))
        End Sub

        Private Sub CargarPrecios()
            FiltroListasPrecios.Add(New KeyValuePair(Of Integer?, String)(Nothing, "Todos"))
            FiltroListasPrecios.Add(New KeyValuePair(Of Integer?, String)(5, "Mayorista"))
            FiltroListasPrecios.Add(New KeyValuePair(Of Integer?, String)(6, "Alternativo"))

            ListasPrecios.Add(New KeyValuePair(Of Integer?, String)(Nothing, "Seleccione una opción"))
            ListasPrecios.Add(New KeyValuePair(Of Integer?, String)(5, "Mayorista"))
            ListasPrecios.Add(New KeyValuePair(Of Integer?, String)(6, "Alternativo"))
        End Sub

        Private Sub CargarCorredores()
            Corredores.Add(New KeyValuePair(Of Integer?, String)(Nothing, "Seleccione una opción"))
        End Sub

        Private Sub CargarEmpresas()
            Empresas.Add(New KeyValuePair(Of Integer?, String)(Nothing, "Seleccione una opción"))
        End Sub

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

        Friend Function EliminarAsync(clienteMayoristaItem As ClienteMayoristaItem) As Task
            Throw New NotImplementedException()
        End Function

        Friend Async Function CargarClienteAsync(clienteMayorista As ClienteMayorista) As Task

            ModificacionClientes = Mapper.Map(Of ClienteMayoristaDetalleViewModel)(clienteMayorista)

            Await CargarProvinciasAsync()

            ModificacionClientes.EntregaProvincias = Provincias
            ModificacionClientes.FacturacionProvincias = Provincias

            ModificacionClientes.FacturacionDistritos = Await CargarDistritoAsync(clienteMayorista.DomicilioFacturacion?.Provincia)
            ModificacionClientes.FacturacionLocalidades = Await CargarLocalidadAsync(clienteMayorista.DomicilioFacturacion?.Distrito)

            ModificacionClientes.EntregaDistritos = Await CargarDistritoAsync(clienteMayorista.DomicilioEntrega?.Provincia)
            ModificacionClientes.EntregaLocalidades = Await CargarLocalidadAsync(clienteMayorista.DomicilioEntrega?.Distrito)
        End Function
    End Class
End Namespace
