Imports Ventas.Core.Model.InformeAggregate

Namespace Formularios.InformeVenta
    Public Class frmInformeGraficoEgresosViewModel
        Private InformeGastos As List(Of InformeVentaEgresos)
        Private InformeCostos As List(Of InformeVentaEgresos)

        Sub New(informeGastos As List(Of InformeVentaEgresos), informeCostos As List(Of InformeVentaEgresos))
            Me.InformeGastos = informeGastos
            Me.InformeCostos = informeCostos
        End Sub

        Public Function ObtenerGastos() As DataTable
            Dim datos As List(Of Tuple(Of String, Decimal)) = InformeGastos.Select(Function(x)
                                                                                       Return New Tuple(Of String, Decimal)(
                                                                                                                    x.Nombre,
                                                                                                                    x.Monto)
                                                                                   End Function).ToList()

            Return ObtenerDT("Detalle", "Monto", datos)
        End Function

        Public Function ObtenerCostos() As DataTable
            Dim datos As List(Of Tuple(Of String, Decimal)) = InformeCostos.Select(Function(x)
                                                                                       Return New Tuple(Of String, Decimal)(
                                                                                                                    x.Nombre,
                                                                                                                    x.Monto)
                                                                                   End Function).ToList()

            Return ObtenerDT("Detalle", "Monto", datos)
        End Function

        Private Function ObtenerDT(NombreColumna1 As String, NombreColumna2 As String, datos As List(Of Tuple(Of String, Decimal))) As DataTable
            Dim dtTotalTipoClientea As DataTable = New DataTable()
            dtTotalTipoClientea.Columns.Add(NombreColumna1)
            dtTotalTipoClientea.Columns.Add(NombreColumna2)

            datos.ForEach(Sub(x) dtTotalTipoClientea.Rows.Add(x.Item1, x.Item2))
            Return dtTotalTipoClientea
        End Function
    End Class
End Namespace
