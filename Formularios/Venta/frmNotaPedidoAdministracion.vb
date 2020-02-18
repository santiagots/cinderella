Imports Negocio
Imports Entidades
Imports System.Linq
Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports SistemaCinderella.Formularios.Venta
Imports Common.Core.Helper

Public Class frmNotaPedidoAdministracion

    Public notaPedidoViewModel As frmNotaPedidoAdministracionViewModel

    Private Sub frmNotaPedidoAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          notaPedidoViewModel = New frmNotaPedidoAdministracionViewModel(My.Settings.Sucursal)

                          NotaPedidoBindingSource.DataSource = notaPedidoViewModel
                          Await notaPedidoViewModel.CargarDatosAsync()
                      End Function)
        Me.DataBindings.Add(New Binding("Visible", Me.NotaPedidoBindingSource, "Visible", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        EjecutarAsync(Async Function() As Task
                          Await notaPedidoViewModel.Buscar()
                      End Function)
    End Sub

    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
        EjecutarAsync(Async Function() As Task
                          Await notaPedidoViewModel.RestablecerAsync()
                      End Function)
    End Sub


    Private Sub dgNotasPedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgNotasPedidos.CellContentClick
        EjecutarAsync(
            Async Function() As Task
                If dgNotasPedidos.Columns(e.ColumnIndex).Name = "Eliminar" Then
                    Await notaPedidoViewModel.EliminarNotaPedidoAsync(dgNotasPedidos.CurrentRow.DataBoundItem)
                    MessageBox.Show("Se ha eliminado la nota de pedido correctamente", "Administración Nota Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                If dgNotasPedidos.Columns(e.ColumnIndex).Name = "Imprimir" Then
                    notaPedidoViewModel.ImprimirNotaPedido(dgNotasPedidos.CurrentRow.DataBoundItem, Me.MdiParent)
                End If
            End Function)
    End Sub

    Private Sub dgNotasPedidos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgNotasPedidos.CellContentDoubleClick
        Ejecutar(Sub() notaPedidoViewModel.CargarVenta(dgNotasPedidos.CurrentRow.DataBoundItem, Me.MdiParent))
    End Sub

    Private Sub Ejecutar(accion As Action)
        Try
            accion()
        Catch ex As NegocioException
            Log.Error(ex)
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Administración Nota Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Administración Nota Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class