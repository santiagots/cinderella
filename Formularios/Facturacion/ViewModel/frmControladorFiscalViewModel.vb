Imports System.ComponentModel
Imports AutoMapper
Imports Ventas.Core.Model.VentaAggregate
Imports Common.Core.Extension
Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports System.Configuration
Imports System.IO
Imports NPOI.SS.UserModel
Imports NPOI.XSSF.UserModel
Imports Common.Core.Exceptions
Imports System.Text

Namespace Formularios.Facturacion

    Public Class frmControladorFiscalViewModel
        Inherits Comunes.Common

        Private IdSucursal As Integer

        Public Property ControladorFiscalFechaDesde As DateTime
        Public Property ControladorFiscalFechaHasta As DateTime
        Public Property ControladorFiscalJornadaDesde As Integer
        Public Property ControladorFiscalJornadaHasta As Integer

        Private _ControladorFiscalFiltrarPorFecha As Boolean
        Public Property ControladorFiscalFiltrarPorFecha() As Boolean
            Get
                Return _ControladorFiscalFiltrarPorFecha
            End Get
            Set(ByVal value As Boolean)
                _ControladorFiscalFiltrarPorFecha = value
                NotifyPropertyChanged(NameOf(Me.Facturas))
            End Set
        End Property

        Public ReadOnly Property ControladorFiscalFiltrarPorJornada() As Boolean
            Get
                Return Not _ControladorFiscalFiltrarPorFecha
            End Get
        End Property
        Public Property TicketFechaDesde As DateTime
        Public Property TicketFechaHasta As DateTime
        Private _Facturas As List(Of Ventas.Core.Model.VentaAggregate.Factura)
        Public ReadOnly Property Facturas As BindingList(Of DocumentoFiscalViewModel)
            Get
                Return New BindingList(Of DocumentoFiscalViewModel)(Mapper.Map(Of List(Of DocumentoFiscalViewModel))(_Facturas))
            End Get
        End Property

        Public ReadOnly Property SinResultados As Boolean
            Get
                Return Not Facturas.Any()
            End Get
        End Property

        Sub New(IdSucursal As Integer)
            Me.IdSucursal = IdSucursal
            Me._Facturas = New List(Of Ventas.Core.Model.VentaAggregate.Factura)()
            ControladorFiscalFechaDesde = Date.Now.StartOfWeek(DayOfWeek.Monday)
            ControladorFiscalFechaHasta = Date.Now

            TicketFechaDesde = Date.Now.StartOfWeek(DayOfWeek.Monday)
            TicketFechaHasta = Date.Now
        End Sub

        Friend Sub CierreZ()
            Servicio.CierreZ()
        End Sub

        Friend Sub CierreZPorFiltro(ControladorFiscalFiltrarPorFecha As Boolean)
            If Me.ControladorFiscalFiltrarPorFecha Then
                Servicio.CierreZPorFecha(TicketFechaDesde, TicketFechaHasta)
            Else
                Servicio.CierreZPorJornada(ControladorFiscalJornadaDesde, ControladorFiscalJornadaHasta)
            End If

        End Sub

        Friend Function CintaTestigoDigitalPorFiltro(rutaArchivo As String, ControladorFiscalFiltrarPorFecha As Boolean) As String
            Dim nombre As String = String.Empty
            Dim datos As StringBuilder = New StringBuilder()

            If Me.ControladorFiscalFiltrarPorFecha Then
                Servicio.CintaTestigoDigitalPorFecha(TicketFechaDesde, TicketFechaHasta, nombre, datos)
            Else
                Servicio.CintaTestigoDigitalPorJornada(ControladorFiscalJornadaDesde, ControladorFiscalJornadaHasta, nombre, datos)
            End If

            Using sw As New System.IO.StreamWriter($"{rutaArchivo}/{nombre}")
                sw.Write(datos.ToString())
            End Using

            Return nombre
        End Function

        Friend Function DuplicadosDocumentosTipoA(rutaArchivo As String, ControladorFiscalFiltrarPorFecha As Boolean) As String
            Dim nombre As String = String.Empty
            Dim datos As StringBuilder = New StringBuilder()

            If Me.ControladorFiscalFiltrarPorFecha Then
                Servicio.DuplicadosDocumentosTipoAPorFecha(TicketFechaDesde, TicketFechaHasta, nombre, datos)
            Else
                Servicio.DuplicadosDocumentosTipoAPorJornada(ControladorFiscalJornadaDesde, ControladorFiscalJornadaHasta, nombre, datos)
            End If

            Using sw As New System.IO.StreamWriter($"{rutaArchivo}/{nombre}")
                sw.Write(datos.ToString())
            End Using

            Return nombre
        End Function

        Friend Function ResumenTotales(rutaArchivo As String, ControladorFiscalFiltrarPorFecha As Boolean) As String
            Dim nombre As String = String.Empty
            Dim datos As StringBuilder = New StringBuilder()

            If Me.ControladorFiscalFiltrarPorFecha Then
                Servicio.ResumenTotalesPorRangoDeFecha(TicketFechaDesde, TicketFechaHasta, nombre, datos)
            Else
                Servicio.ResumenTotalesPorRangoDeJornadaFiscal(ControladorFiscalJornadaDesde, ControladorFiscalJornadaHasta, nombre, datos)
            End If

            Using sw As New System.IO.StreamWriter($"{rutaArchivo}/{nombre}")
                sw.Write(datos.ToString())
            End Using

            Return nombre
        End Function

        Friend Async Function BuscarAsync() As Task
            Dim tiposFacturas As List(Of TipoFactura) = New List(Of TipoFactura)()
            tiposFacturas.Add(TipoFactura.Ticket)

            _Facturas = Await Task.Run(Function() Servicio.BuscarFactura(IdSucursal, Nothing, Nothing, Nothing, Nothing, Nothing, TicketFechaDesde, TicketFechaHasta, tiposFacturas))

            NotifyPropertyChanged(NameOf(Me.Facturas))
        End Function

        Friend Sub Exportar(archivoRuta As String, nombreSucursal As String)
            Try
                Dim ruta As String = System.IO.Path.GetFullPath(ConfigurationManager.AppSettings("ExportarFacturas"))
                Using plantillaStream As FileStream = New FileStream(ruta, FileMode.Open, FileAccess.Read)
                    Dim tamplateWorckbook As XSSFWorkbook = New XSSFWorkbook(plantillaStream)

                    Dim facturasSheet As ISheet = tamplateWorckbook.GetSheet("Facturas")

                    Dim headCell As List(Of ICell) = facturasSheet.GetRow(0).Cells
                    headCell(1).SetCellValue(nombreSucursal)

                    Dim index As Integer = 3

                    For Each factura As Ventas.Core.Model.VentaAggregate.Factura In _Facturas
                        facturasSheet.CopyRow(index, index + 2)
                        Dim dataCell As List(Of ICell) = facturasSheet.GetRow(index).Cells
                        dataCell(0).SetCellValue(factura.NumeroFactura.First.Numero.ToString())
                        dataCell(1).SetCellValue(factura.PuntoVenta)
                        dataCell(2).SetCellValue(factura.TipoFactura.ToString())
                        dataCell(3).SetCellValue(factura.CondicionIVA.ToString())
                        dataCell(4).SetCellValue(factura.CUIT)
                        dataCell(5).SetCellValue(factura.NombreYApellido)
                        dataCell(6).SetCellValue(factura.Direccion)
                        dataCell(7).SetCellValue(factura.Localidad)
                        dataCell(8).SetCellValue(factura.Monto)
                        dataCell(9).SetCellValue(factura.Fecha.ToString("yyyy/MM/dd"))
                        index += 1
                    Next

                    Using archivoStream As FileStream = New FileStream(archivoRuta, FileMode.Create, FileAccess.Write)
                        tamplateWorckbook.Write(archivoStream)
                    End Using
                End Using
            Catch ex As IOException
                Throw New NegocioException("Error al exportar el listado de facturas. Verifique que el archivo no se encuentre abierto.")
            End Try
        End Sub
    End Class
End Namespace
