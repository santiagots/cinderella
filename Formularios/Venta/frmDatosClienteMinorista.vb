Imports Ventas.Core.Model.BaseAgreggate

Public Class frmDatosClienteMinorista

    Public ClienteMinorista As ClienteMinorista

    Private Sub Btn_BuscarConsumidorFinal_Click(sender As Object, e As EventArgs) Handles Btn_BuscarConsumidorFinal.Click
        Dim frmBuscarClienteMinorista As frmBuscarClienteMinorista = New frmBuscarClienteMinorista()
        If (frmBuscarClienteMinorista.ShowDialog() = DialogResult.OK) Then
            ClienteMinorista = frmBuscarClienteMinorista.clienteMinorista
            txt_Apellido.Text = ClienteMinorista.Apellido
            txt_Nombre.Text = ClienteMinorista.Nombre
        End If
    End Sub

    Private Sub Btn_Finalizar_Click(sender As Object, e As EventArgs) Handles Btn_Finalizar.Click
        If (String.IsNullOrEmpty(txt_Apellido.Text) And String.IsNullOrEmpty(txt_Apellido.Text)) Then
            MessageBox.Show("Debe completar los campos requeridos.", "Datos Cliente Minorista", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If (ClienteMinorista Is Nothing) Then
            Dim negClienteMinorista As Negocio.NegClienteMinorista = New Negocio.NegClienteMinorista()
            ClienteMinorista = New ClienteMinorista(txt_Nombre.Text, txt_Apellido.Text)
            VistaModelo.Ventas.Servicio.GuardarClienteMinorista(ClienteMinorista)
        End If

        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmDatosClienteMinorista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class