Imports CrystalDecisions.CrystalReports.Engine
Imports Entidades
Imports Negocio

Public Class frmReporteNotaPedido

    Public notaPedido As NotaPedido
    Private ds As New DataSet
    Private  dt As New DataTable

    Private Sub frmReporteNotaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt = ds.Tables.Add("NotaPedido")
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

        Dim negNotaPedido As NegNotaPedido = New NegNotaPedido()
        Dim negProductos As NegProductos = New NegProductos()

        Dim notaPedidoDetalles As List(Of NotaPedido_Detalle) = negNotaPedido.TraerDetalle(notaPedido.id_NotaPedido)

        Dim MontoTotal As Double = 0
        Dim SubTotal As Double = 0
        Dim Descuento As Double = 0
        Dim IVA As Double = 0

        For Each detalle As NotaPedido_Detalle In notaPedidoDetalles

            Dim entProducto As Entidades.Productos = negProductos.TraerProducto(detalle.id_Producto)

            If notaPedido.id_TipoVenta = 1 Then
                MontoTotal += detalle.Monto * detalle.Cantidad
                AgregarRow(entProducto, detalle.Cantidad, 0, 0, detalle.Monto)
            Else
                MontoTotal += detalle.Precio * detalle.Cantidad
                AgregarRow(entProducto, detalle.Cantidad, detalle.Precio, detalle.Iva, detalle.Monto)
            End If
        Next

        Descuento = MontoTotal * (notaPedido.PorcentajeDescuento / 100)
        SubTotal = MontoTotal - Descuento

        Dim rpt
        If notaPedido.id_TipoVenta = 1 Then
            rpt = New ReporteNotaPedidoMinorista
        Else
            rpt = New ReporteNotaPedidoMayorista
            IVA = SubTotal * 0.21
            CType(rpt.ReportDefinition.ReportObjects("TxtIva"), TextObject).Text = IVA.ToString("C2")
        End If

        rpt.SetDataSource(ds.Tables("NotaPedido"))
        CType(rpt.ReportDefinition.ReportObjects("txtRazonSocial"), TextObject).Text = My.Settings.RazonSocial
        CType(rpt.ReportDefinition.ReportObjects("txtSucursal"), TextObject).Text = My.Settings.NombreSucursal
        CType(rpt.ReportDefinition.ReportObjects("txtNumero"), TextObject).Text = notaPedido.id_NotaPedido
        CType(rpt.ReportDefinition.ReportObjects("txtEstado"), TextObject).Text = If(notaPedido.Vendida, "Cerrada", "Abrierta")
        CType(rpt.ReportDefinition.ReportObjects("txtTipoVenta"), TextObject).Text = notaPedido.TipoVentaDescripcion
        CType(rpt.ReportDefinition.ReportObjects("txtNombreVendedor"), TextObject).Text = notaPedido.EmpleadoNombreyApellido
        CType(rpt.ReportDefinition.ReportObjects("txtNombreCliente"), TextObject).Text = If(notaPedido.id_Cliente > 0, notaPedido.RazonSocialCliente, notaPedido.ConsumidorFinalNombreYApellido)
        CType(rpt.ReportDefinition.ReportObjects("txtFecha"), TextObject).Text = notaPedido.Fecha
        CType(rpt.ReportDefinition.ReportObjects("TxtSubTotal"), TextObject).Text = SubTotal.ToString("C2")
        CType(rpt.ReportDefinition.ReportObjects("TxtDescuento"), TextObject).Text = Descuento.ToString("C2")
        CType(rpt.ReportDefinition.ReportObjects("TxtTotal"), TextObject).Text = (MontoTotal - Descuento + IVA).ToString("C2")

        CrViewer.ReportSource = rpt
        CrViewer.Refresh()
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