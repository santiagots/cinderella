Imports CrystalDecisions.CrystalReports.Engine
Imports Entidades
Imports Negocio

Public Class frmReportePresupuesto

    Public presupuesto As Presupuesto
    Private ds As New DataSet
    Private dt As New DataTable

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

        Dim negPresupuesto As NegPresupuesto = New NegPresupuesto()
        Dim negProductos As NegProductos = New NegProductos()

        Dim presupuestoDetalles As List(Of Presupuesto_Detalle) = negPresupuesto.TraerDetalle(presupuesto.id_Presupuesto)

        Dim SubTotal As Double = 0

        For Each detalle As Presupuesto_Detalle In presupuestoDetalles

            Dim entProducto As Entidades.Productos = negProductos.TraerProducto(detalle.id_Producto)

            SubTotal += detalle.Precio * detalle.Cantidad

            AgregarItemATabla(entProducto, detalle.Cantidad, detalle.Precio, presupuesto.id_TipoVenta, presupuesto.id_ListaPrecio)
        Next

        Dim rpt As ReportePresupuesto = New ReportePresupuesto

        rpt.SetDataSource(ds.Tables("Presupuesto"))

        CType(rpt.ReportDefinition.ReportObjects("txtSucursal"), TextObject).Text = My.Settings("NombreSucursal")
        CType(rpt.ReportDefinition.ReportObjects("txtNombreVendedor"), TextObject).Text = presupuesto.VendedorNombreyApellido
        CType(rpt.ReportDefinition.ReportObjects("txtNombreCliente"), TextObject).Text = presupuesto.RazonSocialClienteMayorista
        CType(rpt.ReportDefinition.ReportObjects("txtTipoVenta"), TextObject).Text = If(presupuesto.id_TipoVenta = 1, "Minorista", "Mayorista")
        CType(rpt.ReportDefinition.ReportObjects("txtNumero"), TextObject).Text = presupuesto.id_Presupuesto
        CType(rpt.ReportDefinition.ReportObjects("txtFecha"), TextObject).Text = presupuesto.Fecha
        CType(rpt.ReportDefinition.ReportObjects("txtFormaPago"), TextObject).Text = presupuesto.DescripcionTipoPago
        CType(rpt.ReportDefinition.ReportObjects("TxtSubTotal"), TextObject).Text = presupuesto.SubTotal.ToString("C2")
        CType(rpt.ReportDefinition.ReportObjects("TxtDescuento"), TextObject).Text = presupuesto.Descuento.ToString("C2")
        CType(rpt.ReportDefinition.ReportObjects("TxtCostoFinanciero"), TextObject).Text = presupuesto.CostoFinanciero.ToString("C2")
        CType(rpt.ReportDefinition.ReportObjects("TxtTotal"), TextObject).Text = presupuesto.Total.ToString("C2")

        If (presupuesto.Anulado) Then
            CType(rpt.ReportDefinition.ReportObjects("TxtDescipcionAnulado"), TextObject).Text = String.Format("PRESUPUESTO ANULADO{0}MOTIVO: {1}{0}FECHA: {2}", Environment.NewLine, presupuesto.DescripcionAnulado, presupuesto.FechaAnulado)
        End If


        CrViewer.ReportSource = rpt
        CrViewer.Refresh()
    End Sub

    Private Sub AgregarItemATabla(entProducto As Productos, cantidad As Integer, precio As Double, tipoCliente As Integer, listaPrecio As Integer)
        If tipoCliente = 1 Then
            AgregarRow(entProducto, cantidad, 0, 0, precio)
        Else
            If (listaPrecio = 5) Then 'MayoristaSinFactura
                AgregarRow(entProducto, cantidad, precio, 0, precio)
            Else
                AgregarRow(entProducto, cantidad, precio / 1.21, (precio / 1.21) * 0.21, precio)
            End If
        End If
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