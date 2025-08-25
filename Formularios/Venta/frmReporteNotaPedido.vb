Imports System.IO
Imports Common.Core.Enum
Imports Common.Core.Helper
Imports Common.Core.Model
Imports CrystalDecisions.CrystalReports.Engine
Imports Ventas.Core.Model.BaseAgreggate
Imports Ventas.Core.Model.NotaPedidoAgreggate

Public Class frmReporteNotaPedido

    Private NotaPedido As NotaPedido
    Private ClienteMayorista As ClienteMayorista
    Private ds As New DataSet
    Private dtNotaPedidoItems As New DataTable
    Private ocutarMontos As Boolean

    Sub New(notaPedido As NotaPedido, clienteMayorista As ClienteMayorista, ocutarMontos As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        Me.NotaPedido = notaPedido
        Me.ClienteMayorista = clienteMayorista
        Me.ocutarMontos = ocutarMontos
    End Sub

    Private Sub frmReporteNotaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt = New ReporteNotaPedido

        InicializarNotaPedidoItemsTable(dtNotaPedidoItems, ocutarMontos)

        For Each item As TransaccionItem In NotaPedido.NotaPedidoItems
            AgregarRowNotaPedidoItems(item, ocutarMontos)
        Next

        Dim subTotal As Double = 0
        Dim descuento As Double = 0
        Dim subTotalConDescuento As Double = 0
        Dim iva As Double = 0
        Dim total As Double = 0

        If (NotaPedido.TipoCliente = TipoCliente.Mayorista) Then
            subTotal = NotaPedido.MontoTotal.Valor
            descuento = CalcularDescuentoMayorista(NotaPedido.NotaPedidoItems)
            iva = CalcularIVAMayorista(NotaPedido.NotaPedidoItems)
            subTotalConDescuento = subTotal - descuento
            total = subTotalConDescuento + iva
        Else
            total = NotaPedido.MontoTotal.Valor
        End If

        rpt.Database.Tables("NotaPedido").SetDataSource(dtNotaPedidoItems)

        If File.Exists(VariablesGlobales.RutaLogo) Then
            rpt.SetParameterValue("rutaLogo", VariablesGlobales.RutaLogo)
        Else
            rpt.SetParameterValue("rutaLogo", String.Empty)
        End If

        CType(rpt.ReportDefinition.ReportObjects("txtRazonSocial"), TextObject).Text = My.Settings.DatosFiscalRazonSocial
        CType(rpt.ReportDefinition.ReportObjects("txtDireccion1"), TextObject).Text = My.Settings.DatosFiscalDireccion
        CType(rpt.ReportDefinition.ReportObjects("txtDireccion2"), TextObject).Text = My.Settings.DatosFiscalLocalidad
        CType(rpt.ReportDefinition.ReportObjects("txtTelefono"), TextObject).Text = My.Settings.DatosFiscalTel
        CType(rpt.ReportDefinition.ReportObjects("txtEmail"), TextObject).Text = My.Settings.DatosFiscalEmail
        CType(rpt.ReportDefinition.ReportObjects("txtCUIT"), TextObject).Text = My.Settings.DatosFiscalCUIT
        CType(rpt.ReportDefinition.ReportObjects("txtFechaEmision"), TextObject).Text = NotaPedido.Fecha.ToString("dd/MM/yyyy")
        CType(rpt.ReportDefinition.ReportObjects("txtNroPedido"), TextObject).Text = NotaPedido.Numero

        If (NotaPedido.TipoCliente = TipoCliente.Mayorista) Then
            CType(rpt.ReportDefinition.ReportObjects("txtClienteCUIT"), TextObject).Text = ClienteMayorista.Cuit
            CType(rpt.ReportDefinition.ReportObjects("txtClienteCondicion"), TextObject).Text = If(ClienteMayorista.CondicionPago IsNot Nothing, ClienteMayorista.CondicionPago, "")
            CType(rpt.ReportDefinition.ReportObjects("txtClienteNombre"), TextObject).Text = ClienteMayorista.Nombre
            CType(rpt.ReportDefinition.ReportObjects("txtClienteDireccion"), TextObject).Text = If(ClienteMayorista.DomicilioFacturacion IsNot Nothing, ClienteMayorista.DomicilioFacturacion.ToString(), "")
            CType(rpt.ReportDefinition.ReportObjects("txtClienteTelefono"), TextObject).Text = If(ClienteMayorista.DomicilioFacturacion IsNot Nothing, ClienteMayorista.DomicilioFacturacion.Telefono, "")
            CType(rpt.ReportDefinition.ReportObjects("txtClienteTrasporte"), TextObject).Text = If(ClienteMayorista.Transporte?.Domicilio IsNot Nothing, ClienteMayorista.Transporte?.Domicilio.ToString(), "")
        Else
            CType(rpt.ReportDefinition.ReportObjects("txtClienteCUIT"), TextObject).Text = ""
            CType(rpt.ReportDefinition.ReportObjects("txtClienteCondicion"), TextObject).Text = "Efectivo"
            CType(rpt.ReportDefinition.ReportObjects("txtClienteNombre"), TextObject).Text = If(NotaPedido.ClienteMinorista?.ApellidoYNombre IsNot Nothing, NotaPedido.ClienteMinorista.ApellidoYNombre, "")
            CType(rpt.ReportDefinition.ReportObjects("txtClienteDireccion"), TextObject).Text = If(NotaPedido.ClienteMinorista?.Direccion IsNot Nothing, NotaPedido.ClienteMinorista.Direccion, "")
            CType(rpt.ReportDefinition.ReportObjects("txtClienteTelefono"), TextObject).Text = If(NotaPedido.ClienteMinorista?.Telefono IsNot Nothing, NotaPedido.ClienteMinorista.Telefono, "")
            CType(rpt.ReportDefinition.ReportObjects("txtClienteTrasporte"), TextObject).Text = ""
        End If

        CType(rpt.ReportDefinition.ReportObjects("TxtSubTotal"), TextObject).Text = If(ocutarMontos, "", subTotal.ToString("C"))
        CType(rpt.ReportDefinition.ReportObjects("TxtDescuento"), TextObject).Text = If(ocutarMontos, "", descuento.ToString("C"))
        CType(rpt.ReportDefinition.ReportObjects("TxtSubTotalConDescuento"), TextObject).Text = If(ocutarMontos, "", subTotalConDescuento.ToString("C"))
        CType(rpt.ReportDefinition.ReportObjects("txtIva"), TextObject).Text = If(ocutarMontos, "", iva.ToString("C"))
        CType(rpt.ReportDefinition.ReportObjects("TxtTotal"), TextObject).Text = If(ocutarMontos, "", total.ToString("C"))

        CrViewer.ReportSource = rpt
        CrViewer.Refresh()
    End Sub

    Private Sub InicializarNotaPedidoItemsTable(ByRef dtTrasnasccionItems As DataTable, ocutarMontos As Boolean)
        dtTrasnasccionItems = ds.Tables.Add("NotaPedido")
        dtTrasnasccionItems.Columns.Add("Codigo", Type.GetType("System.String"))
        dtTrasnasccionItems.Columns.Add("Nombre", Type.GetType("System.String"))
        dtTrasnasccionItems.Columns.Add("Cantidad", Type.GetType("System.Double"))

        dtTrasnasccionItems.Columns("Cantidad").DefaultValue = 0

        If Not ocutarMontos Then
            dtTrasnasccionItems.Columns.Add("Monto", Type.GetType("System.Double"))
            dtTrasnasccionItems.Columns.Add("SubTotal", Type.GetType("System.Double"))

            dtTrasnasccionItems.Columns("Monto").DefaultValue = 0
            dtTrasnasccionItems.Columns("SubTotal").DefaultValue = 0
        End If

    End Sub

    Private Sub AgregarRowNotaPedidoItems(transaccionItem As TransaccionItem, ocutarMontos As Boolean)
        Dim dr As DataRow = dtNotaPedidoItems.NewRow()
        dr(0) = transaccionItem.Producto.Codigo
        dr(1) = transaccionItem.Producto.Nombre
        dr(2) = transaccionItem.Cantidad

        If Not ocutarMontos Then
            dr(3) = transaccionItem.MontoProducto.Valor
            dr(4) = transaccionItem.Total.Valor
        End If

        dtNotaPedidoItems.Rows.Add(dr)
    End Sub

    Private Function CalcularDescuentoMayorista(items As List(Of NotaPedidoItem)) As Double
        Dim descuento As Double = 0
        For Each item As TransaccionItem In items
            descuento += Monto.Redondeo(item.Total.Valor * item.PorcentajeBonificacion)
        Next
        Return descuento
    End Function

    Private Function CalcularIVAMayorista(items As List(Of NotaPedidoItem)) As Double
        Dim iva As Double = 0
        For Each item As TransaccionItem In items
            iva += Monto.Redondeo(item.Total.Iva * (1 - item.PorcentajeBonificacion))
        Next
        Return iva
    End Function
End Class