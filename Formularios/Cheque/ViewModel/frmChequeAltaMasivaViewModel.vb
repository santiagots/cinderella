Imports System.ComponentModel
Imports System.Threading.Tasks
Imports AutoMapper
Imports Common.Core
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Common.Core.Model
Imports Common.Data.Service
Imports Model = Ventas.Core.Model.ChequeAggregate

Namespace Formularios.Cheque
    Public Class frmChequeAltaMasivaViewModel
        Inherits Comunes.Common

        Private IdSucursal As Integer
        Private _ChequesModel As List(Of Model.Cheque)

        ReadOnly Property ChequesModel() As List(Of Model.Cheque)
            Get
                Return _ChequesModel
            End Get
        End Property

        Property TotalAPagar As Decimal
        ReadOnly Property Total As Decimal
            Get
                Return Cheques.Sum(Function(x) x.Monto)
            End Get
        End Property
        Public Property Cheques As BindingList(Of ChequeAdministracionItemViewModel)
        Public Property ChequeDetalle As ChequeDetalleViewModel

        ReadOnly Property HabilitarFinalizar As Boolean
            Get
                Return TotalAPagar = Total
            End Get
        End Property

        ReadOnly Property HabilitarAgregar As Boolean
            Get
                Return TotalAPagar <> Total
            End Get
        End Property

        Public Sub New(idSucursal As Integer, totalAPagar As Decimal, idClienteMayorista As Integer)
            Me.IdSucursal = idSucursal
            _ChequesModel = New List(Of Model.Cheque)()
            Cheques = New BindingList(Of ChequeAdministracionItemViewModel)()
            ChequeDetalle = New ChequeDetalleViewModel()
            ChequeDetalle.Monto = totalAPagar
            ChequeDetalle.IdCliente = idClienteMayorista
            Me.TotalAPagar = totalAPagar
        End Sub

        Friend Async Function CargarDatosAsync() As Task
            Dim tareas As List(Of Task) = New List(Of Task)()
            tareas.Add(CargarBancosAsync())
            tareas.Add(CargarUltimoNumeroDeOrdenAsync())
            tareas.Add(CargarClienteMayoristaAsync())
            Await Task.WhenAll(tareas)
        End Function

        Public Async Function CargarBancosAsync() As Task
            Dim Bancos As List(Of Banco) = Await Task.Run(Function() Comunes.Servicio.ObtenerBancos())
            Bancos.ForEach(Sub(x) ChequeDetalle.BancosEmisores.Add(New KeyValuePair(Of Integer?, String)(x.Id, x.Nombre)))
            ChequeDetalle.BancosEmisores.Insert(0, New KeyValuePair(Of Integer?, String)(Nothing, "Selecciones una opción"))
            NotifyPropertyChanged(NameOf(Me.ChequeDetalle))
        End Function

        Friend Sub AgregaNormal()
            Agrega()
            ChequeDetalle.NumeroCheque = 0
            ChequeDetalle.NumeroOrden += 1
            ChequeDetalle.IdCliente = 0
            ChequeDetalle.ClienteNombre = String.Empty
            ChequeDetalle.IdLibrador = 0
            ChequeDetalle.LibradorNombre = String.Empty
            ChequeDetalle.FechaDesposito = DateTime.Now
            ChequeDetalle.FechaVencimiento = ChequeDetalle.FechaDesposito.AddDays(30)
            ChequeDetalle.BancoEmisorSeleccionado = New KeyValuePair(Of Integer?, String)(Nothing, "Selecciones una opción")

            NotifyPropertyChanged(NameOf(Me.ChequeDetalle))
        End Sub

        Friend Sub AgregaConsecutivo()
            Agrega()
            ChequeDetalle.NumeroCheque += 1
            ChequeDetalle.NumeroOrden += 1
            ChequeDetalle.FechaDesposito = DateTime.Now
            ChequeDetalle.FechaVencimiento = ChequeDetalle.FechaDesposito.AddDays(30)

            NotifyPropertyChanged(NameOf(Me.ChequeDetalle))
        End Sub

        Friend Sub Quitar(numeroCheque As Integer)
            Dim chequeModelEliminar As Model.Cheque = _ChequesModel.FirstOrDefault(Function(x) x.NumeroCheque = numeroCheque)
            If (chequeModelEliminar Is Nothing) Then
                Throw New NegocioException("Error al quitar el Cheque. El cheque que se está intentando eliminar no se ha encontrado.")
            End If

            _ChequesModel.Remove(chequeModelEliminar)
            Cheques.Remove(Cheques.FirstOrDefault(Function(x) x.NumeroCheque = numeroCheque))

            ChequeDetalle.Monto = obtenerMontoRestante()

            NotifyPropertyChanged(NameOf(Me.ChequeDetalle))
            NotifyPropertyChanged(NameOf(Me.Cheques))
        End Sub

        Private Sub Agrega()
            If (ChequeDetalle.Monto + Total > TotalAPagar) Then
                Throw New NegocioException("Error al generar el Cheque. El total ingresado supera el monto total a pagar.")
            End If

            Dim cheque As Model.Cheque = New Model.Cheque(IdSucursal,
                                                          ChequeDetalle.NumeroOrden,
                                                          ChequeDetalle.NumeroCheque,
                                                          ChequeDetalle.MarcaFacturado,
                                                          ChequeDetalle.Monto,
                                                          ChequeDetalle.BancoEmisorSeleccionado.Key,
                                                          ChequeDetalle.IdCliente,
                                                          ChequeDetalle.ClienteNombre,
                                                          ChequeDetalle.IdLibrador,
                                                          ChequeDetalle.LibradorNombre,
                                                          ChequeDetalle.FechaIngreso,
                                                          ChequeDetalle.FechaDesposito,
                                                          ChequeDetalle.FechaVencimiento,
                                                          Nothing,
                                                          "",
                                                          EstadoCheque.Ingresado,
                                                          DestinoSalidaCheque.SinSalida)
            _ChequesModel.Add(cheque)

            Cheques.Add(Mapper.Map(Of ChequeAdministracionItemViewModel)(ChequeDetalle))

            ChequeDetalle.Monto = obtenerMontoRestante()
            NotifyPropertyChanged(NameOf(Me.Cheques))
        End Sub

        Private Function obtenerMontoRestante() As Double
            Return TotalAPagar - Total
        End Function

        Private Async Function CargarUltimoNumeroDeOrdenAsync() As Task
            Dim ultimoNumeroDeOrden As Integer = Await Task.Run(Function() Servicio.ObtenerUltimoNumeroDeOrden(IdSucursal))
            ChequeDetalle.NumeroOrden = ultimoNumeroDeOrden + 1
        End Function

        Private Async Function CargarClienteMayoristaAsync() As Task
            Dim clienteMayorista As Common.Core.Model.ClienteMayorista = Await ClienteMayoristaService.ObtenerAsync(TipoBase.Local, ChequeDetalle.IdCliente)
            ChequeDetalle.ClienteNombre = clienteMayorista.RazonSocial
        End Function
    End Class
End Namespace
