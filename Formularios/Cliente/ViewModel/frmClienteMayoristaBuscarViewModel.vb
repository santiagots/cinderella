Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Model
Imports Common.Data.Service

Namespace Formularios.Cliente
    Public Class frmClienteMayoristaBuscarViewModel
        Inherits Comunes.Common

        Public Property RazonSocial As String
        Public Property OrdenadoPor As String = "RazonSocial"
        Public Property DireccionOrdenamiento As OrdenadoDireccion = OrdenadoDireccion.ASC
        Public Property PaginaActual As Integer = 1
        Public Property ElementosPorPagina As Integer = 100
        Public Property Clientes As SortableBindingList(Of ClienteMayoristaItem) = New SortableBindingList(Of ClienteMayoristaItem)()
        Public ReadOnly Property SinResultados As Boolean
            Get
                Return Not Clientes.Any()
            End Get
        End Property

        Friend Async Function BuscarAsync() As Task
            Dim clientesModel As List(Of ClienteMayorista) = Await ClienteMayoristaService.BuscarAsync(TipoBase.Local,
                                                                                                    RazonSocial,
                                                                                                    Nothing,
                                                                                                    Nothing,
                                                                                                    Nothing,
                                                                                                    Nothing,
                                                                                                    Nothing,
                                                                                                    Nothing,
                                                                                                    OrdenadoPor,
                                                                                                    DireccionOrdenamiento,
                                                                                                    PaginaActual,
                                                                                                    ElementosPorPagina,
                                                                                                    Nothing)


            Dim ClienteMayoristaItemLista As List(Of ClienteMayoristaItem) = clientesModel.Select(Function(x) New ClienteMayoristaItem(x)).ToList()

            Clientes = New SortableBindingList(Of ClienteMayoristaItem)(ClienteMayoristaItemLista)
            NotifyPropertyChanged(NameOf(Me.Clientes))
        End Function

        Friend Function LimpiarAsync() As Task
            RazonSocial = String.Empty
            Return BuscarAsync()
        End Function
    End Class
End Namespace
