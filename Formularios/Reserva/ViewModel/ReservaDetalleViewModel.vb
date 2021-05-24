Imports System.ComponentModel
Imports Ventas.Core.Enum
Imports Common.Core.Extension

Namespace Formularios.Reserva
    Public Class ReservaDetalleViewModel
        Inherits Comunes.Common

        Private _Nombre As String
        Public Property Nombre As String
            Get
                Return _Nombre
            End Get
            Set(ByVal value As String)
                _Nombre = value
                NotifyPropertyChanged(NameOf(Nombre))
            End Set
        End Property

        Private Property _Apellido As String
        Public Property Apellido As String
            Get
                Return _Apellido
            End Get
            Set(ByVal value As String)
                _Apellido = value
                NotifyPropertyChanged(NameOf(Apellido))
            End Set
        End Property

        Private Property _Telefono As String
        Public Property Telefono As String
            Get
                Return _Telefono
            End Get
            Set(ByVal value As String)
                _Telefono = value
                NotifyPropertyChanged(NameOf(Telefono))
            End Set
        End Property

        Private Property _Email As String
        Public Property Email As String
            Get
                Return _Email
            End Get
            Set(ByVal value As String)
                _Email = value
                NotifyPropertyChanged(NameOf(Email))
            End Set
        End Property

        Private Property _EnvioNovedades As Boolean
        Public Property EnvioNovedades As Boolean
            Get
                Return _EnvioNovedades
            End Get
            Set(ByVal value As Boolean)
                _EnvioNovedades = value
                NotifyPropertyChanged(NameOf(EnvioNovedades))
            End Set
        End Property

        Private Property _NoEnvioNovedades As Boolean
        Public Property NoEnvioNovedades As Boolean
            Get
                Return _NoEnvioNovedades
            End Get
            Set(ByVal value As Boolean)
                _NoEnvioNovedades = value
                NotifyPropertyChanged(NameOf(NoEnvioNovedades))
            End Set
        End Property

        Private Property _MetodoEntregaSeleccionado As KeyValuePair(Of ReservaMetodoEntrega?, String)
        Public Property MetodoEntregaSeleccionado As KeyValuePair(Of ReservaMetodoEntrega?, String)
            Get
                Return _MetodoEntregaSeleccionado
            End Get
            Set(ByVal value As KeyValuePair(Of ReservaMetodoEntrega?, String))
                _MetodoEntregaSeleccionado = value
                NotifyPropertyChanged(NameOf(MetodoEntregaSeleccionado))
                NotifyPropertyChanged(NameOf(DireccionVisible))
            End Set
        End Property

        Public Property MetodoEntrega As System.ComponentModel.BindingList(Of KeyValuePair(Of ReservaMetodoEntrega?, String))
        Private Property _Direccion As String
        Public Property Direccion As String
            Get
                Return _Direccion
            End Get
            Set(ByVal value As String)
                _Direccion = value
                NotifyPropertyChanged(NameOf(Direccion))
            End Set
        End Property

        Public ReadOnly Property DireccionVisible As Boolean
            Get
                If (MetodoEntregaSeleccionado.Key.HasValue) Then
                    Return MetodoEntregaSeleccionado.Key.Value = ReservaMetodoEntrega.Envió_A_Domicilio
                Else
                    Return False
                End If

            End Get
        End Property
        Public Property Observaciones As String
        Public Property FechaEstimadaRetiro As Date

        Public Sub New()
            CargarMetodoEntrega()
            FechaEstimadaRetiro = DateTime.Now.AddDays(1)
        End Sub

        Private Sub CargarMetodoEntrega()
            Dim metodoEntrega As List(Of KeyValuePair(Of ReservaMetodoEntrega?, String)) = [Enum](Of ReservaMetodoEntrega).ToKeyValuePairList()
            metodoEntrega.Insert(0, New KeyValuePair(Of ReservaMetodoEntrega?, String)(Nothing, "Seleccione una opción"))
            MetodoEntregaSeleccionado = metodoEntrega.First()
            _MetodoEntrega = New BindingList(Of KeyValuePair(Of ReservaMetodoEntrega?, String))(metodoEntrega)
        End Sub
    End Class
End Namespace