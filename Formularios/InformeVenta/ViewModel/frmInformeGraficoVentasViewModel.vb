Imports Common.Core.Enum
Imports Ventas.Core.Model.InformeAggregate

Namespace Formularios.InformeVenta
    Public Class frmInformeGraficoVentasViewModel

        Private InformeVentaPorTipoVenta As List(Of InformeVentaPorTipoVenta)
        Private InformeVentaPorTipoPago As List(Of InformeVentaPorTipoPago)
        Private InformeVentaPorFecha As List(Of InformeVentaPorFecha)

        Sub New(informeVentaPorTipoVenta As List(Of InformeVentaPorTipoVenta), informeVentaPorTipoPago As List(Of InformeVentaPorTipoPago), informeVentaPorFecha As List(Of InformeVentaPorFecha))
            Me.InformeVentaPorTipoVenta = informeVentaPorTipoVenta
            Me.InformeVentaPorTipoPago = informeVentaPorTipoPago
            Me.InformeVentaPorFecha = informeVentaPorFecha
        End Sub

        Public Function ObtenerVentasTipoCliente() As DataTable
            Dim informeVentaPorTipoCliente = InformeVentaPorTipoVenta.GroupBy(Function(x) x.TipoCliente).ToList()

            Dim datos As List(Of Tuple(Of String, Decimal)) = informeVentaPorTipoCliente.Select(Function(x)
                                                                                                    Return New Tuple(Of String, Decimal)(
                                                                                                                    x.Key.ToString(),
                                                                                                                    x.Sum(Function(y) y.Monto))
                                                                                                End Function).ToList()

            Return ObtenerDT("Detalle", "Monto", datos)
        End Function

        Public Function ObtenerVentasFacturadas() As DataTable
            Dim informeVentasFacturadas = InformeVentaPorTipoVenta.GroupBy(Function(x) x.Facturado).ToList()

            Dim datos As List(Of Tuple(Of String, Decimal)) = informeVentasFacturadas.Select(Function(x)
                                                                                                 Return New Tuple(Of String, Decimal)(
                                                                                                                    If(x.Key, "Facturado", "Sin Facturar"),
                                                                                                                    x.Sum(Function(y) y.Monto))
                                                                                             End Function).ToList()

            Return ObtenerDT("Detalle", "Monto", datos)
        End Function

        Public Function ObtenerVentasNumeroCuotas() As DataTable
            Dim cantidadCuotas = InformeVentaPorTipoPago _
                                                        .Where(Function(x) x.TipoPago = TipoPago.TarjetaCrédito) _
                                                        .GroupBy(Function(x) x.CantidadCuotas).ToList()

            Dim datos As List(Of Tuple(Of String, Decimal)) = cantidadCuotas.Select(Function(x)
                                                                                        Return New Tuple(Of String, Decimal)(
                                                                                                    x.Key.ToString(),
                                                                                                    x.Sum(Function(y) y.MontoTotal))
                                                                                    End Function).ToList()

            Return ObtenerDT("NroCuota", "Monto", datos)
        End Function

        Public Function ObtenerVentasTipoPagos(tipoCliente As TipoCliente?) As DataTable

            Dim informeVentaPorTipoPagoAux As List(Of InformeVentaPorTipoPago)

            If (tipoCliente.HasValue) Then
                informeVentaPorTipoPagoAux = InformeVentaPorTipoPago.Where(Function(x) x.TipoCliente = tipoCliente.Value).ToList()
            Else
                informeVentaPorTipoPagoAux = InformeVentaPorTipoPago.ToList()
            End If

            Dim informeVentasTipoPago = informeVentaPorTipoPagoAux.GroupBy(Function(x) x.TipoPago).ToList()

            Dim datos As List(Of Tuple(Of String, Decimal)) = informeVentasTipoPago.Select(Function(x)
                                                                                               Return New Tuple(Of String, Decimal)(
                                                                                                                    x.Key.ToString(),
                                                                                                                    x.Sum(Function(y) y.MontoTotal))
                                                                                           End Function).ToList()
            Return ObtenerDT("Detalle", "Monto", datos)
        End Function

        Public Function ObtenerVentasPorFecha() As DataTable
            Dim datos As List(Of Tuple(Of String, Integer, Decimal)) = InformeVentaPorFecha.Select(Function(x)
                                                                                                       Return New Tuple(Of String, Integer, Decimal)(
                                                                                                                    x.Fecha,
                                                                                                                    x.Cantidad,
                                                                                                                    x.Monto)
                                                                                                   End Function).ToList()

            Return ObtenerDT("Fecha", "Cantidad", "Monto", datos)
        End Function


        Private Function ObtenerDT(NombreColumna1 As String, NombreColumna2 As String, datos As List(Of Tuple(Of String, Decimal))) As DataTable
            Dim dtTotalTipoClientea As DataTable = New DataTable()
            dtTotalTipoClientea.Columns.Add(NombreColumna1)
            dtTotalTipoClientea.Columns.Add(NombreColumna2)

            datos.ForEach(Sub(x) dtTotalTipoClientea.Rows.Add(x.Item1, x.Item2))
            Return dtTotalTipoClientea
        End Function

        Private Function ObtenerDT(NombreColumna1 As String, NombreColumna2 As String, NombreColumna3 As String, datos As List(Of Tuple(Of String, Integer, Decimal))) As DataTable
            Dim dtTotalTipoClientea As DataTable = New DataTable()
            dtTotalTipoClientea.Columns.Add(NombreColumna1)
            dtTotalTipoClientea.Columns.Add(NombreColumna2)
            dtTotalTipoClientea.Columns.Add(NombreColumna3)

            datos.ForEach(Sub(x) dtTotalTipoClientea.Rows.Add(x.Item1, x.Item2, x.Item3))
            Return dtTotalTipoClientea
        End Function
    End Class
End Namespace
