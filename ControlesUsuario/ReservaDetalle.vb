
Imports Common.Core.Exceptions

Public Class ReservaDetalle
    Public Event BuscarClick As EventHandler
    Public Event ModoEntregaSelectedIndexChanged As EventHandler

    Private Sub Btn_BuscarConsumidorFinal_Click(sender As Object, e As EventArgs) Handles Btn_BuscarConsumidorFinal.Click
        RaiseEvent BuscarClick(sender, e)
    End Sub

    Private Sub cmbModoEntrega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModoEntrega.SelectedIndexChanged
        RaiseEvent ModoEntregaSelectedIndexChanged(sender, e)
    End Sub
End Class
