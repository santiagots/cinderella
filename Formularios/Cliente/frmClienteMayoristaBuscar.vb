Imports System.Threading.Tasks
Imports Common.Core.Model
Imports SistemaCinderella.Formularios.Cliente

Public Class frmClienteMayoristaBuscar
    Inherits Comun

    Dim frmClienteMayoristaBuscarViewModel As frmClienteMayoristaBuscarViewModel = New frmClienteMayoristaBuscarViewModel()
    Public Property ClienteMayorista As ClienteMayorista


    Private Sub frmBuscarClienteMayorista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmClienteMayoristaBuscarViewModelBindingSource.DataSource = frmClienteMayoristaBuscarViewModel
                          Await frmClienteMayoristaBuscarViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmClienteMayoristaBuscarViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub txt_Buscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Buscar.KeyDown
        EjecutarAsync(Async Function() As Task
                          If e.KeyData = Keys.Enter Then
                              Await frmClienteMayoristaBuscarViewModel.BuscarAsync()
                          End If
                      End Function)
    End Sub

    Private Sub DG_Clientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Clientes.CellDoubleClick
        Ejecutar(Sub()
                     Dim clienteMayoristaItem As ClienteMayoristaItem = DG_Clientes.CurrentRow.DataBoundItem
                     ClienteMayorista = clienteMayoristaItem.ClienteMayorista
                     Close()
                 End Sub)
    End Sub

    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmClienteMayoristaBuscarViewModel.LimpiarAsync()
                      End Function)
    End Sub
End Class