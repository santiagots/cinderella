Imports CrystalDecisions.CrystalReports.Engine
Imports Ventas.Core.Model.ValueObjects
Imports Ventas.Core.Model.VentaAggregate
Imports Common.Core.Model
Imports Common.Core.Enum
Imports Common.Core.Helper

Public Class frmReporteFactura

    Private TipoCliente As TipoCliente
    Private TipoDocumentoFiscal As TipoDocumentoFiscal
    Private Venta As Venta
    Private ds As New DataSet
    Private dtProductos As New DataTable
    Private dtTotales As New DataTable

    Private ReadOnly Property CondicionIva As CondicionIVA
        Get
            Return If(TipoDocumentoFiscal = TipoDocumentoFiscal.NotaCredito, Venta.NotaCredito.CondicionIVA, Venta.Factura.CondicionIVA)
        End Get
    End Property

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub

    Sub New(idVenta As Long, tipoCliente As TipoCliente, tipoDocumentoFiscal As TipoDocumentoFiscal)
        Me.New
        Me.Venta = Comunes.Servicio.ObtenerVenta(idVenta)
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
        CargarProductos()
        rpt.Database.Tables("TransaccionItem").SetDataSource(dtProductos)


        InicializarTotalesTable(dtTotales)
        CargarTotales()
        rpt.Database.Tables("Totales").SetDataSource(dtTotales)

        Dim codigoFactura As String = ObtenerIdentificadorFactura()

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

        CType(rpt.ReportDefinition.ReportObjects("txtCodigoBarras"), TextObject).Text = codigoFactura
        CType(rpt.ReportDefinition.ReportObjects("txtIdentificadorFactura"), TextObject).Text = codigoFactura
        CType(rpt.ReportDefinition.ReportObjects("txtCAE"), TextObject).Text = If(TipoDocumentoFiscal = TipoDocumentoFiscal.Factura, Venta.Factura.CAE, Venta.NotaCredito.CAE)
        CType(rpt.ReportDefinition.ReportObjects("txtVencimientoCAE"), TextObject).Text = If(TipoDocumentoFiscal = TipoDocumentoFiscal.Factura, Venta.Factura.FechaVencimientoCAE?.ToString("dd/MM/yyyy"), Venta.NotaCredito.FechaVencimientoCAE?.ToString("dd/MM/yyyy"))

        CrViewer.ReportSource = rpt
        CrViewer.SelectionMode = SelectionMode.None
        CrViewer.Refresh()
    End Sub

    Private Sub CargarTotales()
        If (CondicionIva = CondicionIVA.Responsable_Inscripto) Then
            CargarTotalesResponsableInscripto()
        Else
            CargarTotalesConsumidorFinal()
        End If
    End Sub

    Private Sub CargarTotalesConsumidorFinal()
        Dim SubTotal As Decimal = Venta.VentaItems.Sum(Function(x) x.TotalMonto(Venta.PorcentajeFacturacion, Venta.TipoCliente, CondicionIva))
        AgregarRowPagos("Sub Total", SubTotal)

        Dim Descuento As Decimal = -Venta.VentaItems.Sum(Function(x) x.TotalDescuento(Venta.PorcentajeFacturacion, Venta.TipoCliente, CondicionIva))
        AgregarRowPagos("Descuento", Descuento)

        Dim Recargos As Decimal = Venta.VentaItems.Sum(Function(x) x.TotalCFT(Venta.PorcentajeFacturacion, Venta.TipoCliente, CondicionIva))
        AgregarRowPagos("Recargos", Recargos)

        Dim Total As Decimal = SubTotal + Descuento + Recargos

        AgregarRowPagos("Total", Total)
    End Sub


    Private Sub CargarTotalesResponsableInscripto()
        Dim Total As Decimal = 0

        Dim SubTotal1 As Decimal = Venta.VentaItems.Sum(Function(x) x.TotalMonto(Venta.PorcentajeFacturacion, Venta.TipoCliente, CondicionIva))
        AgregarRowPagos("Sub Total", SubTotal1)

        Dim Descuento As Decimal = -Venta.VentaItems.Sum(Function(x) x.TotalDescuento(Venta.PorcentajeFacturacion, Venta.TipoCliente, CondicionIva))
        AgregarRowPagos("Descuento", Descuento)

        Dim Recargos As Decimal = Venta.VentaItems.Sum(Function(x) x.TotalCFT(Venta.PorcentajeFacturacion, Venta.TipoCliente, CondicionIva))
        AgregarRowPagos("Recargos", Recargos)

        Dim SubTotal2 As Decimal = (SubTotal1 + Descuento + Recargos)
        Total += SubTotal2
        AgregarRowPagos("Sub Total", SubTotal2)

        Dim gruposIVAs As List(Of IGrouping(Of IVA, VentaItem)) = Venta.VentaItems.GroupBy(Function(x) x.Producto.SubCategoria.IVA).ToList()
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

    Private Sub CargarProductos()
        For Each item As VentaItem In Venta.VentaItems
            CargarProducto(item)
        Next
    End Sub

    Private Sub CargarProducto(item As VentaItem)
        Dim iva As Decimal = 0
        Dim montoProducto As Decimal = 0

        If (TipoCliente = TipoCliente.Minorista) Then
            If (CondicionIva = CondicionIVA.Responsable_Inscripto) Then
                montoProducto = Monto.ObtenerSinIVA(item.MontoProducto.Valor, item.Producto.SubCategoria.IVA.Valor, Venta.PorcentajeFacturacion)
                iva = montoProducto * item.Producto.SubCategoria.IVA.Valor
            Else
                montoProducto = (item.MontoProducto.Valor * Venta.PorcentajeFacturacion) + item.MontoProducto.Iva
            End If
        Else
            If (CondicionIva = CondicionIVA.Responsable_Inscripto) Then
                montoProducto = item.MontoProducto.Valor * Venta.PorcentajeFacturacion
                iva = item.MontoProducto.Iva
            Else
                montoProducto = (item.MontoProducto.Valor * Venta.PorcentajeFacturacion) + item.MontoProducto.Iva
            End If
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
        If (CondicionIva = CondicionIVA.Responsable_Inscripto) Then
            Return "A"
        Else
            Return "B"
        End If
    End Function

    Private Function ObtenerNombreFactura(tipoDocumentoFiscal As TipoDocumentoFiscal) As String
        If (tipoDocumentoFiscal = TipoDocumentoFiscal.Factura) Then
            Return "Factura"
        Else
            Return "Nota Crédito"
        End If
    End Function

    Private Function ObtenerCodigoFactura() As String
        If TipoDocumentoFiscal = TipoDocumentoFiscal.Factura Then
            If CondicionIva = CondicionIVA.Responsable_Inscripto Then
                Return "01"
            Else
                Return "06"
            End If
        Else
            If CondicionIva = CondicionIVA.Responsable_Inscripto Then
                Return "03"
            Else
                Return "08"
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