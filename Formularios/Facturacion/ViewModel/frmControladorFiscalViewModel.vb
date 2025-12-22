Imports System.ComponentModel
Imports System.Configuration
Imports System.IO
Imports System.Text
Imports System.Threading.Tasks
Imports Model = Ventas.Core.Model.VentaAggregate
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Common.Core.Extension
Imports OfficeOpenXml

Namespace Formularios.Facturacion

    Public Class frmControladorFiscalViewModel
        Inherits Comunes.Common

        Private IdSucursal As Integer

        Public Property DataGridImpuestos As DataGridView
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
        Public Property Facturas As List(Of ControladorFiscalTicketsItems)
        Public ReadOnly Property SinResultados As Boolean
            Get
                Return Not Facturas.Any()
            End Get
        End Property

        Sub New(IdSucursal As Integer)
            Me.IdSucursal = IdSucursal
            Me._Facturas = New List(Of ControladorFiscalTicketsItems)()
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
                Servicio.CierreZPorFecha(ControladorFiscalFechaDesde, ControladorFiscalFechaHasta)
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

            Dim facturasModel As List(Of Model.Factura) = Await Task.Run(Function() Servicio.BuscarFactura(IdSucursal, Nothing, Nothing, Nothing, Nothing, Nothing, TicketFechaDesde, TicketFechaHasta, tiposFacturas))
            Facturas = facturasModel.Select(Function(x) New ControladorFiscalTicketsItems(x)).ToList()

            Dim maxImpuestos As Integer = 0

            If (Facturas.Count > 0) Then
                maxImpuestos = Facturas.Max(Function(t) If(t.Impuestos?.Count, 0))
            End If

            DataGridImpuestos.Columns.Clear()
            DataGridImpuestos.Columns.Add(GetColumna("Fecha", "Fecha", DataGridViewAutoSizeColumnMode.DisplayedCells))
            DataGridImpuestos.Columns.Add(GetColumna("Numero", "Número", DataGridViewAutoSizeColumnMode.DisplayedCells))
            DataGridImpuestos.Columns.Add(GetColumna("PuntoVenta", "P. Venta", DataGridViewAutoSizeColumnMode.DisplayedCells))
            DataGridImpuestos.Columns.Add(GetColumna("TipoFactura", "Tipo", DataGridViewAutoSizeColumnMode.DisplayedCells))
            DataGridImpuestos.Columns.Add(GetColumna("CondicionIVA", "Condición", DataGridViewAutoSizeColumnMode.DisplayedCells))
            DataGridImpuestos.Columns.Add(GetColumna("CUIT", "CUIT", DataGridViewAutoSizeColumnMode.DisplayedCells))
            DataGridImpuestos.Columns.Add(GetColumna("Nombre", "Nombre", DataGridViewAutoSizeColumnMode.DisplayedCells))
            DataGridImpuestos.Columns.Add(GetColumna("Direccion", "Dirección", DataGridViewAutoSizeColumnMode.DisplayedCells))
            DataGridImpuestos.Columns.Add(GetColumna("Localidad", "Localidad", DataGridViewAutoSizeColumnMode.DisplayedCells))
            DataGridImpuestos.Columns.Add(GetColumna("Provincia", "Provincia", DataGridViewAutoSizeColumnMode.DisplayedCells))
            DataGridImpuestos.Columns.Add(GetColumna("Subtotal", "Subtotal", DataGridViewAutoSizeColumnMode.DisplayedCells))
            DataGridImpuestos.Columns.Add(GetColumna("IVA", "IVA", DataGridViewAutoSizeColumnMode.DisplayedCells))
            DataGridImpuestos.Columns.Add(GetColumna("Total", "Total", DataGridViewAutoSizeColumnMode.DisplayedCells))

            'Columnas dinámicas según la cantidad máxima de impuestos
            For i As Integer = 1 To maxImpuestos
                DataGridImpuestos.Columns.Add(GetColumna($"ImpuestoDesc{i}", $"PrecepcionFactura", DataGridViewAutoSizeColumnMode.DisplayedCells))
                DataGridImpuestos.Columns.Add(GetColumna($"ImpuestoMonto{i}", $"Imp. Monto", DataGridViewAutoSizeColumnMode.DisplayedCells))
            Next

            For Each ticket In Facturas
                Dim row As New List(Of Object)

                'Datos fijos
                row.Add(ticket.Fecha)
                row.Add(ticket.Numero)
                row.Add(ticket.PuntoVenta)
                row.Add(ticket.TipoFactura)
                row.Add(ticket.CondicionIVA)
                row.Add(ticket.CUIT)
                row.Add(ticket.Nombre)
                row.Add(ticket.Direccion)
                row.Add(ticket.Localidad)
                row.Add(ticket.Provincia)
                row.Add(ticket.Subtotal)
                row.Add(ticket.Iva)
                row.Add(ticket.Total)

                'Datos dinámicos de impuestos
                For i As Integer = 0 To maxImpuestos - 1
                    If ticket.Impuestos IsNot Nothing AndAlso i < ticket.Impuestos.Count Then
                        row.Add(ticket.Impuestos(i).Descripcion)
                        row.Add(ticket.Impuestos(i).Monto)
                    Else
                        row.Add("") ' sin descripción
                        row.Add("") ' sin monto
                    End If
                Next

                DataGridImpuestos.Rows.Add(row.ToArray())
            Next
        End Function

        Private Function GetColumna(colName As String, colHeader As String, autoSizeMode As DataGridViewAutoSizeColumnMode) As DataGridViewTextBoxColumn
            Dim col As New DataGridViewTextBoxColumn()
            col.Name = colName
            col.HeaderText = colHeader
            col.AutoSizeMode = autoSizeMode

            Return col
        End Function

        Friend Sub Exportar(archivoRuta As String, nombreSucursal As String)
            Try
                Dim ruta As String = System.IO.Path.GetFullPath(ConfigurationManager.AppSettings("ExportarFacturas"))
                Using plantilla As ExcelPackage = New ExcelPackage(New FileInfo(ruta))
                    Dim facturasSheet As ExcelWorksheet = plantilla.Workbook.Worksheets("Facturas")
                    facturasSheet.Cells("B1").Value = nombreSucursal

                    Dim maxImpuestos As Integer = Facturas.Max(Function(t) If(t.Impuestos?.Count, 0))
                    Dim row As Integer = 3
                    Dim column As Integer = 14
                    Dim colBase As Integer = 13 ' Columna modelo para copiar el estilo
                    For i As Integer = 1 To maxImpuestos

                        ' Copiar solo el estilo visual
                        For r As Integer = 1 To facturasSheet.Dimension.End.Row
                            facturasSheet.Column(column).Width = facturasSheet.Column(colBase).Width
                            facturasSheet.Column(column + 1).Width = facturasSheet.Column(colBase).Width
                            facturasSheet.Cells(r, column).StyleID = facturasSheet.Cells(r, colBase).StyleID
                            facturasSheet.Cells(r, column + 1).StyleID = facturasSheet.Cells(r, colBase + 1).StyleID
                        Next

                        facturasSheet.Cells(row, column).Value = $"PrecepcionFactura {i}"
                        facturasSheet.Cells(row, column + 1).Value = $"PrecepcionFactura {i} Monto"
                        column += 2
                    Next

                    row = 4
                    For Each ticket As ControladorFiscalTicketsItems In Facturas.ToList()
                        If (row <= Facturas.Count) Then
                            'Copio formato de fila
                            facturasSheet.Cells(row, 1, row, facturasSheet.Dimension.End.Column + maxImpuestos).Copy(facturasSheet.Cells(row + 2, 1, row + 2, facturasSheet.Dimension.End.Column + maxImpuestos))
                        End If

                        facturasSheet.Cells(row, 1).Value = ticket.Fecha.ToString("yyyy/MM/dd")
                        facturasSheet.Cells(row, 2).Value = ticket.Numero
                        facturasSheet.Cells(row, 3).Value = ticket.PuntoVenta
                        facturasSheet.Cells(row, 4).Value = ticket.TipoFactura.ToString()
                        facturasSheet.Cells(row, 5).Value = ticket.CondicionIVA.ToString()
                        facturasSheet.Cells(row, 6).Value = ticket.CUIT
                        facturasSheet.Cells(row, 7).Value = ticket.Nombre
                        facturasSheet.Cells(row, 8).Value = ticket.Direccion
                        facturasSheet.Cells(row, 9).Value = ticket.Localidad
                        facturasSheet.Cells(row, 10).Value = ticket.Provincia
                        facturasSheet.Cells(row, 11).Value = ticket.Subtotal
                        facturasSheet.Cells(row, 12).Value = ticket.Iva
                        facturasSheet.Cells(row, 13).Value = ticket.Total

                        column = 14

                        For i As Integer = 0 To maxImpuestos - 1
                            If ticket.Impuestos IsNot Nothing AndAlso i < ticket.Impuestos.Count Then
                                facturasSheet.Cells(row, column).Value = ticket.Impuestos(i).Descripcion
                                facturasSheet.Cells(row, column + 1).Value = ticket.Impuestos(i).Monto
                                column += 2
                            End If
                        Next

                        row += 1
                    Next

                    plantilla.SaveAs(New FileInfo(archivoRuta))
                End Using
            Catch ex As IOException
                Throw New NegocioException("Error al exportar el listado de facturas. Verifique que el archivo no se encuentre abierto.")
            End Try
        End Sub
    End Class
End Namespace
