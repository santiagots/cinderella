Imports System.ComponentModel
Imports System.Threading.Tasks
Imports Common.Core.Model
Imports Ventas.Core.Model.VentaAggregate

Public Class ChequeDetalle
    Private Sub Btn_Buscar_Cliente_Click(sender As Object, e As EventArgs) Handles Btn_Buscar_Cliente.Click
        Dim frmBuscarClienteMayorista As frmBuscarClienteMayorista = New frmBuscarClienteMayorista()
        frmBuscarClienteMayorista.ShowDialog()
        If frmBuscarClienteMayorista.clienteMayorista IsNot Nothing Then
            ClienteID.Text = frmBuscarClienteMayorista.clienteMayorista.Id
            ClienteNombre.Text = frmBuscarClienteMayorista.clienteMayorista.RazonSocial
        End If
    End Sub

    Private Sub Btn_Buscar_Librador_Click(sender As Object, e As EventArgs) Handles Btn_Buscar_Librador.Click
        Dim frmBuscarClienteMayorista As frmBuscarClienteMayorista = New frmBuscarClienteMayorista()
        frmBuscarClienteMayorista.ShowDialog()
        If frmBuscarClienteMayorista.clienteMayorista IsNot Nothing Then
            LibradorID.Text = frmBuscarClienteMayorista.clienteMayorista.Id
            LibradorNombre.Text = frmBuscarClienteMayorista.clienteMayorista.RazonSocial
        End If
    End Sub

    Private Async Function Btn_Agregar_Banco_ClickAsync(sender As Object, e As EventArgs) As Task Handles Btn_Agregar_Banco.Click
        Dim frmBanco As frmBanco = New frmBanco()
        frmBanco.ShowDialog()
        Await CargarBancosAsync()
    End Function

    Private Async Function CargarBancosAsync() As Task
        Dim BancosEmisores As BindingList(Of KeyValuePair(Of Integer?, String)) = New BindingList(Of KeyValuePair(Of Integer?, String))()
        Dim Bancos As List(Of Banco) = Await Task.Run(Function() Comunes.Servicio.ObtenerBancos())
        Bancos.ForEach(Sub(x) BancosEmisores.Add(New KeyValuePair(Of Integer?, String)(x.Id, x.Nombre)))
        BancosEmisores.Insert(0, New KeyValuePair(Of Integer?, String)(Nothing, "Selecciones una opción"))
        BancosEmisoresBindingSource.DataSource = BancosEmisores
    End Function

    Private Sub FechaDeposito_ValueChanged(sender As Object, e As EventArgs) Handles FechaDeposito.ValueChanged
        FechaVencimiento.Value = FechaDeposito.Value.AddDays(30)
    End Sub
End Class
