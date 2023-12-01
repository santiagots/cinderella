Imports System.Threading.Tasks
Imports SistemaCinderella.Formularios.Comex
Imports SistemaCinderella.Formularios.Producto

Public Class frmSuppliers
    Inherits Comun

    Private frmSuppliersViewModel As frmSuppliersViewModel

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        frmSuppliersViewModel = New frmSuppliersViewModel()
    End Sub

    Private Sub frmSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmSuppliersViewModelBindingSource.DataSource = frmSuppliersViewModel
                          Await frmSuppliersViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmSuppliersViewModel.AltaAsync()
                          Await frmSuppliersViewModel.BuscarAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          TabSuppliers.SelectedTab = TbListado
                      End Function)
    End Sub

    Private Sub Btn_Modificar_Click(sender As Object, e As EventArgs) Handles Btn_Modificar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmSuppliersViewModel.ModificarAsync()
                          Await frmSuppliersViewModel.BuscarAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          TabSuppliers.SelectedTab = TbListado
                      End Function)
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        EjecutarAsync(Async Function() As Task
                          Dim Result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar el supplier?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                          If (Result = DialogResult.Yes) Then
                              Await frmSuppliersViewModel.EliminarAsync()
                              Await frmSuppliersViewModel.BuscarAsync()
                              MessageBox.Show(My.Resources.BorradoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                              TabSuppliers.SelectedTab = TbListado
                          End If
                      End Function)
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmSuppliersViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub DG_Subcategorias_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DG_Suppliers.CellContentClick
        If DG_Suppliers.Columns(e.ColumnIndex).Name = "Eliminar" Then
            EjecutarAsync(Async Function() As Task
                              Dim Result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar el supplier?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                              If (Result = DialogResult.Yes) Then
                                  Dim supplier As SupplierItemViewModel = CType(DG_Suppliers.CurrentRow.DataBoundItem, SupplierItemViewModel)
                                  Await frmSuppliersViewModel.ObtenerSupplierAsync(supplier.Id)
                                  Await frmSuppliersViewModel.EliminarAsync()
                                  Await frmSuppliersViewModel.BuscarAsync()
                                  MessageBox.Show(My.Resources.BorradoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                              End If
                          End Function)
        ElseIf DG_Suppliers.Columns(e.ColumnIndex).Name = "Modificar" Then
            TabSuppliers.SelectedTab = TbMod
        End If
    End Sub

    Private Sub DG_Subcategorias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Suppliers.CellDoubleClick
        TabSuppliers.SelectedTab = TbMod
    End Sub

    Private Sub TabSuppliers_Selected(sender As Object, e As TabControlEventArgs) Handles TabSuppliers.Selected
        If TabSuppliers.SelectedTab.Name = TbMod.Name AndAlso DG_Suppliers.CurrentRow IsNot Nothing Then
            EjecutarAsync(Async Function() As Task
                              Dim supplier As SupplierItemViewModel = CType(DG_Suppliers.CurrentRow.DataBoundItem, SupplierItemViewModel)
                              Await frmSuppliersViewModel.ObtenerSupplierAsync(supplier.Id)
                          End Function)
        End If

        If TabSuppliers.SelectedTab.Name = TbAlta.Name Then
            Ejecutar(Sub() frmSuppliersViewModel.LimpiarSupplierNuevo())
        End If
    End Sub

    Private Sub TabSuppliers_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabSuppliers.Selecting
        If TabSuppliers.SelectedTab.Name = TbMod.Name AndAlso DG_Suppliers.CurrentRow Is Nothing Then
            MessageBox.Show("Debe seleccionar un Supplier para ser modificado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
        End If
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        TabSuppliers.SelectedTab = TbListado
    End Sub

    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click
        EjecutarAsync(Async Function() As Task
                          frmSuppliersViewModel.Limpiar()
                          Await frmSuppliersViewModel.BuscarAsync()
                      End Function)
    End Sub
End Class