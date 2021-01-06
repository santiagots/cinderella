Imports System.Threading.Tasks
Imports SistemaCinderella.Formularios.CuentaBancaria

Public Class frmCuentaBancarias
    Inherits Comun

    Dim frmCuentaBancariasViewModel As frmCuentaBancariasViewModel = New frmCuentaBancariasViewModel()

    Private Sub frmCuentaBancarias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmCuentaBancariasViewModelBindingSource.DataSource = frmCuentaBancariasViewModel
                          AltaCuentaBancariaViewModelBindingSource.DataSource = frmCuentaBancariasViewModel.CuentaBancariaAlta
                          ModificacionCuentaBancariaViewModelBindingSource.DataSource = frmCuentaBancariasViewModel.CuentaBancariaModificar
                          Await frmCuentaBancariasViewModel.CargarBancosAsync()
                          frmCuentaBancariasViewModel.CargarHabilitado()
                          Await frmCuentaBancariasViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmCuentaBancariasViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmCuentaBancariasViewModel.AgregarAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          Await frmCuentaBancariasViewModel.BuscarAsync()
                          TabCuentasBancarias.SelectedTab = TbListado
                      End Function)
    End Sub

    Private Sub Btn_Modificar_Click(sender As Object, e As EventArgs) Handles Btn_Modificar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmCuentaBancariasViewModel.ModificarAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          Await frmCuentaBancariasViewModel.BuscarAsync()
                          TabCuentasBancarias.SelectedTab = TbListado
                      End Function)
    End Sub

    Private Sub Cb_Categorias_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbBancoAlta.SelectionChangeCommitted
        frmCuentaBancariasViewModel.CuentaBancariaAlta.BancoSeleccionado = cbBancoAlta.SelectedItem
    End Sub

    Private Sub ComboBox3_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbBancoModificacion.SelectionChangeCommitted
        frmCuentaBancariasViewModel.CuentaBancariaModificar.BancoSeleccionado = cbBancoModificacion.SelectedItem
    End Sub

    Private Sub DG_CuentasBancarias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_CuentasBancarias.CellClick
        Ejecutar(Sub()
                     If DG_CuentasBancarias.Columns(e.ColumnIndex).Name = "Modificar" Then
                         TabCuentasBancarias.SelectedTab = TbMod
                     End If
                 End Sub)
    End Sub

    Private Sub DG_CuentasBancarias_SelectionChanged(sender As Object, e As EventArgs) Handles DG_CuentasBancarias.SelectionChanged
        Ejecutar(Sub()
                     If (DG_CuentasBancarias.CurrentRow Is Nothing) Then
                         Return
                     End If

                     Dim cuentaBancariaItem As CuentaBancariaItem = CType(DG_CuentasBancarias.CurrentRow.DataBoundItem, CuentaBancariaItem)
                     frmCuentaBancariasViewModel.Cargar(cuentaBancariaItem)
                     ModificacionCuentaBancariaViewModelBindingSource.DataSource = frmCuentaBancariasViewModel.CuentaBancariaModificar
                 End Sub)
    End Sub

    Private Sub DG_CuentasBancarias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_CuentasBancarias.CellDoubleClick
        Ejecutar(Sub() TabCuentasBancarias.SelectedTab = TbMod)
    End Sub

    Private Sub Btn_Agregar_Banco2_Click(sender As Object, e As EventArgs) Handles Btn_Agregar_Banco2.Click, Btn_Agregar_Banco.Click
        EjecutarAsync(Async Function() As Task
                          Dim frmBanco As frmBanco = New frmBanco()
                          frmBanco.ShowDialog()

                          Await frmCuentaBancariasViewModel.CargarBancosAsync()
                      End Function)
    End Sub
End Class