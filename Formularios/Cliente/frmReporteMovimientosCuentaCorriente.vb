Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Model
Imports Common.Data.Service
Imports CrystalDecisions.CrystalReports.Engine
Imports Ventas.Core.Model.CuentaCorrienteAggregate
Imports Ventas.Data.Service

Public Class frmReporteMovimientosCuentaCorriente
    Inherits Comun

    Private Const MovimientosOrdenadoPor As String = "Fecha"
    Private Const MovimientosDireccionOrdenamiento As OrdenadoDireccion = OrdenadoDireccion.DESC

    Private IdClienteMayorista As Long
    Private FechaDesde As Date
    Private FechaHasta As Date
    Private dtMovimientos As New DataTable

    Sub New(idClienteMayorista As Long, fechaDesde As Date, fechaHasta As Date)
        ' This call is required by the designer.
        InitializeComponent()

        Me.IdClienteMayorista = idClienteMayorista
        Me.FechaDesde = fechaDesde
        Me.FechaHasta = fechaHasta
    End Sub

    Private Sub frmReporteMovimientosCuentaCorriente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          Dim rpt = New ReporteMovimientoCuentaCorriente()

                          Dim clienteMayorista As ClienteMayorista = Await ClienteMayoristaService.ObtenerAsync(TipoBase.Remota, IdClienteMayorista)
                          Dim movimientos As List(Of Movimiento) = Await MovimientoService.ObtenerMovimientosAsync(TipoBase.Remota, IdClienteMayorista, FechaDesde, FechaHasta, MovimientosOrdenadoPor, MovimientosDireccionOrdenamiento, 1, 300, Nothing)

                          InicializarPagosTable()
                          movimientos.ForEach(Sub(x) CargarMovimientos(x))
                          rpt.Database.Tables("MovimientoCuentaCorriente").SetDataSource(dtMovimientos)

                          CType(rpt.ReportDefinition.ReportObjects("txtFacturaNombreFantasia"), TextObject).Text = My.Settings.DatosFiscalNombreFantasia
                          CType(rpt.ReportDefinition.ReportObjects("txtFacturaNombreFantasia"), TextObject).ApplyFont(My.Settings.DatosFiscalNombreFantasiaFuente)
                          CType(rpt.ReportDefinition.ReportObjects("txtFacturaRasonSocial"), TextObject).Text = My.Settings.DatosFiscalRazonSocial
                          CType(rpt.ReportDefinition.ReportObjects("txtFaturaDireccion1"), TextObject).Text = My.Settings.DatosFiscalDireccion
                          CType(rpt.ReportDefinition.ReportObjects("txtFaturaDireccion2"), TextObject).Text = My.Settings.DatosFiscalLocalidad
                          CType(rpt.ReportDefinition.ReportObjects("txtFacturaTelefono"), TextObject).Text = My.Settings.DatosFiscalTel
                          CType(rpt.ReportDefinition.ReportObjects("txtFacturaEmail"), TextObject).Text = My.Settings.DatosFiscalEmail

                          CType(rpt.ReportDefinition.ReportObjects("txtFechaEmision"), TextObject).Text = DateTime.Now.ToString("dd/MM/yyyy")
                          CType(rpt.ReportDefinition.ReportObjects("txtFacturaCuit"), TextObject).Text = My.Settings.DatosFiscalCUIT
                          CType(rpt.ReportDefinition.ReportObjects("txtFacturaIIBB"), TextObject).Text = My.Settings.DatosFiscalIIBB
                          CType(rpt.ReportDefinition.ReportObjects("txtInicioActividad"), TextObject).Text = My.Settings.DatosFiscalInicioActividad.ToString("dd/MM/yyyy")

                          CType(rpt.ReportDefinition.ReportObjects("txtClienteNombre"), TextObject).Text = clienteMayorista.RazonSocial
                          CType(rpt.ReportDefinition.ReportObjects("txtClienteDNI"), TextObject).Text = clienteMayorista.Cuit
                          CType(rpt.ReportDefinition.ReportObjects("txtClienteDomicilio"), TextObject).Text = $"{clienteMayorista.DomicilioFacturacion.Direccion} - {clienteMayorista.DomicilioFacturacion.Localidad}"
                          CType(rpt.ReportDefinition.ReportObjects("txtClienteCondicionIva"), TextObject).Text = clienteMayorista.CondicionIVA.ToString()

                          CType(rpt.ReportDefinition.ReportObjects("txtSaldo"), TextObject).Text = clienteMayorista.MontoCuentaCorriente.ToString("c2")
                          CType(rpt.ReportDefinition.ReportObjects("txtFechaDesde"), TextObject).Text = Me.FechaDesde.ToString("dd/MM/yyyy")
                          CType(rpt.ReportDefinition.ReportObjects("txtFechaHasta"), TextObject).Text = Me.FechaHasta.ToString("dd/MM/yyyy")

                          CrViewer.ReportSource = rpt
                          CrViewer.SelectionMode = SelectionMode.None
                          CrViewer.Refresh()
                      End Function)
    End Sub

    Private Sub CargarMovimientos(movimiento As Movimiento)
        Dim dr As DataRow = dtMovimientos.NewRow()
        dr(0) = movimiento.Fecha
        dr(1) = movimiento.Sucursal.Nombre
        dr(2) = $"{movimiento.TipoMovimientoCuentaCorriente} - {movimiento.TipoAccionCuentaCorriente}"
        dr(3) = movimiento.NumeroComprobante
        dr(4) = movimiento.Monto
        dr(5) = movimiento.Saldo

        dtMovimientos.Rows.Add(dr)
    End Sub

    Private Sub InicializarPagosTable()
        dtMovimientos = New DataTable("dtMovimientoCuentaCorriente")
        dtMovimientos.Columns.Add("Fecha", Type.GetType("System.DateTime"))
        dtMovimientos.Columns.Add("Sucursal", Type.GetType("System.String"))
        dtMovimientos.Columns.Add("TipoMovimiento", Type.GetType("System.String"))
        dtMovimientos.Columns.Add("NumeroComprabante", Type.GetType("System.String"))
        dtMovimientos.Columns.Add("Monto", Type.GetType("System.Double"))
        dtMovimientos.Columns.Add("Saldo", Type.GetType("System.Double"))

        dtMovimientos.Columns("Monto").DefaultValue = 0
        dtMovimientos.Columns("Saldo").DefaultValue = 0
    End Sub
End Class