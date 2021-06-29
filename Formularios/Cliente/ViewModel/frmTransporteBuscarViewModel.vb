Imports System.Threading.Tasks
Imports AutoMapper
Imports Common.Core.Enum
Imports Common.Core.Model
Imports Common.Data.Service

Namespace Formularios.Cliente
    Public Class frmTransporteBuscarViewModel
        Inherits Comunes.Common

        Private ObtenerDatosDesde As TipoBase

        Public Property RazonSocial As String
        Public Property OrdenadoPor As String = "RazonSocial"
        Public Property DireccionOrdenamiento As OrdenadoDireccion = OrdenadoDireccion.ASC
        Public Property PaginaActual As Integer = 1
        Public Property ElementosPorPagina As Integer = 100
        Public Property Transportes As SortableBindingList(Of TransporteViewModel) = New SortableBindingList(Of TransporteViewModel)()
        Public ReadOnly Property SinResultados As Boolean
            Get
                Return Not Transportes.Any()
            End Get
        End Property

        Sub New(ObtenerDatosDesde As TipoBase)
            Me.ObtenerDatosDesde = ObtenerDatosDesde
        End Sub

        Public Async Function BuscarAsync() As Task
            Dim TransportesModel As List(Of Transporte) = Await TrasporteService.Buscar(ObtenerDatosDesde, RazonSocial, String.Empty, True, OrdenadoPor, DireccionOrdenamiento, PaginaActual, ElementosPorPagina, Nothing)

            Transportes = New SortableBindingList(Of TransporteViewModel)(Mapper.Map(Of List(Of TransporteViewModel))(TransportesModel))

            NotifyPropertyChanged(NameOf(Me.Transportes))
        End Function

        Friend Function LimpiarAsync() As Task
            RazonSocial = String.Empty
            Return BuscarAsync()
        End Function
    End Class
End Namespace
