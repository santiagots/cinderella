Imports Entidades
Imports Negocio

Public Class frmClienteMayoristaCuentaCorrientePago

    Private SaldoActual As Decimal
    Private Id_Cheque As Integer
    Private Monto As Decimal
    Public Id_Cliente As Integer
    Public NombreCliente As String
    Public RazonSocialCliente As String

    Private Sub Btn_BuscarCliente_Click(sender As Object, e As EventArgs) Handles Btn_BuscarCliente.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmBuscarClienteMayorista As frmBuscarClienteMayorista = New frmBuscarClienteMayorista()
        frmBuscarClienteMayorista.ShowDialog()


        If frmBuscarClienteMayorista.clienteMayorista IsNot Nothing Then
            txt_id_Cliente.Clear()
            txt_Nombre.Clear()
            txt_id_Cliente.Text = frmBuscarClienteMayorista.clienteMayorista.Id
            Id_Cliente = frmBuscarClienteMayorista.clienteMayorista.Id
            txt_Nombre.Text = frmBuscarClienteMayorista.clienteMayorista.Nombre
            NombreCliente = frmBuscarClienteMayorista.clienteMayorista.Nombre
            txt_RazonSocial.Text = frmBuscarClienteMayorista.clienteMayorista.RazonSocial
            RazonSocialCliente = frmBuscarClienteMayorista.clienteMayorista.RazonSocial

            CargarMovimientos(frmBuscarClienteMayorista.clienteMayorista.Id)
        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub validarMoneda(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        Dim NegErrores As NegManejadorErrores = New NegManejadorErrores()
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub validarNumero(sender As Object, e As KeyPressEventArgs) Handles txtComprobante.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        Dim NegErrores As NegManejadorErrores = New NegManejadorErrores()
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmClienteMayoristaCuentaCorrientePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (Id_Cliente > 0) Then
            txt_id_Cliente.Text = Id_Cliente
            txt_id_Cliente.Enabled = False
            txt_Nombre.Text = NombreCliente
            txt_Nombre.Enabled = False
            txt_RazonSocial.Text = RazonSocialCliente
            txt_RazonSocial.Enabled = False

            cmb_Empresa.SelectedIndex = 0

            CargarMovimientos(Id_Cliente)
        End If
    End Sub

    Private Sub txtMonto_Leave(sender As Object, e As EventArgs) Handles txtMonto.Leave
        Monto = Decimal.Parse(txtMonto.Text)
        txt_SaldoNuevo.Text = (SaldoActual - Monto).ToString("C2")
        txtMonto.Text = Monto.ToString("C2")
    End Sub

    Private Sub Limpiar()
        dtpFecha.Value = DateTime.Now
        txtFormaPago.Clear()
        txtMonto.Clear()
        txtComprobante.Clear()
    End Sub


    Private Sub CargarMovimientos(id_Cliente As Integer)
        Dim negCuentaCorrienteClientesMayoristas As NegCuentaCorrienteClientesMayoristas = New NegCuentaCorrienteClientesMayoristas()
        Dim movimientos As List(Of MovimientoCuentaCorrienteClienteMayorista) = negCuentaCorrienteClientesMayoristas.Movimientos(id_Cliente)
        MovimientoCuentaCorrienteClienteMayoristaBindingSource.DataSource = movimientos
        SaldoActual = If(movimientos.Count > 0, movimientos.Last().Saldo, 0)
        txt_Saldo.Text = SaldoActual.ToString("C2")
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim pagoCuentaCorrienteClienteMayorista As PagoCuentaCorrienteClienteMayorista = New PagoCuentaCorrienteClienteMayorista()
        With pagoCuentaCorrienteClienteMayorista
            .id_Cheque = Id_Cheque
            .id_Empresa = 0
            .Monto = Monto
            .FormaPago = txtFormaPago.Text
            .Fecha = dtpFecha.Value
            .Comprobante = Integer.Parse(txtComprobante.Text)
        End With

        Dim negCuentaCorrienteMovimiento As NegCuentaCorrienteClientesMayoristas = New NegCuentaCorrienteClientesMayoristas()
        negCuentaCorrienteMovimiento.NuevoPago(pagoCuentaCorrienteClienteMayorista, Id_Cliente)

    End Sub
End Class