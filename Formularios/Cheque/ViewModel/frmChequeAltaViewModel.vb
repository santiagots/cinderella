Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Common.Core.Model
Imports Common.Data.Service
Imports Model = Ventas.Core.Model.ChequeAggregate

Namespace Formularios.Cheque
    Public Class frmChequeAltaViewModel
        Inherits Comunes.Common

        Private idSucursal As Integer

        Public Property ChequeDetalle As ChequeDetalleViewModel

        Public Sub New(idSucursal As Integer)
            Me.idSucursal = idSucursal
            ChequeDetalle = New ChequeDetalleViewModel()
        End Sub

        Friend Async Function CargarDatosAsync() As Task
            Dim tareas As List(Of Task) = New List(Of Task)()
            tareas.Add(CargarBancosAsync())
            tareas.Add(CargarUltimoNumeroDeOrdenAsync())
            Await Task.WhenAll(tareas)
        End Function

        Public Async Function CargarBancosAsync() As Task
            Dim Bancos As List(Of Banco) = Await BancoService.ObtenerAsync(TipoBase.Local)
            Bancos.ForEach(Sub(x) ChequeDetalle.BancosEmisores.Add(New KeyValuePair(Of Integer?, String)(x.Id, x.Nombre)))
            ChequeDetalle.BancosEmisores.Insert(0, New KeyValuePair(Of Integer?, String)(Nothing, "Selecciones una opción"))
            NotifyPropertyChanged(NameOf(Me.ChequeDetalle))
        End Function

        Public Async Function CargarUltimoNumeroDeOrdenAsync() As Task
            Dim ultimoNumeroDeOrden As Integer = Await Task.Run(Function() Servicio.ObtenerUltimoNumeroDeOrden(idSucursal))
            ChequeDetalle.NumeroOrden = ultimoNumeroDeOrden + 1
        End Function

        Friend Async Function Alta() As Task
            Dim cheque As Model.Cheque = New Model.Cheque(idSucursal,
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

            Await Task.Run(Function() Servicio.AltaCheque(cheque))
        End Function
    End Class
End Namespace
