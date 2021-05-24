Imports System.Threading.Tasks
Imports Common.Core.Model
Imports SistemaCinderella.Formularios.CuentaBancaria

Public Class frmCuentaBancariasBuscar
    Inherits Comun

    ReadOnly Property CuentasBancariaSeleccionada As CuentaBancaria
        Get
            Dim CuentaBancariaItem As CuentaBancariaItem = DG_CuentasBancarias.CurrentRow.DataBoundItem
            Return CuentaBancariaItem.CuentaBancaria
        End Get
    End Property


    Dim frmCuentaBancariasBuscarViewModel As frmCuentaBancariasBuscarViewModel = New frmCuentaBancariasBuscarViewModel()

    Private Sub frmCuentaBancariasBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmCuentaBancariasBuscarViewModelBindingSource.DataSource = frmCuentaBancariasBuscarViewModel
                          Await frmCuentaBancariasBuscarViewModel.CargarBancosAsync()
                          Await frmCuentaBancariasBuscarViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmCuentaBancariasBuscarViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Btn_Limpiar_Click(sender As Object, e As EventArgs) Handles Btn_Limpiar.Click
        EjecutarAsync(Async Function() As Task
                          frmCuentaBancariasBuscarViewModel.Limpiar()
                          Await frmCuentaBancariasBuscarViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub DG_CuentasBancarias_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_CuentasBancarias.CellDoubleClick
        Ejecutar(Sub() Me.DialogResult = DialogResult.OK)
    End Sub

    Private Sub cmbBanco_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbBanco.SelectionChangeCommitted
        frmCuentaBancariasBuscarViewModel.BancoBusquedaSeleccionado = cmbBanco.SelectedItem
    End Sub
End Class