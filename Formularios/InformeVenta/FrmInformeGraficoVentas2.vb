Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports SistemaCinderella.Formularios.InformeVenta
Imports Ventas.Core.Model.InformeAggregate

Public Class FrmInformeGraficoVentas2
    Private frmInformeGraficoVentasViewModel As frmInformeGraficoVentasViewModel

    Sub New(informeVentaPorTipoVenta As List(Of InformeVentaPorTipoVenta), informeVentaPorTipoPago As List(Of InformeVentaPorTipoPago), informeVentaPorFecha As List(Of InformeVentaPorFecha))

        ' This call is required by the designer.
        InitializeComponent()

        frmInformeGraficoVentasViewModel = New frmInformeGraficoVentasViewModel(informeVentaPorTipoVenta, informeVentaPorTipoPago, informeVentaPorFecha)
    End Sub

    Private Sub FrmInformeGraficoVentas2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chtTotalTipoCliente.DataSource = frmInformeGraficoVentasViewModel.ObtenerVentasTipoCliente()
        chtTotalTipoCliente.DataBind()

        chtTotalFacturado.DataSource = frmInformeGraficoVentasViewModel.ObtenerVentasFacturadas()
        chtTotalFacturado.DataBind()

        chtTotalCuotas.DataSource = frmInformeGraficoVentasViewModel.ObtenerVentasNumeroCuotas()
        chtTotalFacturado.DataBind()

        chtTotalFormaPago.DataSource = frmInformeGraficoVentasViewModel.ObtenerVentasTipoPagos(Nothing)
        chtTotalFormaPago.DataBind()

        chtTotalFormaPagoMinorista.DataSource = frmInformeGraficoVentasViewModel.ObtenerVentasTipoPagos(TipoCliente.Minorista)
        chtTotalFormaPagoMinorista.DataBind()

        chtTotalFormaPagoMayorita.DataSource = frmInformeGraficoVentasViewModel.ObtenerVentasTipoPagos(TipoCliente.Mayorista)
        chtTotalFormaPagoMayorita.DataBind()

        chtVentas.DataSource = frmInformeGraficoVentasViewModel.ObtenerVentasPorFecha()
        chtVentas.DataBind()
    End Sub
End Class