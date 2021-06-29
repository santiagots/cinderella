Imports CrystalDecisions.CrystalReports.Engine
Imports Ventas.Core.Model.RemitoAgreggate

Public Class frmReporteRemito

    Private RemitoModel As Remito
    Private ds As DataSet = New DataSet()
    Private dtProductos As DataTable = New DataTable()

    Public Sub New(remito As Remito)
        ' This call is required by the designer.
        InitializeComponent()

        RemitoModel = remito
    End Sub

    Private Sub frmReporteRemito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ejecutar(Sub()
                     Dim reporte = New ReporteRemito()

                     InicializarTransaccionItemsTable(dtProductos)
                     CargarItems(RemitoModel.RemitoItems)
                     reporte.Database.Tables("TransaccionItem").SetDataSource(dtProductos)


                     CType(reporte.ReportDefinition.ReportObjects("TxtFecha"), TextObject).Text = DateTime.Now.ToString("dd/MM/yyyy")
                     CType(reporte.ReportDefinition.ReportObjects("txtClienteNombre"), TextObject).Text = RemitoModel.NombreYApellido.ToUpper()
                     CType(reporte.ReportDefinition.ReportObjects("txtClienteCuit"), TextObject).Text = RemitoModel.CUIT
                     CType(reporte.ReportDefinition.ReportObjects("txtClienteDomicilio"), TextObject).Text = $"{RemitoModel.Direccion.ToUpper()} ({RemitoModel.Localidad.ToUpper()})"
                     CType(reporte.ReportDefinition.ReportObjects("txtClienteCondicionIva"), TextObject).Text = RemitoModel.CondicionIVA.ToString().ToUpper()
                     CType(reporte.ReportDefinition.ReportObjects("txtDespachoAduana"), TextObject).Text = RemitoModel.DespachoImportacion.ToUpper()

                     CType(reporte.ReportDefinition.ReportObjects("txtTransporteNombre"), TextObject).Text = RemitoModel.RazonSocialTransporte.ToUpper()
                     CType(reporte.ReportDefinition.ReportObjects("txtTransporteDomicilio"), TextObject).Text = $"{RemitoModel.DireccionTransporte.ToUpper()} ({RemitoModel.LocalidadTransporte.ToUpper()})"

                     CType(reporte.ReportDefinition.ReportObjects("txtBultosCantidad"), TextObject).Text = RemitoModel.CantidadBultos

                     CrViewer.ReportSource = reporte
                     CrViewer.SelectionMode = SelectionMode.None
                     CrViewer.Refresh()
                 End Sub)
    End Sub

    Private Sub CargarItems(items As List(Of RemitoItem))
        For Each item As RemitoItem In items
            Dim dr As DataRow = dtProductos.NewRow()
            dr(0) = item.Codigo
            dr(1) = item.Nombre
            dr(2) = item.Cantidad
            dr(3) = item.Monto.Valor
            dr(4) = 0 'IVA
            dr(5) = 0 'MONTO
            dr(6) = item.Total.Valor

            dtProductos.Rows.Add(dr)
        Next
    End Sub

    Private Sub InicializarTransaccionItemsTable(ByRef dtTrasnasccionItems As DataTable)
        dtTrasnasccionItems = ds.Tables.Add("TransaccionItems")
        dtTrasnasccionItems.Columns.Add("Codigo", Type.GetType("System.String"))
        dtTrasnasccionItems.Columns.Add("Nombre", Type.GetType("System.String"))
        dtTrasnasccionItems.Columns.Add("Cantidad", Type.GetType("System.Double"))
        dtTrasnasccionItems.Columns.Add("Precio", Type.GetType("System.Double"))
        dtTrasnasccionItems.Columns.Add("Iva", Type.GetType("System.Double"))
        dtTrasnasccionItems.Columns.Add("Monto", Type.GetType("System.Double"))
        dtTrasnasccionItems.Columns.Add("SubTotal", Type.GetType("System.Double"))

        dtTrasnasccionItems.Columns("Cantidad").DefaultValue = 0
        dtTrasnasccionItems.Columns("Precio").DefaultValue = 0
        dtTrasnasccionItems.Columns("Iva").DefaultValue = 0
        dtTrasnasccionItems.Columns("Monto").DefaultValue = 0
        dtTrasnasccionItems.Columns("SubTotal").DefaultValue = 0
    End Sub
End Class