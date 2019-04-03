Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports SistemaCinderella.VistaModelo.Ventas

Public Class frmReservaAdminitracion

    Public frmReservaAdministracionViewModel As frmReservaAdministracionViewModel


    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        frmReservaAdministracionViewModel = New frmReservaAdministracionViewModel()
    End Sub

    Private Sub frmReservaAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmReservaAdministracionViewModelBindingSource.DataSource = frmReservaAdministracionViewModel
                          ReservaDetalle1.AutoScaleMode = AutoScaleMode.None
                          ReservaDetalle1.Btn_BuscarConsumidorFinal.Visible = False
                          frmReservaAdministracionViewModel.CargarMetodosEntregas()
                          Await frmReservaAdministracionViewModel.BuscarReservaAsync()
                      End Function)
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmReservaAdministracionViewModel.BuscarReservaAsync()
                      End Function)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        EjecutarAsync(Async Function() As Task
                          If DataGridView1.Columns(e.ColumnIndex).Name = "ReservaEliminar" Then
                              Await frmReservaAdministracionViewModel.EliminarReservaAsync(DataGridView1.CurrentRow.DataBoundItem)
                          End If

                          If DataGridView1.Columns(e.ColumnIndex).Name = "ReservaImprimir" Then
                              Await frmReservaAdministracionViewModel.ImprimirReservaAsync(DataGridView1.CurrentRow.DataBoundItem, Me.MdiParent)
                          End If

                          ReservaDetalle1.ReservaDetalleBindingSource.DataSource = frmReservaAdministracionViewModel.ReservaDetalleSeleccionada
                          ReservaDetalle1.VentaDetalle1.VentaDetalleBindingSource.DataSource = frmReservaAdministracionViewModel.VentaDetalleSeleccionada
                      End Function)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        EjecutarAsync(Async Function() As Task
                          Await frmReservaAdministracionViewModel.CargarReservaAsync(DataGridView1.CurrentRow.DataBoundItem)
                          ReservaDetalle1.ReservaDetalleBindingSource.DataSource = frmReservaAdministracionViewModel.ReservaDetalleSeleccionada
                          ReservaDetalle1.VentaDetalle1.VentaDetalleBindingSource.DataSource = frmReservaAdministracionViewModel.VentaDetalleSeleccionada
                          tabAdministracionReservas.SelectedTab = tabDetalle
                      End Function)
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        frmReservaAdministracionViewModel.RetirarVenta(Me.MdiParent)
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

    Private Async Sub EjecutarAsync(accion As Func(Of Task))
        Try
            Await accion()
        Catch ex As NegocioException
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class