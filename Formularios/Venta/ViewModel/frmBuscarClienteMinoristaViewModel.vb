Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Ventas.Core.Model.BaseAgreggate

Namespace Formularios.Venta
    Public Class frmBuscarClienteMinoristaViewModel
        Inherits SistemaCinderella.VistaModelo.Common

        Public Property Nombre As String
        Public Property Apellido As String
        Public ReadOnly Property SinResultados() As Boolean
            Get
                Return Not Clientes.Any
            End Get
        End Property

        Public Property Clientes As BindingList(Of ClienteMinorista)

        Sub New()
            Clientes = New BindingList(Of ClienteMinorista)()
        End Sub

        Public Async Function BuscarAsync() As Task
            Dim Clientes As List(Of ClienteMinorista) = Await Task.Run(Function() Servicio.BuscarClienteMinorista(Nombre, Apellido))
            Me.Clientes = New BindingList(Of ClienteMinorista)(Clientes)

            NotifyPropertyChanged(NameOf(Me.Clientes))
        End Function
    End Class
End Namespace