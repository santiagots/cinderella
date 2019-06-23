Imports System.ComponentModel
Imports System.Configuration
Imports System.IO
Imports System.Threading.Tasks
Imports AutoMapper
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Common.Core.Extension
Imports Common.Core.Model
Imports NPOI.SS.UserModel
Imports NPOI.XSSF.UserModel
Imports Model = Ventas.Core.Model.ChequeAggregate

Namespace Formularios.Cheque
    Public Class frmChequeAdministracionViewModel
        Inherits SistemaCinderella.VistaModelo.Common

        Private ReadOnly IdSucursal As Integer
        Private _FechaIngresoFiltro As Boolean
        Private _FechaDepostioFiltro As Boolean
        Private _FechaVencimientoFiltro As Boolean
        Private _FechaSalidaFiltro As Boolean
        Public Property FacturadoSi As Boolean
        Public Property FacturadoNo As Boolean
        Public Property Cliente As String
        Public Property Librado As String
        Public Property FechaIngresoDesde As DateTime
        Public Property FechaIngresoHasta As DateTime
        Public Property FechaIngresoFiltro As Boolean
            Get
                Return _FechaIngresoFiltro
            End Get
            Set
                _FechaIngresoFiltro = Value
                NotifyPropertyChanged(NameOf(Me.FechaIngresoFiltro))
            End Set
        End Property

        Public Property FechaDepostioDesde As DateTime
        Public Property FechaDepostioHasta As DateTime
        Public Property FechaDepostioFiltro As Boolean
            Get
                Return _FechaDepostioFiltro
            End Get
            Set
                _FechaDepostioFiltro = Value
                NotifyPropertyChanged(NameOf(Me.FechaDepostioFiltro))
            End Set
        End Property

        Public Property FechaVencimientoDesde As DateTime
        Public Property FechaVencimientoHasta As DateTime
        Public Property FechaVencimientoFiltro As Boolean
            Get
                Return _FechaVencimientoFiltro
            End Get
            Set
                _FechaVencimientoFiltro = Value
                NotifyPropertyChanged(NameOf(Me.FechaVencimientoFiltro))
            End Set
        End Property
        Public Property FechaSalidaDesde As DateTime
        Public Property FechaSalidaHasta As DateTime
        Public Property FechaSalidaFiltro As Boolean
            Get
                Return _FechaSalidaFiltro
            End Get
            Set
                _FechaSalidaFiltro = Value
                NotifyPropertyChanged(NameOf(Me.FechaSalidaFiltro))
            End Set
        End Property
        Public ReadOnly Property Estados As BindingList(Of KeyValuePair(Of EstadoCheque?, String))
            Get
                Return New BindingList(Of KeyValuePair(Of EstadoCheque?, String))([Enum](Of EstadoCheque).ToKeyValuePairList())
            End Get
        End Property
        Public ReadOnly Property DestinosSalidas As BindingList(Of KeyValuePair(Of DestinoSalidaCheque?, String))
            Get
                Return New BindingList(Of KeyValuePair(Of DestinoSalidaCheque?, String))([Enum](Of DestinoSalidaCheque).ToKeyValuePairList())
            End Get
        End Property
        Public Property DestinoSalidaSeleccionado As KeyValuePair(Of DestinoSalidaCheque?, String)
        Public Property DetalleSalida As String
        Public Property ImporteDesde As Decimal?
        Public Property ImporteHasta As Decimal?
        Public Property NumeroCheque As Integer?
        Public Property BancoEmisorSeleccionado As KeyValuePair(Of Integer?, String)
        Public Property BancosEmisores As BindingList(Of KeyValuePair(Of Integer?, String))
        Public Property TotalChequeCartera As Decimal
        Public Property TotalChequePantalla As Decimal
        Public ReadOnly Property SinResultados As Boolean
            Get
                Return Not Cheques.Any()
            End Get
        End Property
        Public Property Cheques As BindingList(Of ChequeAdministracionItemViewModel)
        Public Property ChequeDetalle As ChequeDetalleViewModel
        Public Property DestinoSalidaDetalleSeleccionado As KeyValuePair(Of DestinoSalidaCheque?, String)
        Public Property DestinoSalidaComentarioDetalle As String

        Sub New(idSucursal As Integer)
            Me.IdSucursal = idSucursal
            FacturadoNo = True
            FacturadoSi = True
            Cheques = New BindingList(Of ChequeAdministracionItemViewModel)()
            BancosEmisores = New BindingList(Of KeyValuePair(Of Integer?, String))
            BancoEmisorSeleccionado = New KeyValuePair(Of Integer?, String)(Nothing, "Selecciones una opción")
        End Sub

        Friend Async Function Actualizar() As Task
            Dim detalleSalida As String = String.Empty
            Dim fechaSalida As DateTime? = CType(Nothing, DateTime?)
            Dim estadoCheque As EstadoCheque = EstadoCheque.Ingresado

            If (DestinoSalidaDetalleSeleccionado.Key.Value <> DestinoSalidaCheque.SinSalida) Then
                detalleSalida = DestinoSalidaComentarioDetalle
                fechaSalida = DateTime.Now
                estadoCheque = EstadoCheque.Salido
            End If

            Dim cheque As Model.Cheque = New Model.Cheque(ChequeDetalle.Id,
                                                          IdSucursal,
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
                                                          fechaSalida,
                                                          detalleSalida,
                                                          estadoCheque,
                                                          DestinoSalidaDetalleSeleccionado.Key.Value)

            Await Task.Run(Function() Servicio.ActualizarCheque(cheque))
        End Function

        Friend Async Function CargarDatosAsync() As Task
            Dim tareas As List(Of Task) = New List(Of Task)()
            tareas.Add(TotalCarteraAsync())
            tareas.Add(CargarBancosAsync())
            Await Task.WhenAll(tareas)
        End Function

        Public Async Function TotalCarteraAsync() As Task
            TotalChequeCartera = Await Task.Run(Function() Servicio.TotalCarteraCheque(IdSucursal))
            NotifyPropertyChanged(NameOf(Me.TotalChequeCartera))
        End Function

        Public Async Function CargarBancosAsync() As Task
            Dim Bancos As List(Of Banco) = Await Task.Run(Function() Comunes.Servicio.ObtenerBancos())
            Bancos.ForEach(Sub(x) BancosEmisores.Add(New KeyValuePair(Of Integer?, String)(x.Id, x.Nombre)))
            BancosEmisores.Insert(0, New KeyValuePair(Of Integer?, String)(Nothing, "Selecciones una opción"))
            NotifyPropertyChanged(NameOf(Me.BancosEmisores))
        End Function

        Friend Async Function CargarChequesAsync(idCheque As Long) As Task
            Dim cheque As Model.Cheque = Await Task.Run(Function() Servicio.ObtenerCheque(idCheque))
            ChequeDetalle = Mapper.Map(Of ChequeDetalleViewModel)(cheque)
            DestinoSalidaDetalleSeleccionado = New KeyValuePair(Of DestinoSalidaCheque?, String)(cheque.DestinoSalida, cheque.DestinoSalida)
            DestinoSalidaComentarioDetalle = cheque.DetalleSalida
            ChequeDetalle.BancosEmisores = BancosEmisores
            NotifyPropertyChanged(NameOf(Me.ChequeDetalle))
        End Function

        Friend Async Function BuscarAsync(estados As IEnumerable(Of EstadoCheque), destinosSalida As IEnumerable(Of DestinoSalidaCheque)) As Task

            Dim facturado As Boolean? = Nothing

            If (FacturadoSi = True AndAlso FacturadoNo = False) Then
                facturado = True
            End If

            If (FacturadoSi = False AndAlso FacturadoNo = True) Then
                facturado = False
            End If

            Dim fechaIngresoDesdeFiltro As DateTime? = If(FechaIngresoFiltro, FechaIngresoDesde, CType(Nothing, DateTime?))
            Dim fechaIngresoHastaFiltro As DateTime? = If(FechaIngresoFiltro, FechaIngresoHasta, CType(Nothing, DateTime?))

            Dim fechaDepostioDesdeFiltro As DateTime? = If(FechaDepostioFiltro, FechaDepostioDesde, CType(Nothing, DateTime?))
            Dim fechaDepostioHastaFiltro As DateTime? = If(FechaDepostioFiltro, FechaDepostioHasta, CType(Nothing, DateTime?))

            Dim fechaVencimientoDesdeFiltro As DateTime? = If(FechaVencimientoFiltro, FechaVencimientoDesde, CType(Nothing, DateTime?))
            Dim fechaVencimientoHastaFiltro As DateTime? = If(FechaVencimientoFiltro, FechaVencimientoHasta, CType(Nothing, DateTime?))

            Dim fechaSalidaDesdeFiltro As DateTime? = If(FechaSalidaFiltro, FechaSalidaDesde, CType(Nothing, DateTime?))
            Dim fechaSalidaHastaFiltro As DateTime? = If(FechaSalidaFiltro, FechaSalidaHasta, CType(Nothing, DateTime?))

            Dim chequesModel As IList(Of Model.Cheque) = Await Task.Run(Function() Servicio.BuscarCheque(IdSucursal, facturado, Cliente, Librado, fechaIngresoDesdeFiltro, fechaIngresoHastaFiltro, fechaDepostioDesdeFiltro, fechaDepostioHastaFiltro, fechaVencimientoDesdeFiltro, fechaVencimientoHastaFiltro, fechaSalidaDesdeFiltro, fechaSalidaHastaFiltro, estados, destinosSalida, ImporteDesde, ImporteHasta, NumeroCheque, BancoEmisorSeleccionado.Key))
            TotalChequePantalla = chequesModel.Sum(Function(x) x.Monto)

            Cheques = New BindingList(Of ChequeAdministracionItemViewModel)(Mapper.Map(Of List(Of ChequeAdministracionItemViewModel))(chequesModel))
            NotifyPropertyChanged(NameOf(Me.Cheques))
            NotifyPropertyChanged(NameOf(Me.SinResultados))
        End Function

        Friend Sub Exportar(archivoRuta As String, nombreSucursal As String)
            Try
                Dim ruta As String = System.IO.Path.GetFullPath(ConfigurationManager.AppSettings("ExportarExcelCheque"))
                Using plantillaStream As FileStream = New FileStream(ruta, FileMode.Open, FileAccess.Read)
                    Dim tamplateWorckbook As XSSFWorkbook = New XSSFWorkbook(plantillaStream)

                    Dim chequesSheet As ISheet = tamplateWorckbook.GetSheet("Cheques")

                    Dim headCell As List(Of ICell) = chequesSheet.GetRow(0).Cells
                    headCell(1).SetCellValue(nombreSucursal)

                    Dim index As Integer = 3

                    For Each cheque As ChequeAdministracionItemViewModel In Cheques
                        chequesSheet.CopyRow(index, index + 2)
                        Dim dataCell As List(Of ICell) = chequesSheet.GetRow(index).Cells
                        dataCell(0).SetCellValue(cheque.NumeroOrden)
                        dataCell(1).SetCellValue(If(cheque.MarcaFacturado, "Si", "No"))
                        dataCell(2).SetCellValue(cheque.ClienteNombre)
                        dataCell(3).SetCellValue(cheque.LibradorNombre)
                        dataCell(4).SetCellValue(cheque.BancoEmisor)
                        dataCell(5).SetCellValue(cheque.NumeroCheque)
                        dataCell(6).SetCellValue(cheque.Monto)
                        dataCell(7).SetCellValue(cheque.FechaIngreso.ToString("yyyy/MM/dd"))
                        dataCell(8).SetCellValue(cheque.FechaDesposito.ToString("yyyy/MM/dd"))
                        dataCell(9).SetCellValue(cheque.FechaVencimiento.ToString("yyyy/MM/dd"))
                        dataCell(10).SetCellValue(If(cheque.FechaSalida.HasValue, cheque.FechaSalida.Value.ToString("yyyy/MM/dd"), ""))
                        dataCell(11).SetCellValue(cheque.Estado.ToString())
                        dataCell(12).SetCellValue(cheque.DestinoSalida.ToString())
                        index += 1
                    Next

                    Using archivoStream As FileStream = New FileStream(archivoRuta, FileMode.Create, FileAccess.Write)
                        tamplateWorckbook.Write(archivoStream)
                    End Using
                End Using
            Catch ex As IOException
                Throw New NegocioException("Error al exportar el listado de cheques. Verifique que el archivo no se encuentre abierto.")
            End Try
        End Sub

    End Class
End Namespace
