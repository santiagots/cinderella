Public Class SaldosSucursal

    Public Event BtnDevolucionesClick As EventHandler

    Public Event BtnSueldoClick As EventHandler

    Public Event BtnGastoClick As EventHandler

    Public Event BtnImpuestoClick As EventHandler

    Public Event BtnEfectivoEgresoClick As EventHandler

    Public Event BtnPendienteAutorizacionClick As EventHandler

    Public Event BtnFaltanteClick As EventHandler

    Public Event BtnIngresoCajaFuerteClick As EventHandler

    Public Event BtnRetiroClick As EventHandler

    Public Event BtnVentaClick As EventHandler

    Public Event BtnEfectivoIngresoClick As EventHandler

    Public Event BtnSobranteClick As EventHandler

    Public Event BtnEgresoCajaFuerteClick As EventHandler

    Public Event BtnAporteClick As EventHandler

    Public Event BtnEfectivoClick As EventHandler

    Public Event BtnChequeClick As EventHandler

    Public Event BtnCreditoClick As EventHandler

    Public Event BtnDebitoClick As EventHandler

    Public Event BtnDepositoClick As EventHandler

    Public Event BtnFacturadoClick As EventHandler

    Public Event BtnSinFacturadoClick As EventHandler

    Public Event BtnMinoristaClick As EventHandler

    Public Event BtnMayoristaClick As EventHandler


    Private Sub Btn_Devoluciones_Click(sender As Object, e As EventArgs) Handles Btn_Devoluciones.Click
        RaiseEvent BtnDevolucionesClick(Me, e)
    End Sub

    Private Sub Btn_Sueldo_Click(sender As Object, e As EventArgs) Handles Btn_Sueldo.Click
        RaiseEvent BtnSueldoClick(Me, e)
    End Sub

    Private Sub Btn_Gasto_Click(sender As Object, e As EventArgs) Handles Btn_Gasto.Click
        RaiseEvent BtnGastoClick(Me, e)
    End Sub

    Private Sub Btn_Impuesto_Click(sender As Object, e As EventArgs) Handles Btn_Impuesto.Click
        RaiseEvent BtnImpuestoClick(Me, e)
    End Sub

    Private Sub Btn_EfectivoEgreso_Click(sender As Object, e As EventArgs) Handles Btn_EfectivoEgreso.Click
        RaiseEvent BtnEfectivoEgresoClick(Me, e)
    End Sub

    Private Sub Btn_PendienteAutorizacion_Click(sender As Object, e As EventArgs) Handles Btn_PendienteAutorizacion.Click
        RaiseEvent BtnPendienteAutorizacionClick(Me, e)
    End Sub

    Private Sub Btn_Faltante_Click(sender As Object, e As EventArgs) Handles Btn_Faltante.Click
        RaiseEvent BtnFaltanteClick(Me, e)
    End Sub

    Private Sub Btn_IngresoCajaFuerte_Click(sender As Object, e As EventArgs) Handles Btn_IngresoCajaFuerte.Click
        RaiseEvent BtnIngresoCajaFuerteClick(Me, e)
    End Sub

    Private Sub Btn_Retiro_Click(sender As Object, e As EventArgs) Handles Btn_Retiro.Click
        RaiseEvent BtnRetiroClick(Me, e)
    End Sub

    Private Sub Btn_Venta_Click(sender As Object, e As EventArgs) Handles Btn_Venta.Click
        RaiseEvent BtnVentaClick(Me, e)
    End Sub

    Private Sub Btn_EfectivoIngreso_Click(sender As Object, e As EventArgs) Handles Btn_EfectivoIngreso.Click
        RaiseEvent BtnEfectivoIngresoClick(Me, e)
    End Sub

    Private Sub Btn_Sobrante_Click(sender As Object, e As EventArgs) Handles Btn_Sobrante.Click
        RaiseEvent BtnSobranteClick(Me, e)
    End Sub

    Private Sub Btn_EgresoCajaFuerte_Click(sender As Object, e As EventArgs) Handles Btn_EgresoCajaFuerte.Click
        RaiseEvent BtnEgresoCajaFuerteClick(Me, e)
    End Sub

    Private Sub Btn_Aporte_Click(sender As Object, e As EventArgs) Handles Btn_Aporte.Click
        RaiseEvent BtnAporteClick(Me, e)
    End Sub

    Private Sub Btn_Efectivo_Click(sender As Object, e As EventArgs) Handles Btn_Efectivo.Click
        RaiseEvent BtnEfectivoClick(Me, e)
    End Sub

    Private Sub Btn_Cheque_Click(sender As Object, e As EventArgs) Handles Btn_Cheque.Click
        RaiseEvent BtnChequeClick(Me, e)
    End Sub

    Private Sub Btn_Credito_Click(sender As Object, e As EventArgs) Handles Btn_Credito.Click
        RaiseEvent BtnCreditoClick(Me, e)
    End Sub

    Private Sub Btn_Debito_Click(sender As Object, e As EventArgs) Handles Btn_Debito.Click
        RaiseEvent BtnDebitoClick(Me, e)
    End Sub

    Private Sub Btn_Deposito_Click(sender As Object, e As EventArgs) Handles Btn_Deposito.Click
        RaiseEvent BtnDepositoClick(Me, e)
    End Sub

    Private Sub Btn_Facturado_Click(sender As Object, e As EventArgs) Handles Btn_Facturado.Click
        RaiseEvent BtnFacturadoClick(Me, e)
    End Sub

    Private Sub Btn_SinFacturado_Click(sender As Object, e As EventArgs) Handles Btn_SinFacturado.Click
        RaiseEvent BtnSinFacturadoClick(Me, e)
    End Sub

    Private Sub Btn_Minorista_Click(sender As Object, e As EventArgs) Handles Btn_Minorista.Click
        RaiseEvent BtnMinoristaClick(Me, e)
    End Sub

    Private Sub Btn_Mayorista_Click(sender As Object, e As EventArgs) Handles Btn_Mayorista.Click
        RaiseEvent BtnMayoristaClick(Me, e)
    End Sub
End Class
