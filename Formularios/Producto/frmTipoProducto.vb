Imports System.Threading.Tasks
Imports SistemaCinderella.Formularios.Producto

Public Class frmTipoProducto
    Inherits Comun

    Private frmTipoProductoViewModel As frmTipoProductoViewModel

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        frmTipoProductoViewModel = New frmTipoProductoViewModel()
    End Sub

    Private Sub frmTipoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          frmTipoProductoViewModelBindingSource.DataSource = frmTipoProductoViewModel
                          Await frmTipoProductoViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmTipoProductoViewModel.AltaAsync()
                          Await frmTipoProductoViewModel.BuscarAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          TabTipoProducto.SelectedTab = TbListado
                      End Function)
    End Sub

    Private Sub Btn_Modificar_Click(sender As Object, e As EventArgs) Handles Btn_Modificar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmTipoProductoViewModel.ModificarAsync()
                          Await frmTipoProductoViewModel.BuscarAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          TabTipoProducto.SelectedTab = TbListado
                      End Function)
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        EjecutarAsync(Async Function() As Task
                          Dim Result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar el tipo de producto?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                          If (Result = DialogResult.Yes) Then
                              Await frmTipoProductoViewModel.EliminarAsync()
                              Await frmTipoProductoViewModel.BuscarAsync()
                              MessageBox.Show(My.Resources.BorradoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                              TabTipoProducto.SelectedTab = TbListado
                          End If
                      End Function)
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmTipoProductoViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub DG_Subcategorias_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DG_TipoProducto.CellContentClick
        If DG_TipoProducto.Columns(e.ColumnIndex).Name = "Eliminar" Then
            EjecutarAsync(Async Function() As Task
                              Dim Result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar el tipo de producto?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                              If (Result = DialogResult.Yes) Then
                                  Dim color As TipoProductoItemViewModel = CType(DG_TipoProducto.CurrentRow.DataBoundItem, TipoProductoItemViewModel)
                                  Await frmTipoProductoViewModel.ObtenerSupplierAsync(color.Id)
                                  Await frmTipoProductoViewModel.EliminarAsync()
                                  Await frmTipoProductoViewModel.BuscarAsync()
                                  MessageBox.Show(My.Resources.BorradoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                              End If
                          End Function)
        ElseIf DG_TipoProducto.Columns(e.ColumnIndex).Name = "Modificar" Then
            TabTipoProducto.SelectedTab = TbMod
        End If
    End Sub

    Private Sub DG_Subcategorias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_TipoProducto.CellDoubleClick
        TabTipoProducto.SelectedTab = TbMod
    End Sub

    Private Sub TabSuppliers_Selected(sender As Object, e As TabControlEventArgs) Handles TabTipoProducto.Selected
        If TabTipoProducto.SelectedTab.Name = TbMod.Name AndAlso DG_TipoProducto.CurrentRow IsNot Nothing Then
            EjecutarAsync(Async Function() As Task
                              Dim supplier As TipoProductoItemViewModel = CType(DG_TipoProducto.CurrentRow.DataBoundItem, TipoProductoItemViewModel)
                              Await frmTipoProductoViewModel.ObtenerSupplierAsync(supplier.Id)
                          End Function)
        End If

        If TabTipoProducto.SelectedTab.Name = TbAlta.Name Then
            Ejecutar(Sub() frmTipoProductoViewModel.LimpiarColorNuevo())
        End If
    End Sub

    Private Sub TabSuppliers_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabTipoProducto.Selecting
        If TabTipoProducto.SelectedTab.Name = TbMod.Name AndAlso DG_TipoProducto.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un tipo de producto para ser modificado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
        End If
    End Sub

    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
        EjecutarAsync(Async Function() As Task
                          frmTipoProductoViewModel.Limpiar()
                          Await frmTipoProductoViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        TabTipoProducto.SelectedTab = TbListado
    End Sub
End Class