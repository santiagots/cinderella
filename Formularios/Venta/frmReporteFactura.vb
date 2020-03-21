Imports CrystalDecisions.CrystalReports.Engine
Imports Ventas.Core.Model.BaseAgreggate
Imports Ventas.Core.Model.ValueObjects
Imports Ventas.Core.Model.VentaAggregate
Imports Common.Core.Model
Imports Common.Core.Enum

Public Class frmReporteFactura

    Private TipoDocumentoFiscal As TipoDocumentoFiscal
    Private Venta As Venta
    Private ds As New DataSet
    Private dtProductos As New DataTable
    Private dtIVAs As New DataTable

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Sub New(idVenta As Long, tipoDocumentoFiscal As TipoDocumentoFiscal)
        Me.New
        Me.Venta = Comunes.Servicio.ObtenerVenta(idVenta)
        Me.TipoDocumentoFiscal = tipoDocumentoFiscal
    End Sub

    Sub New(venta As Venta, tipoDocumentoFiscal As TipoDocumentoFiscal)
        Me.New
        Me.Venta = venta
        Me.TipoDocumentoFiscal = tipoDocumentoFiscal
    End Sub

    Private Sub frmReporteResumenVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt = New ReporteFactura
        Dim total As Decimal = 0

        InicializarTransaccionItemsTable(dtProductos)
        total += CargarProductos()
        rpt.Database.Tables("TransaccionItem").SetDataSource(dtProductos)

        If (Venta.TipoCliente = TipoCliente.Mayorista) Then
            InicializarIVAsTable(dtIVAs)
            total += CargarIVAs(Venta.VentaItems)
            rpt.Database.Tables("Iva").SetDataSource(dtIVAs)
        Else
            CType(rpt.Subreports(1).ReportDefinition.ReportObjects("lblTotalNeto"), TextObject).ObjectFormat.EnableSuppress = True
            CType(rpt.Subreports(1).ReportDefinition.ReportObjects("txtTotalNeto"), FieldObject).ObjectFormat.EnableSuppress = True
            rpt.ReportDefinition.Sections("IvaSection").SectionFormat.EnableSuppress = True
        End If

        Dim codigoFactura As String = ObtenerIdentificadorFactura()

        CType(rpt.ReportDefinition.ReportObjects("txtTipoFactura"), TextObject).Text = ObtenerLetraFactura()
        CType(rpt.ReportDefinition.ReportObjects("txtCodigoTipoFactura"), TextObject).Text = $"Cod. {ObtenerCodigoFactura()}"
        CType(rpt.ReportDefinition.ReportObjects("txtNombreFactura"), TextObject).Text = ObtenerNombreFactura(TipoDocumentoFiscal)

        CType(rpt.ReportDefinition.ReportObjects("txtFacturaNombreFantasia"), TextObject).Text = My.Settings.DatosFiscalNombreFantasia
        CType(rpt.ReportDefinition.ReportObjects("txtFacturaNombreFantasia"), TextObject).ApplyFont(My.Settings.DatosFiscalNombreFantasiaFuente)
        CType(rpt.ReportDefinition.ReportObjects("txtFacturaRasonSocial"), TextObject).Text = My.Settings.DatosFiscalRazonSocial
        CType(rpt.ReportDefinition.ReportObjects("txtFaturaDireccion"), TextObject).Text = My.Settings.DatosFiscalDireccion
        CType(rpt.ReportDefinition.ReportObjects("txtFacturaTelefono"), TextObject).Text = My.Settings.DatosFiscalTel
        CType(rpt.ReportDefinition.ReportObjects("txtFacturaEmail"), TextObject).Text = My.Settings.DatosFiscalEmail

        CType(rpt.ReportDefinition.ReportObjects("txtNumeroFactura"), TextObject).Text = ObtenerNumeroFactura()
        CType(rpt.ReportDefinition.ReportObjects("txtFechaEmision"), TextObject).Text = Venta.Factura.Fecha.ToString("dd/MM/yyyy")
        CType(rpt.ReportDefinition.ReportObjects("txtFacturaCuit"), TextObject).Text = My.Settings.DatosFiscalCUIT
        CType(rpt.ReportDefinition.ReportObjects("txtFacturaIIBB"), TextObject).Text = My.Settings.DatosFiscalIIBB
        CType(rpt.ReportDefinition.ReportObjects("txtInicioActividad"), TextObject).Text = My.Settings.DatosFiscalInicioActividad.ToString("dd/MM/yyyy")

        CType(rpt.ReportDefinition.ReportObjects("txtClienteNombre"), TextObject).Text = If(TipoDocumentoFiscal = TipoDocumentoFiscal.Factura, Venta.Factura.NombreYApellido, Venta.NotaCredito.NombreYApellido)
        CType(rpt.ReportDefinition.ReportObjects("txtClienteDNI"), TextObject).Text = If(TipoDocumentoFiscal = TipoDocumentoFiscal.Factura, Venta.Factura.CUIT, Venta.NotaCredito.CUIT)
        CType(rpt.ReportDefinition.ReportObjects("txtClienteDomicilio"), TextObject).Text = If(TipoDocumentoFiscal = TipoDocumentoFiscal.Factura, $"{Venta.Factura.Direccion} - {Venta.Factura.Localidad}", $"{Venta.NotaCredito.Direccion} - {Venta.NotaCredito.Localidad}")
        CType(rpt.ReportDefinition.ReportObjects("txtClienteCondicionIva"), TextObject).Text = If(TipoDocumentoFiscal = TipoDocumentoFiscal.Factura, Venta.Factura.CondicionIVA.ToString(), Venta.NotaCredito.CondicionIVA.ToString())

        If TipoDocumentoFiscal = TipoDocumentoFiscal.NotaCredito Then
            CType(rpt.ReportDefinition.ReportObjects("txtComprobanteOriginal"), TextObject).Text = $"{Venta.Factura.PuntoVenta.ToString().PadLeft(4, "0")} - {Venta.Factura.NumeroFactura.First().Numero.ToString().PadLeft(8, "0")}"
        Else
            CType(rpt.ReportDefinition.ReportObjects("lblComprobanteOriginal"), TextObject).ObjectFormat.EnableSuppress = True
            CType(rpt.ReportDefinition.ReportObjects("txtComprobanteOriginal"), TextObject).ObjectFormat.EnableSuppress = True
        End If

        CType(rpt.ReportDefinition.ReportObjects("txtCodigoBarras"), TextObject).Text = codigoFactura
        CType(rpt.ReportDefinition.ReportObjects("txtIdentificadorFactura"), TextObject).Text = codigoFactura
        CType(rpt.ReportDefinition.ReportObjects("txtCAE"), TextObject).Text = If(TipoDocumentoFiscal = TipoDocumentoFiscal.Factura, Venta.Factura.CAE, Venta.NotaCredito.CAE)
        CType(rpt.ReportDefinition.ReportObjects("txtVencimientoCAE"), TextObject).Text = If(TipoDocumentoFiscal = TipoDocumentoFiscal.Factura, Venta.Factura.FechaVencimientoCAE?.ToString("dd/MM/yyyy"), Venta.NotaCredito.FechaVencimientoCAE?.ToString("dd/MM/yyyy"))

        CType(rpt.ReportDefinition.ReportObjects("txtTotal"), TextObject).Text = total.ToString("C2")

        CrViewer.ReportSource = rpt
        CrViewer.Refresh()
    End Sub

    Private Function CargarIVAs(VentasItem As IEnumerable(Of VentaItem)) As Decimal
        Dim gruposIVAs As List(Of IGrouping(Of IVA, VentaItem)) = VentasItem.GroupBy(Function(x) x.Producto.SubCategoria.IVA).ToList()
        Dim IVATotal As Decimal = 0

        For Each item As IGrouping(Of IVA, VentaItem) In gruposIVAs
            Dim decuento As Decimal = item.Sum(Function(x) x.TotalDescuento(Venta.PorcentajeFacturacion, Venta.TipoCliente))
            Dim cft As Decimal = item.Sum(Function(x) x.TotalCFT(Venta.PorcentajeFacturacion, Venta.TipoCliente))
            Dim total As Decimal = item.Select(Function(x) x.Total.Valor).Aggregate(Function(x, y) x + y)
            Dim monto As Decimal = total - decuento + cft

            Dim montoFinal As MontoProducto = New MontoProducto(monto, monto * item.Key.Valor)

            IVATotal += AgregarRowPagos(montoFinal, item.Key)
        Next

        Return IVATotal
    End Function

    Private Function CargarProductos() As Decimal
        Dim MontoTotal As Decimal = 0

        For Each item As VentaItem In Venta.VentaItems
            MontoTotal += CargarProducto(item)
            MontoTotal += CargarProductoDescuento(item)
            MontoTotal += CargarProductoRecargo(item)
        Next

        Return MontoTotal
    End Function

    Private Function CargarProducto(item As VentaItem) As Decimal
        If Venta.TipoCliente = Common.Core.Enum.TipoCliente.Minorista Then
            Return AgregarRowTransaccionItems(item.Producto.Codigo, item.Producto.Nombre, item.Cantidad, item.MontoProducto.toDecimal(), 0)
        Else
            Return AgregarRowTransaccionItems(item.Producto.Codigo, item.Producto.Nombre, item.Cantidad, item.MontoProducto.Valor, item.Producto.SubCategoria.IVA.Valor)
        End If
    End Function

    Private Function CargarProductoDescuento(item As VentaItem) As Decimal
        Dim productoDescuento As Decimal = item.TotalDescuento(Venta.PorcentajeFacturacion, Venta.TipoCliente)
        If (productoDescuento = 0) Then
            Return 0
        End If

        If Venta.TipoCliente = Common.Core.Enum.TipoCliente.Minorista Then
            Return AgregarRowTransaccionItems(item.Producto.Codigo, $"DESCUENTO", 1, -productoDescuento, 0)
        Else
            Return AgregarRowTransaccionItems(item.Producto.Codigo, $"DESCUENTO", 1, -productoDescuento, 0)
        End If
    End Function

    Private Function CargarProductoRecargo(item As VentaItem) As Decimal
        Dim productoRecargo As Decimal = item.TotalCFT(Venta.PorcentajeFacturacion, Venta.TipoCliente)
        If (productoRecargo = 0) Then
            Return 0
        End If

        If Venta.TipoCliente = Common.Core.Enum.TipoCliente.Minorista Then
            Return AgregarRowTransaccionItems(item.Producto.Codigo, $"RECARGO", 1, productoRecargo, 0)
        Else
            Return AgregarRowTransaccionItems(item.Producto.Codigo, $"RECARGO", 1, productoRecargo, 0)
        End If
    End Function

    Private Sub InicializarIVAsTable(ByRef dtPagos As DataTable)
        dtPagos = ds.Tables.Add("Iva")
        dtPagos.Columns.Add("Subtotal", Type.GetType("System.Double"))
        dtPagos.Columns.Add("Porcentaje", Type.GetType("System.Double"))
        dtPagos.Columns.Add("TotalIva", Type.GetType("System.Double"))

        dtPagos.Columns("Subtotal").DefaultValue = 0
        dtPagos.Columns("Porcentaje").DefaultValue = 0
        dtPagos.Columns("TotalIva").DefaultValue = 0
    End Sub

    Private Sub InicializarTransaccionItemsTable(ByRef dtTrasnasccionItems As DataTable)
        dtTrasnasccionItems = ds.Tables.Add("TransaccionItems")
        dtTrasnasccionItems.Columns.Add("Codigo", Type.GetType("System.String"))
        dtTrasnasccionItems.Columns.Add("Nombre", Type.GetType("System.String"))
        dtTrasnasccionItems.Columns.Add("Cantidad", Type.GetType("System.Double"))
        dtTrasnasccionItems.Columns.Add("Iva", Type.GetType("System.Double"))
        dtTrasnasccionItems.Columns.Add("Monto", Type.GetType("System.Double"))
        dtTrasnasccionItems.Columns.Add("SubTotal", Type.GetType("System.Double"))

        dtTrasnasccionItems.Columns("Cantidad").DefaultValue = 0
        dtTrasnasccionItems.Columns("Iva").DefaultValue = 0
        dtTrasnasccionItems.Columns("Monto").DefaultValue = 0
        dtTrasnasccionItems.Columns("SubTotal").DefaultValue = 0
    End Sub

    Private Function AgregarRowTransaccionItems(codigo As String, nombre As String, cantidad As Integer, Precio As Double, Iva As Double) As Decimal
        Dim dr As DataRow = dtProductos.NewRow()
        dr(0) = codigo
        dr(1) = nombre
        dr(2) = cantidad
        dr(3) = Iva
        dr(4) = Precio * Venta.PorcentajeFacturacion
        dr(5) = (Precio * cantidad) * Venta.PorcentajeFacturacion

        dtProductos.Rows.Add(dr)
        Return dr(5)
    End Function

    Private Function AgregarRowPagos(montoProducto As MontoProducto, iva As IVA) As Decimal
        Dim dr As DataRow = dtIVAs.NewRow()
        dr(0) = montoProducto.Valor * Venta.PorcentajeFacturacion
        dr(1) = iva.Valor
        dr(2) = montoProducto.Iva * Venta.PorcentajeFacturacion

        dtIVAs.Rows.Add(dr)
        Return dr(2)
    End Function

    Private Function ObtenerLetraFactura() As String
        Dim condicionIVA As CondicionIVA = If(TipoDocumentoFiscal = TipoDocumentoFiscal.NotaCredito, Venta.NotaCredito.CondicionIVA, Venta.Factura.CondicionIVA)

        If (condicionIVA = CondicionIVA.Consumidor_Final) Then
            Return "B"
        Else
            Return "A"
        End If
    End Function

    Private Function ObtenerNombreFactura(tipoDocumentoFiscal As TipoDocumentoFiscal) As String
        If (tipoDocumentoFiscal = TipoDocumentoFiscal.Factura) Then
            Return "Factura"
        Else
            Return "Nota de Crédito"
        End If
    End Function

    Private Function ObtenerCodigoFactura() As String
        Dim condicionIVA As CondicionIVA = If(TipoDocumentoFiscal = TipoDocumentoFiscal.NotaCredito, Venta.NotaCredito.CondicionIVA, Venta.Factura.CondicionIVA)

        If TipoDocumentoFiscal = TipoDocumentoFiscal.Factura Then
            If condicionIVA = CondicionIVA.Consumidor_Final Then
                Return "06"
            Else
                Return "01"
            End If
        Else
            If condicionIVA = CondicionIVA.Consumidor_Final Then
                Return "08"
            Else
                Return "03"
            End If
        End If
    End Function

    Private Function ObtenerNumeroFactura() As String
        If (TipoDocumentoFiscal = TipoDocumentoFiscal.Factura) Then
            Return $"{Venta.Factura.PuntoVenta.ToString().PadLeft(4, "0")} - {Venta.Factura.NumeroFactura.First().Numero.ToString().PadLeft(8, "0")}"
        Else
            Return $"{Venta.NotaCredito.PuntoVenta.ToString().PadLeft(4, "0")} - {Venta.NotaCredito.NumeroNotaCredito.First().Numero.ToString().PadLeft(8, "0")}"
        End If
    End Function

    Private Function ObtenerIdentificadorFactura() As String
        Dim cuitEmisor As String = My.Settings.DatosFiscalCUIT
        Dim puntoVenta As String = My.Settings.PuntoVentaFacturacionElectronica
        Dim codigoTipoFactura As String = ObtenerCodigoFactura()
        Dim Cae As String = If(TipoDocumentoFiscal = TipoDocumentoFiscal.NotaCredito, Venta.NotaCredito.CAE, Venta.Factura.CAE)
        Dim fechaVencimientoCae As Date = If(TipoDocumentoFiscal = TipoDocumentoFiscal.NotaCredito, Venta.NotaCredito.FechaVencimientoCAE, Venta.Factura.FechaVencimientoCAE)

        Dim codigoFactura As String = $"{cuitEmisor}{codigoTipoFactura}{puntoVenta}{Cae}{fechaVencimientoCae.ToString("yyyyMMdd")}"
        Dim codigoFacturaSoloNumeros As String = ObtenerSoloNumeros(codigoFactura)
        Dim digitoFerificador As String = ObtenerDigitoVerificador(codigoFacturaSoloNumeros)
        Return $"{codigoFacturaSoloNumeros}{digitoFerificador}"
    End Function

    Private Function ObtenerSoloNumeros(texto As String)
        Dim textoSoloNumeros As String = ""

        For Each caracter As Char In texto.ToCharArray()
            If Char.IsDigit(caracter) Then
                textoSoloNumeros += caracter
            End If
        Next

        Return textoSoloNumeros
    End Function

    Private Function ObtenerDigitoVerificador(facturaCodigo As String) As String
        Dim digitosCodigo As Char() = facturaCodigo.ToCharArray()
        Dim sumaPar As Integer = 0
        Dim sumaInpar As Integer = 0
        For i = 0 To digitosCodigo.Length - 1
            If ((i + 1) Mod 2 = 0) Then
                sumaPar += Integer.Parse(digitosCodigo(i))
            Else
                sumaInpar += Integer.Parse(digitosCodigo(i))
            End If
        Next
        Dim total As Integer = (sumaInpar * 3) + sumaPar
        Return (10 - (total Mod 10)).ToString()
    End Function


End Class