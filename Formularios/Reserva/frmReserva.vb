Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports SistemaCinderella.Formularios.Reserva
Imports Ventas.Core.Enum

Public Class frmReserva

    Public FrmReservaViewModel As frmReservaViewModel

    Public Sub New(frmReservaViewModel As frmReservaViewModel)
        ' This call is required by the designer.
        InitializeComponent()

        Me.FrmReservaViewModel = frmReservaViewModel
    End Sub

    Private Sub frmReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReservaDetalle1.ReservaDetalleBindingSource.DataSource = FrmReservaViewModel.ReservaDetalle
        Me.ReservaDetalle1.VentaDetalle1.VentaDetalleBindingSource.DataSource = FrmReservaViewModel.VentaDetalle
    End Sub

    Private Sub ReservaDetalle1_BuscarClick(sender As Object, e As EventArgs) Handles ReservaDetalle1.BuscarClick
        Ejecutar(Sub() FrmReservaViewModel.BuscarClienteMinorista())
    End Sub

    Private Sub ReservaDetalle1_ModoEntregaSelectedIndexChanged(sender As Object, e As EventArgs) Handles ReservaDetalle1.ModoEntregaSelectedIndexChanged
        Ejecutar(Sub()
                     Dim metodoEntrega As KeyValuePair(Of ReservaMetodoEntrega?, String) = ReservaDetalle1.cmbModoEntrega.SelectedItem
                     FrmReservaViewModel.ReservaDetalle.MetodoEntregaSeleccionado = New KeyValuePair(Of ReservaMetodoEntrega?, String)(metodoEntrega.Key, metodoEntrega.Value)
                 End Sub)
    End Sub

    Private Sub Btn_Finalizar_Click(sender As Object, e As EventArgs) Handles Btn_Finalizar.Click
        Ejecutar(Sub()
                     FrmReservaViewModel.Finalizar()
                     Me.DialogResult = DialogResult.OK
                 End Sub)
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub Ejecutar(accion As Action)
        Try
            accion()
        Catch ex As NegocioException
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class