Imports System.IO
Imports Common.Core.Enum
Imports CrystalDecisions.CrystalReports.Engine
Imports Ventas.Core.Model.PresupuestoAgreggate
Imports Ventas.Core.Model.ValueObjects
Imports BaseModel = Ventas.Core.Model.BaseAgreggate

Public Class frmReportePresupuesto

    Public Presupuesto As Presupuesto
    Private ds As New DataSet
    Private dt As New DataTable

    Sub New(presupuesto As Presupuesto)

        ' This call is required by the designer.
        InitializeComponent()

        Me.Presupuesto = presupuesto
    End Sub

    Private Sub frmReportePresupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt = ds.Tables.Add("Presupuesto")
        dt.Columns.Add("Codigo", Type.GetType("System.String"))
        dt.Columns.Add("Nombre", Type.GetType("System.String"))
        dt.Columns.Add("Cantidad", Type.GetType("System.Double"))
        dt.Columns.Add("Precio", Type.GetType("System.Double"))
        dt.Columns.Add("Iva", Type.GetType("System.Double"))
        dt.Columns.Add("Monto", Type.GetType("System.Double"))
        dt.Columns.Add("SubTotal", Type.GetType("System.Double"))

        dt.Columns("Cantidad").DefaultValue = 0
        dt.Columns("Precio").DefaultValue = 0
        dt.Columns("Iva").DefaultValue = 0
        dt.Columns("Monto").DefaultValue = 0
        dt.Columns("SubTotal").DefaultValue = 0

        Dim SubTotal As Double = 0

        For Each item As PresupuestoItem In Presupuesto.PresupuestoItems

            'SubTotal += item. * item.Cantidad

            AgregarItemATabla(item.Producto, item.Cantidad, item.MontoProducto, Presupuesto.TipoCliente)
        Next

        Dim rpt As ReportePresupuesto2 = New ReportePresupuesto2

        rpt.SetDataSource(ds.Tables("Presupuesto"))

        If File.Exists(VariablesGlobales.RutaLogo) Then
            rpt.SetParameterValue("rutaLogo", VariablesGlobales.RutaLogo)
            CType(rpt.ReportDefinition.ReportObjects("txtFacturaNombreFantasia"), TextObject).Text = String.Empty
            CType(rpt.ReportDefinition.ReportObjects("txtFacturaNombreFantasia"), TextObject).ObjectFormat.EnableSuppress = True
        Else
            CType(rpt.ReportDefinition.ReportObjects("picLogo"), PictureObject).ObjectFormat.EnableSuppress = True
            CType(rpt.ReportDefinition.ReportObjects("txtFacturaNombreFantasia"), TextObject).Text = My.Settings.DatosFiscalNombreFantasia
            CType(rpt.ReportDefinition.ReportObjects("txtFacturaNombreFantasia"), TextObject).ApplyFont(My.Settings.DatosFiscalNombreFantasiaFuente)
            rpt.SetParameterValue("rutaLogo", String.Empty)
        End If

        CType(rpt.ReportDefinition.ReportObjects("txtPresupuestoRasonSocial"), TextObject).Text = My.Settings.DatosFiscalRazonSocial
        CType(rpt.ReportDefinition.ReportObjects("txtPresupuestoDireccion1"), TextObject).Text = My.Settings.DatosFiscalDireccion
        CType(rpt.ReportDefinition.ReportObjects("txtPresupuestoDireccion2"), TextObject).Text = My.Settings.DatosFiscalLocalidad
        CType(rpt.ReportDefinition.ReportObjects("txtPresupuestoTelefono"), TextObject).Text = My.Settings.DatosFiscalTel
        CType(rpt.ReportDefinition.ReportObjects("txtPresupuestoEmail"), TextObject).Text = My.Settings.DatosFiscalEmail

        CType(rpt.ReportDefinition.ReportObjects("txtNumeroPresupuesto"), TextObject).Text = $"Presupuesto Nro. {Presupuesto.Numero}"

        CType(rpt.ReportDefinition.ReportObjects("txtFechaEmision"), TextObject).Text = Presupuesto.Fecha.ToString("dd/MM/yyyy")
        CType(rpt.ReportDefinition.ReportObjects("txtFacturaCuit"), TextObject).Text = My.Settings.DatosFiscalCUIT
        CType(rpt.ReportDefinition.ReportObjects("txtFacturaIIBB"), TextObject).Text = My.Settings.DatosFiscalIIBB
        CType(rpt.ReportDefinition.ReportObjects("txtInicioActividad"), TextObject).Text = My.Settings.DatosFiscalInicioActividad.ToString("dd/MM/yyyy")

        CType(rpt.ReportDefinition.ReportObjects("txtClienteCUIT"), TextObject).Text = Presupuesto.ClienteMayorista?.Cuit
        CType(rpt.ReportDefinition.ReportObjects("txtClienteCondicion"), TextObject).Text = Presupuesto.CondicionPago.ToString()
        CType(rpt.ReportDefinition.ReportObjects("txtClienteNombre"), TextObject).Text = Presupuesto.ClienteMayorista?.RazonSocial
        CType(rpt.ReportDefinition.ReportObjects("txtClienteDireccion"), TextObject).Text = If(Presupuesto.ClienteMayorista.DomicilioFacturacion IsNot Nothing, Presupuesto.ClienteMayorista.DomicilioFacturacion.ToString(), "")
        CType(rpt.ReportDefinition.ReportObjects("txtClienteTelefono"), TextObject).Text = If(Presupuesto.ClienteMayorista.DomicilioFacturacion IsNot Nothing, Presupuesto.ClienteMayorista.DomicilioFacturacion.Telefono, "")


        CType(rpt.ReportDefinition.ReportObjects("TxtSubTotal"), TextObject).Text = Presupuesto.MontoTotal.Valor.ToString("C2")
        CType(rpt.ReportDefinition.ReportObjects("TxtTotal"), TextObject).Text = Presupuesto.MontoTotal.Valor.ToString("C2")

        If (Presupuesto.Anulado) Then
            CType(rpt.ReportDefinition.ReportObjects("TxtDescipcionAnulado"), TextObject).Text = String.Format("PRESUPUESTO ANULADO{0}MOTIVO: {1}{0}", Environment.NewLine, Presupuesto.MotivoAnulado)
        End If


        CrViewer.ReportSource = rpt
        CrViewer.Refresh()
    End Sub

    Private Sub AgregarItemATabla(producto As BaseModel.Producto, cantidad As Integer, monto As MontoProducto, tipoCliente As TipoCliente)
        If tipoCliente = TipoCliente.Minorista Then
            AgregarRow(producto, cantidad, 0, monto.Iva, monto.Valor)
        Else
            AgregarRow(producto, cantidad, monto.Valor, monto.Iva, monto.Valor)
        End If
    End Sub

    Private Sub AgregarRow(entProducto As BaseModel.Producto, cantidad As Integer, Precio As Double, Iva As Double, monto As Double)
        Dim dr As DataRow = dt.NewRow()
        dr(0) = entProducto.Codigo
        dr(1) = entProducto.Nombre
        dr(2) = cantidad
        dr(3) = Precio
        dr(4) = Iva
        dr(5) = monto
        dr(6) = monto * cantidad

        dt.Rows.Add(dr)
    End Sub

    Private Sub CrViewer_Load(sender As Object, e As EventArgs) Handles CrViewer.Load

    End Sub
End Class