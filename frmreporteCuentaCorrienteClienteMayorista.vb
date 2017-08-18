Imports CrystalDecisions.CrystalReports.Engine
Imports Entidades
Imports Negocio

Public Class frmReporteCuentaCorrienteClienteMayorista

    Public Id_Cliente As Integer
    Public Nombre As String
    Public RazonSocial As String
    Public FechaDesde As Date
    Public FechaHasta As Date
    Public FiltroFecha As Boolean
    Public Saldo As Decimal
    Public Movimientos As List(Of MovimientoCuentaCorrienteClienteMayorista)

    Private Sub frmreporteCuentaCorrienteClienteMayorista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = New DataTable("MovimientosCuentaCorrienteMayorista")
        dt.Columns.Add("Fecha", Type.GetType("System.String"))
        dt.Columns.Add("TipoMovimiento", Type.GetType("System.String"))
        dt.Columns.Add("TipoFactura", Type.GetType("System.String"))
        dt.Columns.Add("PuntoVenta", Type.GetType("System.String"))
        dt.Columns.Add("Comprobante", Type.GetType("System.String"))
        dt.Columns.Add("Monto", Type.GetType("System.String"))
        dt.Columns.Add("Saldo", Type.GetType("System.String"))
        dt.Columns.Add("Empresa", Type.GetType("System.String"))

        For Each detalle As MovimientoCuentaCorrienteClienteMayorista In Movimientos
            AgregarRow(detalle, dt)
        Next

        Dim rpt As ReporteCuentaCorrienteMayorista = New ReporteCuentaCorrienteMayorista

        rpt.SetDataSource(dt)

        CType(rpt.ReportDefinition.ReportObjects("txtDesde"), TextObject).Text = If(FiltroFecha, FechaDesde.ToString("dd/MM/yyyy"), Movimientos.First.Fecha.ToString("dd/MM/yyyy"))
        CType(rpt.ReportDefinition.ReportObjects("txtHasta"), TextObject).Text = If(FiltroFecha, FechaHasta.ToString("dd/MM/yyyy"), Movimientos.Last.Fecha.ToString("dd/MM/yyyy"))
        CType(rpt.ReportDefinition.ReportObjects("txtEmitido"), TextObject).Text = DateTime.Now.ToString("dd/MM/yyyy")
        CType(rpt.ReportDefinition.ReportObjects("txtNroCliente"), TextObject).Text = Id_Cliente
        CType(rpt.ReportDefinition.ReportObjects("txtNombre"), TextObject).Text = Nombre
        CType(rpt.ReportDefinition.ReportObjects("txtRazonSocial"), TextObject).Text = RazonSocial
        CType(rpt.ReportDefinition.ReportObjects("TxtSaldo"), TextObject).Text = Saldo

        CrViewer.ReportSource = rpt
        CrViewer.Refresh()
    End Sub

    Private Sub AgregarRow(movimiento As MovimientoCuentaCorrienteClienteMayorista, ByRef dt As DataTable)
        Dim dr As DataRow = dt.NewRow()
        dr(0) = movimiento.Fecha
        dr(1) = movimiento.TipoMovimiento
        dr(2) = movimiento.TipoFactura
        dr(3) = If(movimiento.PuntoVenta > 0, movimiento.PuntoVenta.ToString("D3"), "")
        dr(4) = If(movimiento.Comprobante > 0, movimiento.Comprobante.ToString("D9"), "")
        dr(5) = movimiento.Monto.ToString("C2")
        dr(6) = movimiento.Saldo.ToString("C2")
        dr(7) = movimiento.Empresa

        dt.Rows.Add(dr)
    End Sub
End Class