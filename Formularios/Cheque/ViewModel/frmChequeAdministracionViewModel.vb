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
Imports OfficeOpenXml
Imports Model = Ventas.Core.Model.ChequeAggregate

Namespace Formularios.Cheque
    Public Class frmChequeAdministracionViewModel
        Inherits Comunes.Common

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
                Using plantilla As ExcelPackage = New ExcelPackage(New FileInfo(ruta))
                    Dim chequesSheet As ExcelWorksheet = plantilla.Workbook.Worksheets("Cheques")

                    chequesSheet.Cells("B1").Value = nombreSucursal

                    Dim index As Integer = 4

                    For Each cheque As ChequeAdministracionItemViewModel In Cheques
                        If (index <= Cheques.Count) Then
                            'Copio formato de fila
                            chequesSheet.Cells(index, 1, index, chequesSheet.Dimension.End.Column).Copy(chequesSheet.Cells(index + 2, 1, index + 2, chequesSheet.Dimension.End.Column))
                        End If

                        chequesSheet.Cells(index, 1).Value = cheque.NumeroOrden
                        chequesSheet.Cells(index, 2).Value = If(cheque.MarcaFacturado, "Si", "No")
                        chequesSheet.Cells(index, 3).Value = cheque.ClienteNombre
                        chequesSheet.Cells(index, 4).Value = cheque.LibradorNombre
                        chequesSheet.Cells(index, 5).Value = cheque.BancoEmisor
                        chequesSheet.Cells(index, 6).Value = cheque.NumeroCheque
                        chequesSheet.Cells(index, 7).Value = cheque.Monto
                        chequesSheet.Cells(index, 8).Value = cheque.FechaIngreso.ToString("yyyy/MM/dd")
                        chequesSheet.Cells(index, 9).Value = cheque.FechaDesposito.ToString("yyyy/MM/dd")
                        chequesSheet.Cells(index, 10).Value = cheque.FechaVencimiento.ToString("yyyy/MM/dd")
                        chequesSheet.Cells(index, 11).Value = If(cheque.FechaSalida.HasValue, cheque.FechaSalida.Value.ToString("yyyy/MM/dd"), "")
                        chequesSheet.Cells(index, 12).Value = cheque.Estado.ToString()
                        chequesSheet.Cells(index, 13).Value = cheque.DestinoSalida.ToString()
                        index += 1
                    Next

                    plantilla.SaveAs(New FileInfo(archivoRuta))
                End Using
            Catch ex As IOException
                Throw New NegocioException("Error al exportar el listado de cheques. Verifique que el archivo no se encuentre abierto.")
            End Try
        End Sub

    End Class
End Namespace
