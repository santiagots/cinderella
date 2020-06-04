Imports System.ComponentModel
Imports AutoMapper
Imports Common.Core.Extension
Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports System.Configuration
Imports System.IO
Imports Common.Core.Exceptions
Imports System.Text
Imports OfficeOpenXml
Imports Common.Core.Helper

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
                Using plantilla As ExcelPackage = New ExcelPackage(New FileInfo(ruta))
                    Dim facturasSheet As ExcelWorksheet = plantilla.Workbook.Worksheets("Facturas")
                    facturasSheet.Cells("B1").Value = nombreSucursal
                    Dim index As Integer = 4
                    For Each factura As DocumentoFiscalViewModel In Facturas.ToList()
                        If (index <= Facturas.Count) Then
                            'Copio formato de fila
                            facturasSheet.Cells(index, 1, index, facturasSheet.Dimension.End.Column).Copy(facturasSheet.Cells(index + 2, 1, index + 2, facturasSheet.Dimension.End.Column))
                        End If

                        facturasSheet.Cells(index, 1).Value = factura.Numero
                        facturasSheet.Cells(index, 2).Value = factura.PuntoVenta
                        facturasSheet.Cells(index, 3).Value = factura.TipoFactura.ToString()
                        facturasSheet.Cells(index, 4).Value = factura.CondicionIVA.ToString()
                        facturasSheet.Cells(index, 5).Value = factura.CUIT
                        facturasSheet.Cells(index, 6).Value = factura.NombreYApellido
                        facturasSheet.Cells(index, 7).Value = factura.Direccion
                        facturasSheet.Cells(index, 8).Value = factura.Localidad
                        facturasSheet.Cells(index, 9).Value = factura.Monto
                        facturasSheet.Cells(index, 10).Value = factura.Fecha.ToString("yyyy/MM/dd")
                        index += 1
                    Next

                    plantilla.SaveAs(New FileInfo(archivoRuta))
                End Using
            Catch ex As IOException
                Throw New NegocioException("Error al exportar el listado de facturas. Verifique que el archivo no se encuentre abierto.")
            End Try
        End Sub
    End Class
End Namespace
