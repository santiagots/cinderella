Imports CrystalDecisions.CrystalReports.Engine
Imports Ventas.Core.Model.VentaAggregate
Imports Common.Core.Model
Imports Common.Core.Enum
Imports Common.Core.Helper
Imports Ventas.Data.Service
Imports QRCoder
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Reflection
Imports Ventas.Core.Model.BaseAgreggate
Imports Factura.Core.Enum
Imports Factura.Core.Helper
Imports Newtonsoft.Json
Imports Ventas.Core.Model.ValueObjects

Public Class frmReporteFactura

    Private Const CODIGO_FACTURA_A = "01"
    Private Const CODIGO_FACTURA_B = "06"
    Private Const CODIGO_NOTA_CREDITO_A = "03"
    Private Const CODIGO_NOTA_CREDITO_B = "08"

    Private Const LETRA_FACTURA_A = "A"
    Private Const LETRA_FACTURA_B = "B"

    Private Const LEYENDA_FACTURA = "Factura"
    Private Const LEYENDA_NOTA_CREDITO = "Nota Crédito"

    Private Const LEYENDA_MONOTRIBUTO = "El crédito fiscal discriminado en el presente comprobante, sólo podrá ser computado a efectos del Régimen de Sostenimiento e Inclusión Fiscal para Pequeños Contribuyentes de la Ley N 27.618"

    Private TipoCliente As TipoCliente
    Private TipoDocumentoFiscal As TipoDocumentoFiscal
    Private Venta As Venta
    Private ds As New DataSet
    Private dtProductos As New DataTable
    Private dtTotales As New DataTable

    Private RutaImagenCodigoQR As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "RQ.png")

    Private ReadOnly Property CondicionIva As CondicionIVA
        Get
            Return If(TipoDocumentoFiscal = TipoDocumentoFiscal.NotaCredito, Venta.NotaCredito.CondicionIVA, Venta.Factura.CondicionIVA)
        End Get
    End Property

    Private Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Sub New(idVenta As Long, tipoCliente As TipoCliente, tipoDocumentoFiscal As TipoDocumentoFiscal)
        Me.New
        Me.Venta = VentaService.Obtener(TipoBase.Local, idVenta)
        Me.TipoDocumentoFiscal = tipoDocumentoFiscal
        Me.TipoCliente = tipoCliente
    End Sub

    Sub New(venta As Venta, tipoDocumentoFiscal As TipoDocumentoFiscal)
        Me.New
        Me.Venta = venta
        Me.TipoDocumentoFiscal = tipoDocumentoFiscal
    End Sub

    Private Sub frmReporteResumenVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt = New ReporteFactura

        InicializarTransaccionItemsTable(dtProductos)
        InicializarTotalesTable(dtTotales)

        If (TipoDocumentoFiscal = TipoDocumentoFiscal.Factura) Then
            CargarProductosVenta()
            CargarTotalesVenta()
        Else
            CargarProductosNotaCredito()
            CargarTotalesNotaCredito()
        End If

        rpt.Database.Tables("TransaccionItem").SetDataSource(dtProductos)
            rpt.Database.Tables("Totales").SetDataSource(dtTotales)

            CType(rpt.ReportDefinition.ReportObjects("txtTipoFactura"), TextObject).Text = ObtenerLetraFactura()
            CType(rpt.ReportDefinition.ReportObjects("txtCodigoTipoFactura"), TextObject).Text = $"Cod. {ObtenerCodigoFactura()}"
            CType(rpt.ReportDefinition.ReportObjects("txtNombreFactura"), TextObject).Text = $"{ObtenerNombreFactura(TipoDocumentoFiscal)} Nro.: {ObtenerNumeroFactura()}"

            CType(rpt.ReportDefinition.ReportObjects("txtFacturaNombreFantasia"), TextObject).Text = My.Settings.DatosFiscalNombreFantasia
            CType(rpt.ReportDefinition.ReportObjects("txtFacturaNombreFantasia"), TextObject).ApplyFont(My.Settings.DatosFiscalNombreFantasiaFuente)
            CType(rpt.ReportDefinition.ReportObjects("txtFacturaRasonSocial"), TextObject).Text = My.Settings.DatosFiscalRazonSocial
            CType(rpt.ReportDefinition.ReportObjects("txtFaturaDireccion1"), TextObject).Text = My.Settings.DatosFiscalDireccion
            CType(rpt.ReportDefinition.ReportObjects("txtFaturaDireccion2"), TextObject).Text = My.Settings.DatosFiscalLocalidad
            CType(rpt.ReportDefinition.ReportObjects("txtFacturaTelefono"), TextObject).Text = My.Settings.DatosFiscalTel
            CType(rpt.ReportDefinition.ReportObjects("txtFacturaEmail"), TextObject).Text = My.Settings.DatosFiscalEmail

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

            If CondicionIva = CondicionIVA.Monotributo Then
                CType(rpt.ReportDefinition.ReportObjects("txtComantarios"), TextObject).Text = LEYENDA_MONOTRIBUTO
            End If

            CType(rpt.ReportDefinition.ReportObjects("txtCAE"), TextObject).Text = If(TipoDocumentoFiscal = TipoDocumentoFiscal.Factura, Venta.Factura.CAE, Venta.NotaCredito.CAE)
            CType(rpt.ReportDefinition.ReportObjects("txtVencimientoCAE"), TextObject).Text = If(TipoDocumentoFiscal = TipoDocumentoFiscal.Factura, Venta.Factura.FechaVencimientoCAE?.ToString("dd/MM/yyyy"), Venta.NotaCredito.FechaVencimientoCAE?.ToString("dd/MM/yyyy"))


            rpt.SetParameterValue("rutaImagen", GenerarQRFactura())

            CrViewer.ReportSource = rpt
            CrViewer.SelectionMode = SelectionMode.None
            CrViewer.Refresh()
    End Sub


    Private Sub CargarTotalesVenta()
        Select Case CondicionIva
            Case CondicionIVA.Responsable_Inscripto, CondicionIVA.Monotributo
                CargarTotalesResponsableInscriptoVenta()
            Case CondicionIVA.Consumidor_Final, CondicionIVA.Exento
                CargarTotalesConsumidorFinalVenta()
        End Select
    End Sub

    Private Sub CargarTotalesNotaCredito()
        Select Case CondicionIva
            Case CondicionIVA.Responsable_Inscripto, CondicionIVA.Monotributo
                CargarTotalesResponsableInscriptoNotaCredito()
            Case CondicionIVA.Consumidor_Final, CondicionIVA.Exento
                CargarTotalesConsumidorFinalNotaCredito()
        End Select
    End Sub

    Private Sub CargarTotalesConsumidorFinalVenta()
        Dim totalFacturado As MontoPago = Venta.TotalFacturable(CondicionIva)

        AgregarRowPagos("Sub Total", totalFacturado.Monto)
        AgregarRowPagos("Descuento", -totalFacturado.Descuento)
        AgregarRowPagos("Recargos", totalFacturado.CFT)
        AgregarRowPagos("Total", totalFacturado.Total)
    End Sub

    Private Sub CargarTotalesConsumidorFinalNotaCredito()
        Dim totalFacturado As MontoPago = Venta.TotalAnuladoYFacturados(CondicionIva)

        AgregarRowPagos("Sub Total", totalFacturado.Monto)
        AgregarRowPagos("Descuento", -totalFacturado.Descuento)
        AgregarRowPagos("Recargos", totalFacturado.CFT)
        AgregarRowPagos("Total", totalFacturado.Total)
    End Sub


    Private Sub CargarTotalesResponsableInscriptoVenta()
        Dim totalFacturado As MontoPago = Venta.TotalFacturable(CondicionIva)
        Dim Total As Decimal = totalFacturado.Monto - totalFacturado.Descuento + totalFacturado.CFT

        AgregarRowPagos("Sub Total", totalFacturado.Monto)
        AgregarRowPagos("Descuento", -totalFacturado.Descuento)
        AgregarRowPagos("Recargos", totalFacturado.CFT)
        AgregarRowPagos("Sub Total", Total)

        Dim gruposIVAs As List(Of IGrouping(Of IVA, VentaItem)) = Venta.ObtenerItemsVentaFacturados.GroupBy(Function(x) x.Producto.SubCategoria.IVA).ToList()
        For Each item As IGrouping(Of IVA, VentaItem) In gruposIVAs
            Dim iva As Decimal = ObtenerMontoIva(item)
            Total += iva
            AgregarRowPagos($"IVA {item.Key.Valor.ToString("p")}", iva)
        Next

        AgregarRowPagos("Total", Total)
    End Sub

    Private Sub CargarTotalesResponsableInscriptoNotaCredito()
        Dim totalFacturado As MontoPago = Venta.TotalAnuladoYFacturados(CondicionIva)
        Dim Total As Decimal = totalFacturado.Monto - totalFacturado.Descuento + totalFacturado.CFT

        AgregarRowPagos("Sub Total", totalFacturado.Monto)
        AgregarRowPagos("Descuento", -totalFacturado.Descuento)
        AgregarRowPagos("Recargos", totalFacturado.CFT)
        AgregarRowPagos("Sub Total", Total)

        Dim gruposIVAs As List(Of IGrouping(Of IVA, VentaItem)) = Venta.ObtenerItemsVentaAnuladasYFacturados.GroupBy(Function(x) x.Producto.SubCategoria.IVA).ToList()
        For Each item As IGrouping(Of IVA, VentaItem) In gruposIVAs
            Dim iva As Decimal = ObtenerMontoIva(item)
            Total += iva
            AgregarRowPagos($"IVA {item.Key.Valor.ToString("p")}", iva)
        Next

        AgregarRowPagos("Total", Total)
    End Sub

    Private Function ObtenerMontoIva(grupoIva As IGrouping(Of IVA, VentaItem)) As Decimal
        Dim decuento As Decimal = grupoIva.Sum(Function(x) x.TotalDescuento(Venta.PorcentajeFacturacion, Venta.TipoCliente, CondicionIva))
        Dim cft As Decimal = grupoIva.Sum(Function(x) x.TotalCFT(Venta.PorcentajeFacturacion, Venta.TipoCliente, CondicionIva))
        Dim monto As Decimal = grupoIva.Sum(Function(x) x.TotalMonto(Venta.PorcentajeFacturacion, Venta.TipoCliente, CondicionIva))
        Dim total As Decimal = monto - decuento + cft

        Return total * grupoIva.Key.Valor
    End Function

    Private Sub CargarProductosVenta()
        For Each item As VentaItem In Venta.ObtenerItemsVentaFacturados
            CargarProducto(item)
        Next
    End Sub

    Private Sub CargarProductosNotaCredito()
        For Each item As VentaItem In Venta.ObtenerItemsVentaAnuladasYFacturados
            CargarProducto(item)
        Next
    End Sub

    Private Sub CargarProducto(item As VentaItem)
        Dim iva As Decimal = 0
        Dim montoProducto As Decimal = 0

        If (TipoCliente = TipoCliente.Minorista) Then
            Select Case CondicionIva
                Case CondicionIVA.Responsable_Inscripto, CondicionIVA.Monotributo
                    montoProducto = Monto.ObtenerSinIVA(item.MontoProducto.Valor, item.Producto.SubCategoria.IVA.Valor, Venta.PorcentajeFacturacion)
                    iva = montoProducto * item.Producto.SubCategoria.IVA.Valor
                Case CondicionIVA.Consumidor_Final, CondicionIVA.Exento
                    montoProducto = (item.MontoProducto.Valor * Venta.PorcentajeFacturacion) + item.MontoProducto.Iva
            End Select
        Else
            Select Case CondicionIva
                Case CondicionIVA.Responsable_Inscripto, CondicionIVA.Monotributo
                    montoProducto = item.MontoProducto.Valor * Venta.PorcentajeFacturacion
                    iva = item.MontoProducto.Iva
                Case CondicionIVA.Consumidor_Final, CondicionIVA.Exento
                    montoProducto = (item.MontoProducto.Valor * Venta.PorcentajeFacturacion) + item.MontoProducto.Iva
            End Select
        End If
        AgregarRowTransaccionItems(item.Producto.Codigo, item.Producto.Nombre, item.Cantidad, Monto.Redondeo(montoProducto), Monto.Redondeo(iva))
    End Sub

    Private Sub InicializarTotalesTable(ByRef dtPagos As DataTable)
        dtPagos = ds.Tables.Add("Totales")
        dtPagos.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtPagos.Columns.Add("Monto", Type.GetType("System.Double"))

        dtPagos.Columns("Monto").DefaultValue = 0
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

    Private Sub AgregarRowTransaccionItems(codigo As String, nombre As String, cantidad As Integer, Precio As Double, Iva As Double)
        Dim dr As DataRow = dtProductos.NewRow()
        dr(0) = codigo
        dr(1) = nombre
        dr(2) = cantidad
        dr(3) = Iva
        dr(4) = Precio
        dr(5) = (dr(4) * cantidad)

        dtProductos.Rows.Add(dr)
    End Sub

    Private Sub AgregarRowPagos(descripcion As String, monto As Decimal)
        Dim dr As DataRow = dtTotales.NewRow()
        dr(0) = descripcion
        dr(1) = monto

        dtTotales.Rows.Add(dr)
    End Sub

    Private Function ObtenerLetraFactura() As String
        Select Case CondicionIva
            Case CondicionIVA.Responsable_Inscripto, CondicionIVA.Monotributo
                Return LETRA_FACTURA_A
            Case CondicionIVA.Consumidor_Final, CondicionIVA.Exento
                Return LETRA_FACTURA_B
        End Select
    End Function

    Private Function ObtenerNombreFactura(tipoDocumentoFiscal As TipoDocumentoFiscal) As String
        If (tipoDocumentoFiscal = TipoDocumentoFiscal.Factura) Then
            Return LEYENDA_FACTURA
        Else
            Return LEYENDA_NOTA_CREDITO
        End If
    End Function

    Private Function ObtenerCodigoFactura() As String
        If TipoDocumentoFiscal = TipoDocumentoFiscal.Factura Then
            Select Case CondicionIva
                Case CondicionIVA.Responsable_Inscripto, CondicionIVA.Monotributo
                    Return CODIGO_FACTURA_A
                Case CondicionIVA.Consumidor_Final, CondicionIVA.Exento
                    Return CODIGO_FACTURA_B
            End Select
        Else
            Select Case CondicionIva
                Case CondicionIVA.Responsable_Inscripto, CondicionIVA.Monotributo
                    Return CODIGO_NOTA_CREDITO_A
                Case CondicionIVA.Consumidor_Final, CondicionIVA.Exento
                    Return CODIGO_NOTA_CREDITO_B
            End Select
        End If
    End Function

    Private Function ObtenerNumeroFactura() As String
        If (TipoDocumentoFiscal = TipoDocumentoFiscal.Factura) Then
            Return $"{Venta.Factura.PuntoVenta.ToString().PadLeft(4, "0")} - {Venta.Factura.NumeroFactura.First().Numero.ToString().PadLeft(8, "0")}"
        Else
            Return $"{Venta.NotaCredito.PuntoVenta.ToString().PadLeft(4, "0")} - {Venta.NotaCredito.NumeroNotaCredito.First().Numero.ToString().PadLeft(8, "0")}"
        End If
    End Function

    Private Function GenerarQRFactura() As String
        Dim QRDatos As String = ObtenerQRDatos()

        Dim qrGenerator As QRCodeGenerator = New QRCodeGenerator()
        Dim QRCodeData As QRCodeData = qrGenerator.CreateQrCode(QRDatos, QRCodeGenerator.ECCLevel.L)
        Dim QRCode As QRCode = New QRCode(QRCodeData)
        Dim qrCodeImage As Bitmap = QRCode.GetGraphic(20, Color.Black, Color.White, True)

        Using memory As MemoryStream = New MemoryStream()
            Using fs As FileStream = New FileStream(RutaImagenCodigoQR, FileMode.Create, FileAccess.ReadWrite)

                qrCodeImage.Save(memory, ImageFormat.Png)
                Dim bytes As Byte() = memory.ToArray()
                fs.Write(bytes, 0, bytes.Length)

            End Using
        End Using
        Return RutaImagenCodigoQR
    End Function

    Private Function ObtenerQRDatos() As String

        Dim documento As DocumentoFiscal
        Dim numeroConprobante As Integer = 0
        If (TipoDocumentoFiscal = TipoDocumentoFiscal.Factura) Then
            documento = Venta.Factura
            numeroConprobante = Venta.Factura.NumeroFactura.First().Numero
        Else
            documento = Venta.NotaCredito
            numeroConprobante = Venta.NotaCredito.NumeroNotaCredito.First().Numero
        End If

        Dim qrDatos = New With {
                                    .ver = 1,
                                    .fecha = documento.Fecha.ToString("yyyy-MM-dd"),
                                    .Cuit = AfipFacturacionElectronicaConstantes.CUIT_FACTURACION,
                                    .ptoVta = documento.PuntoVenta,
                                    .tipoCmp = AfipFacturacionElectronica.ObtenerTipoComprobante(Nothing, documento.CondicionIVA, TipoDocumentoFiscal),
                                    .nroCmp = numeroConprobante,
                                    .importe = documento.Total,
                                    .moneda = AfipFacturacionElectronicaConstantes.PESOS,
                                    .ctz = AfipFacturacionElectronicaConstantes.PESOS_COTIZACION,
                                    .tipoDocRec = AfipFacturacionElectronica.ObtenerTipoDocumento(documento.CondicionIVA),
                                    .nroDocRec = Long.Parse(documento.CUIT),
                                    .tipoCodAut = AfipFacturacionElectronicaConstantes.COMPROBANTE_AUTORIZADO_POR_CAE,
                                    .codAut = Long.Parse(documento.CAE)
                                }

        Return Base64Encode(JsonConvert.SerializeObject(qrDatos))
    End Function

    Private Function Base64Encode(plainText As String) As String
        Dim plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText)
        Return Convert.ToBase64String(plainTextBytes)
    End Function
End Class