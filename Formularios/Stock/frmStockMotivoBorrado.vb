Imports System.Threading.Tasks
Imports SistemaCinderella.Formularios.Stock
Imports Model = Stock.Core.Model.BaseAgreggate


Public Class frmStockMotivoBorrado

    Dim frmStockMotivoViewModel As frmStockMotivoViewModel
    Dim stock As Model.Stock

    Sub New(stock As Model.Stock)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.stock = stock
    End Sub

    Private Sub frmStockMotivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          frmStockMotivoViewModel = New frmStockMotivoViewModel(stock)
                          FrmStockMotivoViewModelBindingSource.DataSource = frmStockMotivoViewModel

                          Await frmStockMotivoViewModel.CargarUsuario()
                      End Function)
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmStockMotivoViewModel.EliminarAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                      End Function)
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class