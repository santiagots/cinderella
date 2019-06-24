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

Namespace Formularios.Facturacion

    Public Class frmControladorFiscalViewModel
        Inherits SistemaCinderella.VistaModelo.Common

        Private IdSucursal As Integer

        Public Property ControladorFiscalFechaDesde As DateTime
        Public Property ControladorFiscalFechaHasta As DateTime
        Public Property TicketFechaDesde As DateTime
        Public Property TicketFechaHasta As DateTime
        Private _Facturas As List(Of Factura)
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
            Me._Facturas = New List(Of Factura)()
            ControladorFiscalFechaDesde = Date.Now.StartOfWeek(DayOfWeek.Monday)
            ControladorFiscalFechaHasta = Date.Now

            TicketFechaDesde = Date.Now.StartOfWeek(DayOfWeek.Monday)
            TicketFechaHasta = Date.Now
        End Sub

        Friend Sub CierreZ()
            Servicio.CierreZ()
        End Sub

        Friend Sub CierreZPorFecha()
            Servicio.CierreZPorFecha(TicketFechaDesde, TicketFechaHasta)
        End Sub

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

                    For Each factura As Factura In _Facturas
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
