Imports CrystalDecisions.CrystalReports.Engine
Imports Entidades
Imports Negocio
Imports Ventas.Core.Model.BaseAgreggate
Imports Ventas.Core.Model.ValueObjects
Imports Ventas.Core.Model.VentaAggregate

Public Class frmReporteResumenReserva

    Private Titulo As String
    Private Numero As String
    Private TipoCliente As TipoCliente
    Private Vendedor As String
    Private Cliente As String
    Private Fechas As DateTime
    Private TransaccionItems As IEnumerable(Of TransaccionItem)
    Private Pagos As IEnumerable(Of Pago)
    Private ds As New DataSet
    Private dtTrasnasccionItems As New DataTable
    Private dtPagos As New DataTable

    Sub New(titulo As String, numero As String, tipoCliente As TipoCliente, vendedor As String, cliente As String, fecha As DateTime, transaccionItems As IEnumerable(Of TransaccionItem), Pagos As IEnumerable(Of Pago))

        ' This call is required by the designer.
        InitializeComponent()

        Me.Titulo = If(String.IsNullOrEmpty(titulo), String.Empty, titulo)
        Me.Numero = If(String.IsNullOrEmpty(numero), String.Empty, numero)
        Me.TipoCliente = tipoCliente
        Me.Vendedor = If(String.IsNullOrEmpty(vendedor), String.Empty, vendedor)
        Me.Cliente = If(String.IsNullOrEmpty(cliente), String.Empty, cliente)
        Me.Fechas = fecha
        Me.TransaccionItems = transaccionItems
        Me.Pagos = Pagos
    End Sub

    Private Sub frmReporteResumenVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt = New ReporteTransaccion

        InicializarTransaccionItemsTable(dtTrasnasccionItems)
        CargarTransaccionItems(TransaccionItems)

        InicializarPagosTable(dtPagos)
        If (Pagos IsNot Nothing) Then
            CargarPagos(Pagos)
        Else
            rpt.ReportDefinition.Sections("PagosSection").SectionFormat.EnableSuppress = True
        End If

        rpt.Database.Tables("TransaccionItem").SetDataSource(dtTrasnasccionItems)
        rpt.Database.Tables("Pago").SetDataSource(dtPagos)

        CType(rpt.ReportDefinition.ReportObjects("txtRazonSocial"), TextObject).Text = My.Settings.RazonSocial
        CType(rpt.ReportDefinition.ReportObjects("txtTitulo"), TextObject).Text = Titulo
        CType(rpt.ReportDefinition.ReportObjects("txtSucursal"), TextObject).Text = My.Settings.NombreSucursal
        CType(rpt.ReportDefinition.ReportObjects("txtNumero"), TextObject).Text = Numero
        CType(rpt.ReportDefinition.ReportObjects("txtTipoVenta"), TextObject).Text = TipoCliente.ToString()
        CType(rpt.ReportDefinition.ReportObjects("txtNombreVendedor"), TextObject).Text = Vendedor
        CType(rpt.ReportDefinition.ReportObjects("txtNombreCliente"), TextObject).Text = Cliente
        CType(rpt.ReportDefinition.ReportObjects("txtFecha"), TextObject).Text = Fechas.ToString("yyyy/MM/dd hh:mm:ss")

        CrViewer.ReportSource = rpt
        CrViewer.Refresh()
    End Sub

    Private Sub CargarPagos(Pagos As IEnumerable(Of Pago))
        For Each pago As Pago In Pagos
            AgregarRowPagos(pago.ToString(), pago.MontoPago)
        Next
    End Sub

    Private Sub CargarTransaccionItems(TransaccionItems As IEnumerable(Of TransaccionItem))
        For Each item As TransaccionItem In TransaccionItems
            If TipoCliente = Common.Core.Enum.TipoCliente.Minorista Then
                AgregarRowTransaccionItems(item.CodigoProducto, item.NombreProducto, item.Cantidad, 0, 0, item.MontoProducto.toDecimal())
            Else
                AgregarRowTransaccionItems(item.CodigoProducto, item.NombreProducto, item.Cantidad, item.MontoProducto.Valor, item.MontoProducto.Iva, item.MontoProducto.toDecimal())
            End If
        Next
    End Sub

    Private Sub InicializarPagosTable(ByRef dtPagos As DataTable)
        dtPagos = ds.Tables.Add("Pago")
        dtPagos.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtPagos.Columns.Add("Subtotal", Type.GetType("System.Double"))
        dtPagos.Columns.Add("Descuento", Type.GetType("System.Double"))
        dtPagos.Columns.Add("CFT", Type.GetType("System.Double"))
        dtPagos.Columns.Add("IVA", Type.GetType("System.Double"))
        dtPagos.Columns.Add("Total", Type.GetType("System.Double"))

        dtPagos.Columns("Subtotal").DefaultValue = 0
        dtPagos.Columns("Descuento").DefaultValue = 0
        dtPagos.Columns("CFT").DefaultValue = 0
        dtPagos.Columns("IVA").DefaultValue = 0
        dtPagos.Columns("Total").DefaultValue = 0
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

    Private Sub AgregarRowTransaccionItems(codigo As String, nombre As String, cantidad As Integer, Precio As Double, Iva As Double, monto As Double)
        Dim dr As DataRow = dtTrasnasccionItems.NewRow()
        dr(0) = codigo
        dr(1) = nombre
        dr(2) = cantidad
        dr(3) = Precio
        dr(4) = Iva
        dr(5) = monto
        dr(6) = monto * cantidad

        dtTrasnasccionItems.Rows.Add(dr)
    End Sub

    Private Sub AgregarRowPagos(descripcion As String, montoPago As MontoPago)
        Dim dr As DataRow = dtPagos.NewRow()
        dr(0) = descripcion
        dr(1) = montoPago.Monto
        dr(2) = montoPago.Descuento
        dr(3) = montoPago.CFT
        dr(4) = montoPago.IVA
        dr(5) = montoPago.Total

        dtPagos.Rows.Add(dr)
    End Sub

End Class