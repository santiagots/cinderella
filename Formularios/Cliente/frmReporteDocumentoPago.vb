Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports CrystalDecisions.CrystalReports.Engine
Imports Ventas.Core.Model.ChequeAggregate
Imports Ventas.Core.Model.CuentaCorrienteAggregate
Imports Ventas.Data.Service

Public Class frmReporteDocumentoPagol
    Inherits Comun

    Private IdDocumentoPago As Long
    Private dtPagos As New DataTable
    Private dtCheques As New DataTable

    Sub New(idDocumentoPago As Long)
        ' This call is required by the designer.
        InitializeComponent()

        Me.IdDocumentoPago = idDocumentoPago
    End Sub

    Private Sub frmReporteDocumentoPagol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          Dim rpt = New ReporteDocumentoPago

                          Dim documentoDePago As DocumentoDePago = Await DocumentoDePagoService.ObtenerAsync(TipoBase.Remota, IdDocumentoPago)
                          Dim pagosSinCheques As List(Of DocumentoDePagoPago) = documentoDePago.Pagos.Where(Function(x) x.TipoPago <> TipoPago.Cheque).ToList()

                          If (pagosSinCheques.Count > 0) Then
                              InicializarPagosTable()
                              pagosSinCheques.ForEach(Sub(x) CargarPagos(x))
                              rpt.Database.Tables("Pago").SetDataSource(dtPagos)
                          Else
                              rpt.ReportDefinition.Sections("PagosSection").SectionFormat.EnableSuppress = True
                          End If

                          If (documentoDePago.Cheques.Count > 0) Then
                              InicializarChequesTable()
                              documentoDePago.Cheques.ForEach(Sub(x) CargarCheque(x))
                              rpt.Database.Tables("Cheque").SetDataSource(dtCheques)
                          Else
                              rpt.ReportDefinition.Sections("ChequesSection").SectionFormat.EnableSuppress = True
                          End If

                          CType(rpt.ReportDefinition.ReportObjects("txtNombreRecibo"), TextObject).Text = $"Recibo Nro.: {documentoDePago.Numero}"

                          CType(rpt.ReportDefinition.ReportObjects("txtFacturaNombreFantasia"), TextObject).Text = My.Settings.DatosFiscalNombreFantasia
                          CType(rpt.ReportDefinition.ReportObjects("txtFacturaNombreFantasia"), TextObject).ApplyFont(My.Settings.DatosFiscalNombreFantasiaFuente)
                          CType(rpt.ReportDefinition.ReportObjects("txtFacturaRasonSocial"), TextObject).Text = My.Settings.DatosFiscalRazonSocial
                          CType(rpt.ReportDefinition.ReportObjects("txtFaturaDireccion1"), TextObject).Text = My.Settings.DatosFiscalDireccion
                          CType(rpt.ReportDefinition.ReportObjects("txtFaturaDireccion2"), TextObject).Text = My.Settings.DatosFiscalLocalidad
                          CType(rpt.ReportDefinition.ReportObjects("txtFacturaTelefono"), TextObject).Text = My.Settings.DatosFiscalTel
                          CType(rpt.ReportDefinition.ReportObjects("txtFacturaEmail"), TextObject).Text = My.Settings.DatosFiscalEmail

                          CType(rpt.ReportDefinition.ReportObjects("txtFechaEmision"), TextObject).Text = documentoDePago.Fecha.ToString("dd/MM/yyyy")
                          CType(rpt.ReportDefinition.ReportObjects("txtFacturaCuit"), TextObject).Text = My.Settings.DatosFiscalCUIT
                          CType(rpt.ReportDefinition.ReportObjects("txtFacturaIIBB"), TextObject).Text = My.Settings.DatosFiscalIIBB
                          CType(rpt.ReportDefinition.ReportObjects("txtInicioActividad"), TextObject).Text = My.Settings.DatosFiscalInicioActividad.ToString("dd/MM/yyyy")

                          CType(rpt.ReportDefinition.ReportObjects("txtClienteNombre"), TextObject).Text = documentoDePago.ClienteMayorista.RazonSocial
                          CType(rpt.ReportDefinition.ReportObjects("txtClienteDNI"), TextObject).Text = documentoDePago.ClienteMayorista.Cuit
                          CType(rpt.ReportDefinition.ReportObjects("txtClienteDomicilio"), TextObject).Text = $"{documentoDePago.ClienteMayorista.DomicilioFacturacion.Direccion} - {documentoDePago.ClienteMayorista.DomicilioFacturacion.Localidad}"
                          CType(rpt.ReportDefinition.ReportObjects("txtClienteCondicionIva"), TextObject).Text = documentoDePago.ClienteMayorista.CondicionIVA.ToString()
                          CType(rpt.ReportDefinition.ReportObjects("txtTotal"), TextObject).Text = documentoDePago.PagoTotal.Total.ToString("c2")
                          CType(rpt.ReportDefinition.ReportObjects("txtFirmaRasonSocial"), TextObject).Text = My.Settings.DatosFiscalRazonSocial
                          CType(rpt.ReportDefinition.ReportObjects("txtAnulado"), TextObject).Text = If(documentoDePago.Anulado, $"ANULADO FECHA {documentoDePago.FechaAnulado.Value.ToString("dd/MM/yyyy")}", String.Empty)

                          CrViewer.ReportSource = rpt
                          CrViewer.SelectionMode = SelectionMode.None
                          CrViewer.Refresh()
                      End Function)
    End Sub

    Private Sub CargarPagos(pago As DocumentoDePagoPago)
        Dim dr As DataRow = dtPagos.NewRow()
        dr(0) = pago.ToString()
        dr(1) = pago.MontoPago.Monto
        dr(2) = 0
        dr(3) = pago.MontoPago.Total

        dtPagos.Rows.Add(dr)
    End Sub

    Private Sub CargarCheque(cheque As Cheque)
        Dim dr As DataRow = dtCheques.NewRow()
        dr(0) = cheque.NumeroCheque
        dr(1) = cheque.LibradorNombre
        dr(2) = cheque.BancoEmisor.Nombre
        dr(3) = cheque.FechaDesposito.ToShortDateString
        dr(4) = cheque.FechaIngreso.ToShortDateString
        dr(5) = cheque.Monto

        dtCheques.Rows.Add(dr)
    End Sub

    Private Sub InicializarPagosTable()
        dtPagos = New DataTable("PagosItems")
        dtPagos.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtPagos.Columns.Add("Subtotal", Type.GetType("System.Double"))
        dtPagos.Columns.Add("CFT", Type.GetType("System.Double"))
        dtPagos.Columns.Add("Total", Type.GetType("System.Double"))

        dtPagos.Columns("Subtotal").DefaultValue = 0
        dtPagos.Columns("CFT").DefaultValue = 0
        dtPagos.Columns("Total").DefaultValue = 0
    End Sub

    Private Sub InicializarChequesTable()
        dtCheques = New DataTable("ChequesItems")
        dtCheques.Columns.Add("Numero", Type.GetType("System.String"))
        dtCheques.Columns.Add("Librador", Type.GetType("System.String"))
        dtCheques.Columns.Add("Banco", Type.GetType("System.String"))
        dtCheques.Columns.Add("FechaDeposito", Type.GetType("System.String"))
        dtCheques.Columns.Add("FechaIngreso", Type.GetType("System.String"))
        dtCheques.Columns.Add("Importe", Type.GetType("System.Double"))

        dtCheques.Columns("Importe").DefaultValue = 0
    End Sub
End Class