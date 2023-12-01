Imports System.Threading.Tasks
Imports SistemaCinderella.Formularios.Comex
Imports SistemaCinderella.Formularios.Producto

Public Class frmColores
    Inherits Comun

    Private frmColoresViewModel As frmColoresViewModel

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        frmColoresViewModel = New frmColoresViewModel()
    End Sub

    Private Sub frmColores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmColoresViewModelBindingSource.DataSource = frmColoresViewModel
                          Await frmColoresViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmColoresViewModel.AltaAsync()
                          Await frmColoresViewModel.BuscarAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          TabColores.SelectedTab = TbListado
                      End Function)
    End Sub

    Private Sub Btn_Modificar_Click(sender As Object, e As EventArgs) Handles Btn_Modificar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmColoresViewModel.ModificarAsync()
                          Await frmColoresViewModel.BuscarAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          TabColores.SelectedTab = TbListado
                      End Function)
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        EjecutarAsync(Async Function() As Task
                          Dim Result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar el color?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                          If (Result = DialogResult.Yes) Then
                              Await frmColoresViewModel.EliminarAsync()
                              Await frmColoresViewModel.BuscarAsync()
                              MessageBox.Show(My.Resources.BorradoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                              TabColores.SelectedTab = TbListado
                          End If
                      End Function)
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmColoresViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub DG_Subcategorias_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DG_Colores.CellContentClick
        If DG_Colores.Columns(e.ColumnIndex).Name = "Eliminar" Then
            EjecutarAsync(Async Function() As Task
                              Dim Result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar el color?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                              If (Result = DialogResult.Yes) Then
                                  Dim color As ColorItemViewModel = CType(DG_Colores.CurrentRow.DataBoundItem, ColorItemViewModel)
                                  Await frmColoresViewModel.ObtenerSupplierAsync(color.Id)
                                  Await frmColoresViewModel.EliminarAsync()
                                  Await frmColoresViewModel.BuscarAsync()
                                  MessageBox.Show(My.Resources.BorradoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                              End If
                          End Function)
        ElseIf DG_Colores.Columns(e.ColumnIndex).Name = "Modificar" Then
            TabColores.SelectedTab = TbMod
        End If
    End Sub

    Private Sub DG_Subcategorias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Colores.CellDoubleClick
        TabColores.SelectedTab = TbMod
    End Sub

    Private Sub TabSuppliers_Selected(sender As Object, e As TabControlEventArgs) Handles TabColores.Selected
        If TabColores.SelectedTab.Name = TbMod.Name AndAlso DG_Colores.CurrentRow IsNot Nothing Then
            EjecutarAsync(Async Function() As Task
                              Dim supplier As ColorItemViewModel = CType(DG_Colores.CurrentRow.DataBoundItem, ColorItemViewModel)
                              Await frmColoresViewModel.ObtenerSupplierAsync(supplier.Id)
                          End Function)
        End If

        If TabColores.SelectedTab.Name = TbAlta.Name Then
            Ejecutar(Sub() frmColoresViewModel.LimpiarColorNuevo())
        End If
    End Sub

    Private Sub TabSuppliers_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabColores.Selecting
        If TabColores.SelectedTab.Name = TbMod.Name AndAlso DG_Colores.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un color para ser modificado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
        End If
    End Sub

    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
        EjecutarAsync(Async Function() As Task
                          frmColoresViewModel.Limpiar()
                          Await frmColoresViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        TabColores.SelectedTab = TbListado
    End Sub
End Class