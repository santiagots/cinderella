Imports CrystalDecisions.CrystalReports.Engine
Imports Entidades
Imports Negocio

Public Class frmReporteResumenVenta

    Public idVenta As Int64
    Private ds As New DataSet
    Private dt As New DataTable

    Private Sub frmReporteResumenVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt = ds.Tables.Add("venta")
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

        Dim negVenta As NegVentas = New NegVentas()
        Dim negEmpleados As NegEmpleados = New NegEmpleados()
        Dim negClienteMayorista As NegClienteMayorista = New NegClienteMayorista()
        Dim negProductos As NegProductos = New NegProductos()
        Dim negTipoPago As NegTipoPago = New NegTipoPago()

        Dim dsVentas As DataSet = negVenta.TraerVenta(idVenta)
        Dim id_ListaPrecio As Integer = CType(dsVentas.Tables(0).Rows(0).Item("id_ListaPrecio").ToString, Integer)
        Dim tipoPago As String = dsVentas.Tables(0).Rows(0).Item("TiposPago").ToString
        Dim tiposVenta As String = dsVentas.Tables(0).Rows(0).Item("TiposVenta").ToString
        Dim id_Empleado As Integer = CType(dsVentas.Tables(0).Rows(0).Item("id_Empleado").ToString, Integer)
        Dim numero As String = dsVentas.Tables(0).Rows(0).Item("Numero").ToString
        Dim razonSocial As String = dsVentas.Tables(0).Rows(0).Item("RazonSocial").ToString
        Dim fecha As String = dsVentas.Tables(0).Rows(0).Item("Fecha").ToString
        Dim subTotal As Double = CType(dsVentas.Tables(0).Rows(0).Item("Subtotal").ToString, Double)
        Dim descuento As Double = CType(dsVentas.Tables(0).Rows(0).Item("Descuento").ToString, Double)
        Dim costoFinanciero As Double = CType(dsVentas.Tables(0).Rows(0).Item("CostoFinanciero").ToString, Double)
        Dim precioTotal As Double = CType(dsVentas.Tables(0).Rows(0).Item("Precio_Total").ToString, Double)


        Dim dsventaDetalles As DataSet = negVenta.TraerVentaDetalle(idVenta)

        For Each ventaDetalle In dsventaDetalles.Tables(0).Rows

            Dim entProducto As Entidades.Productos = negProductos.TraerProducto(ventaDetalle.item("id_Producto"))

            AgregarItemATabla(entProducto, ventaDetalle.item("Cantidad"), ventaDetalle.item("Precio"), ventaDetalle.item("Iva"), ventaDetalle.item("Monto"))
        Next

        Dim empleado As Empleados = negEmpleados.TraerEmpleadoPorIdEmpleado(id_Empleado)

        Dim rpt As ReporteResumenVenta = New ReporteResumenVenta

        rpt.SetDataSource(ds.Tables("venta"))

        CType(rpt.ReportDefinition.ReportObjects("txtSucursal"), TextObject).Text = My.Settings("NombreSucursal")
        CType(rpt.ReportDefinition.ReportObjects("txtNombreVendedor"), TextObject).Text = $"{empleado.Apellido}, {empleado.Nombre}"
        CType(rpt.ReportDefinition.ReportObjects("txtNombreCliente"), TextObject).Text = razonSocial
        CType(rpt.ReportDefinition.ReportObjects("txtTipoVenta"), TextObject).Text = tiposVenta
        CType(rpt.ReportDefinition.ReportObjects("txtNumero"), TextObject).Text = numero
        CType(rpt.ReportDefinition.ReportObjects("txtFecha"), TextObject).Text = fecha
        CType(rpt.ReportDefinition.ReportObjects("txtFormaPago"), TextObject).Text = tipoPago
        CType(rpt.ReportDefinition.ReportObjects("TxtSubTotal"), TextObject).Text = subTotal.ToString("C2")
        CType(rpt.ReportDefinition.ReportObjects("TxtDescuento"), TextObject).Text = descuento.ToString("C2")
        CType(rpt.ReportDefinition.ReportObjects("TxtCostoFinanciero"), TextObject).Text = costoFinanciero.ToString("C2")
        CType(rpt.ReportDefinition.ReportObjects("TxtIVA"), TextObject).Text = If(tiposVenta.ToUpper() = "MINORISTA", 0.ToString("C2"), (subTotal * 0.21).ToString("C2"))
        CType(rpt.ReportDefinition.ReportObjects("TxtTotal"), TextObject).Text = precioTotal.ToString("C2")

        CrViewer.ReportSource = rpt
        CrViewer.Refresh()
    End Sub

    Private Sub AgregarItemATabla(entProducto As Productos, cantidad As Integer, precio As Double, iva As Double, monto As Double)
        AgregarRow(entProducto, cantidad, precio, iva, monto)
    End Sub

    Private Sub AgregarRow(entProducto As Productos, cantidad As Integer, Precio As Double, Iva As Double, monto As Double)
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

End Class