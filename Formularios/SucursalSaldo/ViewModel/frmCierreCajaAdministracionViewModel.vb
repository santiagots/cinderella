Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Common.Core.Extension
Imports Ventas.Core.Model.VentaAggregate
Imports Ventas.Core.Enum
Imports AutoMapper

Namespace Formularios.SucursalSaldo

    Public Class frmCierreCajaAdministracionViewModel
        Inherits Comunes.Common

        Private IdSucursal As Integer

        Public Property FechaDesde As DateTime
        Public Property FechaHasta As DateTime
        Public ReadOnly Property TotalDiferencia As Decimal
            Get
                Return CierresCajas.Sum(Function(x) x.Diferencia)
            End Get
        End Property
        Public Property SituacionSeleccionada As KeyValuePair(Of CierreCajaSituacion?, String)
        Public ReadOnly Property Situacion As BindingList(Of KeyValuePair(Of CierreCajaSituacion?, String))
            Get
                Dim situacionCierreCaja As BindingList(Of KeyValuePair(Of CierreCajaSituacion?, String)) = New BindingList(Of KeyValuePair(Of CierreCajaSituacion?, String))
                situacionCierreCaja.Add(New KeyValuePair(Of CierreCajaSituacion?, String)(Nothing, "Todos"))
                situacionCierreCaja.Add(New KeyValuePair(Of CierreCajaSituacion?, String)(CierreCajaSituacion.FaltanteDinero, "Faltante Dinero"))
                situacionCierreCaja.Add(New KeyValuePair(Of CierreCajaSituacion?, String)(CierreCajaSituacion.SobranteDinero, "Sobrante Dinero"))
                Return situacionCierreCaja
            End Get
        End Property

        Public Property CierresCajas As BindingList(Of CierreCajaItem)
        Public ReadOnly Property SinResultados As Boolean
            Get
                Return Not CierresCajas.Any()
            End Get
        End Property

        Sub New(idSucursal As Integer)
            Me.IdSucursal = idSucursal
            Inicializar()
        End Sub

        Public Async Function BuscarAsync() As Task
            Dim cierresCajas As List(Of CierreCaja) = Await Task.Run(Function() Servicio.BuscarCierreCaja(IdSucursal, FechaDesde, FechaHasta, SituacionSeleccionada.Key))
            Me.CierresCajas = New BindingList(Of CierreCajaItem)(Mapper.Map(Of List(Of CierreCajaItem))(cierresCajas))
            NotifyPropertyChanged(NameOf(Me.CierresCajas))
        End Function

        Friend Async Function RestablecerAsync() As Task
            Inicializar()
            Await BuscarAsync()
        End Function

        Private Sub Inicializar()
            FechaHasta = DateTime.Now
            FechaDesde = FechaHasta.AddDays(-30)
            CierresCajas = New BindingList(Of CierreCajaItem)()
            SituacionSeleccionada = New KeyValuePair(Of CierreCajaSituacion?, String)(Nothing, "Todos")
        End Sub

    End Class

End Namespace
