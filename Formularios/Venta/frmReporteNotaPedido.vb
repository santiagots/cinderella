Imports CrystalDecisions.CrystalReports.Engine
Imports Negocio
Imports Ventas.Core.Model.NotaPedidoAgreggate

Public Class frmReporteNotaPedido

    Public notaPedido As NotaPedido
    Private ds As New DataSet
    Private dt As New DataTable

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

        Dim cliente As String

        For Each item As NotaPedidoItem In notaPedido.NotaPedidoItems
            If notaPedido.TipoCliente = Common.Core.Enum.TipoCliente.Minorista Then
                AgregarRow(item.Producto.Codigo, item.Producto.Nombre, item.Cantidad, 0, 0, item.MontoProducto.toDecimal())
            Else
                AgregarRow(item.Producto.Codigo, item.Producto.Nombre, item.Cantidad, item.MontoProducto.Valor, item.MontoProducto.Iva, item.MontoProducto.toDecimal())
            End If
        Next

        Dim rpt
        If notaPedido.TipoCliente = Common.Core.Enum.TipoCliente.Minorista Then
            rpt = New ReporteNotaPedidoMinorista
            cliente = notaPedido.ClienteMinorista.ApellidoYNombre
        Else
            rpt = New ReporteNotaPedidoMayorista
            cliente = notaPedido.ClienteMayorista.RazonSocial
            CType(rpt.ReportDefinition.ReportObjects("TxtIva"), TextObject).Text = notaPedido.MontoTotal.Iva.ToString("C2")
        End If

        rpt.SetDataSource(ds.Tables("NotaPedido"))
        CType(rpt.ReportDefinition.ReportObjects("txtRazonSocial"), TextObject).Text = My.Settings.RazonSocial
        CType(rpt.ReportDefinition.ReportObjects("txtSucursal"), TextObject).Text = My.Settings.NombreSucursal
        CType(rpt.ReportDefinition.ReportObjects("txtNumero"), TextObject).Text = notaPedido.Numero
        CType(rpt.ReportDefinition.ReportObjects("txtEstado"), TextObject).Text = notaPedido.Estado.ToString()
        CType(rpt.ReportDefinition.ReportObjects("txtTipoVenta"), TextObject).Text = notaPedido.TipoCliente.ToString()
        CType(rpt.ReportDefinition.ReportObjects("txtNombreVendedor"), TextObject).Text = notaPedido.Vendedor.ApellidoYNombre
        CType(rpt.ReportDefinition.ReportObjects("txtNombreCliente"), TextObject).Text = cliente
        CType(rpt.ReportDefinition.ReportObjects("txtFecha"), TextObject).Text = notaPedido.Fecha
        CType(rpt.ReportDefinition.ReportObjects("TxtSubTotal"), TextObject).Text = notaPedido.MontoTotal.Valor.ToString("C2")
        CType(rpt.ReportDefinition.ReportObjects("TxtDescuento"), TextObject).Text = 0.ToString("C2")
        CType(rpt.ReportDefinition.ReportObjects("TxtTotal"), TextObject).Text = notaPedido.MontoTotal.toDecimal().ToString("C2")

        CrViewer.ReportSource = rpt
        CrViewer.Refresh()
    End Sub

    Private Sub AgregarRow(codigo As String, nombre As String, cantidad As Integer, Precio As Double, Iva As Double, monto As Double)
        Dim dr As DataRow = dt.NewRow()
        dr(0) = codigo
        dr(1) = nombre
        dr(2) = cantidad
        dr(3) = Precio
        dr(4) = Iva
        dr(5) = monto
        dr(6) = monto * cantidad

        dt.Rows.Add(dr)
    End Sub
End Class