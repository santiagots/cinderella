Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports Common.Core.Helper
Imports SistemaCinderella.Formularios.Venta
Imports SistemaCinderella.VistaModelo.Ventas
Imports Ventas.Core.Model.BaseAgreggate

Public Class frmBuscarClienteMinorista

    Private frmBuscarClienteMinoristaViewModel As frmBuscarClienteMinoristaViewModel
    Public clienteMinorista As ClienteMinorista

    Private Sub frmBuscarClienteMinorista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmBuscarClienteMinoristaViewModel = New frmBuscarClienteMinoristaViewModel()
        FrmBuscarClienteMinoristaViewModelBindingSource.DataSource = frmBuscarClienteMinoristaViewModel
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        EjecutarAsync(
            Async Function() As Task
                Await frmBuscarClienteMinoristaViewModel.BuscarAsync()
            End Function)
    End Sub

    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            EjecutarAsync(
            Async Function() As Task
                Await frmBuscarClienteMinoristaViewModel.BuscarAsync()
            End Function)
        End If
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            EjecutarAsync(
            Async Function() As Task
                Await frmBuscarClienteMinoristaViewModel.BuscarAsync()
            End Function)
        End If
    End Sub

    Private Sub DG_Clientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Clientes.CellDoubleClick
        Ejecutar(
            Sub()
                clienteMinorista = DG_Clientes.CurrentRow.DataBoundItem
                Me.DialogResult = DialogResult.OK
            End Sub)
    End Sub

    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        Ejecutar(
         Sub()
             frmBuscarClienteMinoristaViewModel = New frmBuscarClienteMinoristaViewModel()
             FrmBuscarClienteMinoristaViewModelBindingSource.DataSource = frmBuscarClienteMinoristaViewModel
         End Sub)
    End Sub

    Private Sub Ejecutar(accion As Action)
        Try
            accion()
        Catch ex As NegocioException
            Log.Error(ex)
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub EjecutarAsync(accion As Func(Of Task))
        Try
            Await accion()
        Catch ex As NegocioException
            Log.Error(ex)
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class