Public Class FrmInformeGraficoVentas

    Public TotalTipoCliente As DataTable
    Public TotalFacturado As DataTable
    Public TotalCuotas As DataTable
    Public TotalFormaPago As DataTable
    Public TotalFormaPagoMinorista As DataTable
    Public TotalFormaPagoMayorista As DataTable
    Public Ventas As DataTable

    Private Sub FrmInformeGraficoVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chtTotalTipoCliente.DataSource = TotalTipoCliente
        chtTotalFacturado.DataSource = TotalFacturado
        chtTotalCuotas.DataSource = TotalCuotas
        chtTotalFormaPago.DataSource = TotalFormaPago
        chtTotalFormaPagoMinorista.DataSource = TotalFormaPagoMinorista
        chtTotalFormaPagoMayorita.DataSource = TotalFormaPagoMayorista
        chtVentas.DataSource = Ventas
    End Sub
End Class