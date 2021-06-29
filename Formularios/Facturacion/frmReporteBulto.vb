Imports CrystalDecisions.CrystalReports.Engine
Imports Ventas.Core.Model.RemitoAgreggate

Public Class frmReporteBulto

    Private RemitoModel As Remito

    Public Sub New(remito As Remito)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RemitoModel = remito
    End Sub

    Private Sub frmReporteBulto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ejecutar(Sub()
                     Dim reporte = New ReporteBulto()

                     Dim dtBultos As DataTable = InicializarTransaccionItemsTable()
                     CargarItems(dtBultos, RemitoModel.CantidadBultos, RemitoModel.IncluyeFactura)
                     reporte.Database.Tables("Bultos").SetDataSource(dtBultos)

                     CType(reporte.ReportDefinition.ReportObjects("txtFacturaNombreFantasia"), TextObject).Text = My.Settings.DatosFiscalNombreFantasia
                     CType(reporte.ReportDefinition.ReportObjects("txtFacturaNombreFantasia"), TextObject).ApplyFont(My.Settings.DatosFiscalNombreFantasiaFuente)
                     CType(reporte.ReportDefinition.ReportObjects("txtFacturaRasonSocial"), TextObject).Text = My.Settings.DatosFiscalRazonSocial
                     CType(reporte.ReportDefinition.ReportObjects("txtFaturaDireccion1"), TextObject).Text = My.Settings.DatosFiscalDireccion
                     CType(reporte.ReportDefinition.ReportObjects("txtFaturaDireccion2"), TextObject).Text = My.Settings.DatosFiscalLocalidad
                     CType(reporte.ReportDefinition.ReportObjects("txtFacturaTelefono"), TextObject).Text = My.Settings.DatosFiscalTel
                     CType(reporte.ReportDefinition.ReportObjects("txtFacturaEmail"), TextObject).Text = My.Settings.DatosFiscalEmail

                     CType(reporte.ReportDefinition.ReportObjects("txtClienteNombre"), TextObject).Text = RemitoModel.NombreYApellido
                     CType(reporte.ReportDefinition.ReportObjects("txtClienteDireccion"), TextObject).Text = RemitoModel.Direccion
                     CType(reporte.ReportDefinition.ReportObjects("txtClienteLocalidad"), TextObject).Text = RemitoModel.Localidad

                     CrViewer.ReportSource = reporte
                     CrViewer.SelectionMode = SelectionMode.None
                     CrViewer.Refresh()
                 End Sub)
    End Sub

    Private Sub CargarItems(dtBultos As DataTable, totalBultos As Integer, incluyeFactura As Boolean)
        For numero = 1 To totalBultos
            Dim dr As DataRow = dtBultos.NewRow()
            dr(0) = numero
            dr(1) = totalBultos
            dr(2) = numero = 1 AndAlso incluyeFactura

            dtBultos.Rows.Add(dr)
        Next
    End Sub

    Private Function InicializarTransaccionItemsTable() As DataTable
        Dim dtBultos As DataTable = New DataTable("Bultos")
        dtBultos.Columns.Add("Numero", Type.GetType("System.Int32"))
        dtBultos.Columns.Add("Total", Type.GetType("System.Int32"))
        dtBultos.Columns.Add("IncluyeFactura", Type.GetType("System.Boolean"))

        dtBultos.Columns("Numero").DefaultValue = 0
        dtBultos.Columns("Total").DefaultValue = 0
        dtBultos.Columns("IncluyeFactura").DefaultValue = False

        Return dtBultos
    End Function
End Class