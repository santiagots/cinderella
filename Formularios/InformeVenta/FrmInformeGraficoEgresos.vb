Imports SistemaCinderella.Formularios.InformeVenta
Imports Ventas.Core.Model.InformeAggregate

Public Class FrmInformeGraficoEgresos

    Private frmInformeGraficoEgresosViewModel As frmInformeGraficoEgresosViewModel

    Sub New(informeGastos As List(Of InformeVentaEgresos), informeCostos As List(Of InformeVentaEgresos))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        frmInformeGraficoEgresosViewModel = New frmInformeGraficoEgresosViewModel(informeGastos, informeCostos)
    End Sub

    Private Sub FrmInformeGraficoEgresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chtTopGastos.DataSource = frmInformeGraficoEgresosViewModel.ObtenerGastos()
        chtTopProveedor.DataSource = frmInformeGraficoEgresosViewModel.ObtenerCostos()
    End Sub
End Class