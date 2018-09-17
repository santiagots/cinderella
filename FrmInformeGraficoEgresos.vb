Public Class FrmInformeGraficoEgresos

    Public TopGastos As DataTable
    Public TopProveedor As DataTable

    Private Sub FrmInformeGraficoEgresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chtTopGastos.DataSource = TopGastos
        chtTopProveedor.DataSource = TopProveedor
    End Sub
End Class