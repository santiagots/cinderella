Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports SistemaCinderella.Formularios.Producto

Public Class frmSubCategoria

    Private frmSubCategoriaViewModel As frmSubCategoriaViewModel

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        frmSubCategoriaViewModel = New frmSubCategoriaViewModel()
    End Sub

    'Load del formulario
    Private Sub frmProductosSubcat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmSubCategoriaViewModelBindingSource.DataSource = frmSubCategoriaViewModel
                          Await frmSubCategoriaViewModel.CargarDatosAsync()
                          EvaluarPermisos()
                      End Function)
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
        EjecutarAsync(Async Function() As Task
                          Await frmSubCategoriaViewModel.BuscarSubcategoriasAsync()
                      End Function)
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmSubCategoriaViewModel.AgregarSubcategoriaAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                      End Function)
    End Sub

    Private Sub Btn_Modificar_Click(sender As Object, e As EventArgs) Handles Btn_Modificar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmSubCategoriaViewModel.ActualizarSubcategoriaAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                      End Function)
    End Sub

    Private Sub DG_Subcategorias_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG_Subcategorias.ColumnHeaderMouseClick, DG_Buscador.ColumnHeaderMouseClick
        EjecutarAsync(Async Function() As Task
                          If (sender.Columns(e.ColumnIndex).SortMode <> DataGridViewColumnSortMode.NotSortable) Then
                              Select Case DG_Subcategorias.Columns(e.ColumnIndex).HeaderText
                                  Case "Categoría"
                                      frmSubCategoriaViewModel.SubcategoriaOrdenadoPor = "Categoria.Descripcion"
                                  Case "Subcategoría"
                                      frmSubCategoriaViewModel.SubcategoriaOrdenadoPor = "Descripcion"
                                  Case "Habilitado"
                                      frmSubCategoriaViewModel.SubcategoriaOrdenadoPor = "Habilitado"
                                  Case "IVA"
                                      frmSubCategoriaViewModel.SubcategoriaOrdenadoPor = "IVA.Valor"
                              End Select
                              frmSubCategoriaViewModel.SubcategoriaOrdenadoDireccion = If(frmSubCategoriaViewModel.SubcategoriaOrdenadoDireccion = OrdenadoDireccion.ASC, OrdenadoDireccion.DESC, OrdenadoDireccion.ASC)
                              Await frmSubCategoriaViewModel.BuscarSubcategoriasAsync()
                              ActualizarIconoOrdenamiento(DG_Subcategorias, frmSubCategoriaViewModel.SubcategoriaOrdenadoPor, frmSubCategoriaViewModel.SubcategoriaOrdenadoDireccion)
                              ActualizarIconoOrdenamiento(DG_Buscador, frmSubCategoriaViewModel.SubcategoriaOrdenadoPor, frmSubCategoriaViewModel.SubcategoriaOrdenadoDireccion)
                          End If
                      End Function)
    End Sub

    Private Sub DG_Subcategorias_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DG_Subcategorias.CellContentClick
        If DG_Subcategorias.Columns(e.ColumnIndex).Name = "Eliminar" Then
            ''TODO: ver como eliminar una subcategoria
        ElseIf DG_Subcategorias.Columns(e.ColumnIndex).Name = "Modificar" Then
            TabSubcategorias.SelectedTab = TabSubcategorias.TabPages("TbMod")
        End If
    End Sub

    Private Sub DG_Subcategorias_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Subcategorias.CellDoubleClick
        TabSubcategorias.SelectedTab = TabSubcategorias.TabPages("TbMod")
    End Sub

    Private Sub TabSubcategorias_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabSubcategorias.Selected
        If TabSubcategorias.SelectedTab.Name = "TbMod" AndAlso DG_Subcategorias.CurrentRow IsNot Nothing Then
            CargarSubcategoria(DG_Subcategorias)
        End If

        If TabSubcategorias.SelectedTab.Name = "TbAlta" Then
            Ejecutar(Sub() frmSubCategoriaViewModel.LimpiarProductoNuevo())
        End If

        ActualizarIconoOrdenamiento(DG_Subcategorias, frmSubCategoriaViewModel.SubcategoriaOrdenadoPor, frmSubCategoriaViewModel.SubcategoriaOrdenadoDireccion)
        ActualizarIconoOrdenamiento(DG_Buscador, frmSubCategoriaViewModel.SubcategoriaOrdenadoPor, frmSubCategoriaViewModel.SubcategoriaOrdenadoDireccion)
    End Sub

    Private Sub DG_Buscador_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Buscador.CellClick
        CargarSubcategoria(DG_Buscador)
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click, ToolStripButton3.Click
        EjecutarAsync(Async Function() As Task
                          frmSubCategoriaViewModel.PaginaActual += 1
                          Await frmSubCategoriaViewModel.BuscarSubcategoriasAsync()
                          ActualizarIconoOrdenamiento(DG_Subcategorias, frmSubCategoriaViewModel.SubcategoriaOrdenadoPor, frmSubCategoriaViewModel.SubcategoriaOrdenadoDireccion)
                          ActualizarIconoOrdenamiento(DG_Buscador, frmSubCategoriaViewModel.SubcategoriaOrdenadoPor, frmSubCategoriaViewModel.SubcategoriaOrdenadoDireccion)
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click, ToolStripButton4.Click
        EjecutarAsync(Async Function() As Task
                          frmSubCategoriaViewModel.PaginaActual = frmSubCategoriaViewModel.PaginasSubcategorias.Count - 1
                          Await frmSubCategoriaViewModel.BuscarSubcategoriasAsync()
                          ActualizarIconoOrdenamiento(DG_Subcategorias, frmSubCategoriaViewModel.SubcategoriaOrdenadoPor, frmSubCategoriaViewModel.SubcategoriaOrdenadoDireccion)
                          ActualizarIconoOrdenamiento(DG_Buscador, frmSubCategoriaViewModel.SubcategoriaOrdenadoPor, frmSubCategoriaViewModel.SubcategoriaOrdenadoDireccion)
                      End Function)
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click, ToolStripButton2.Click
        EjecutarAsync(Async Function() As Task
                          frmSubCategoriaViewModel.PaginaActual -= 1
                          Await frmSubCategoriaViewModel.BuscarSubcategoriasAsync()
                          ActualizarIconoOrdenamiento(DG_Subcategorias, frmSubCategoriaViewModel.SubcategoriaOrdenadoPor, frmSubCategoriaViewModel.SubcategoriaOrdenadoDireccion)
                          ActualizarIconoOrdenamiento(DG_Buscador, frmSubCategoriaViewModel.SubcategoriaOrdenadoPor, frmSubCategoriaViewModel.SubcategoriaOrdenadoDireccion)
                      End Function)
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click, ToolStripButton1.Click
        EjecutarAsync(Async Function() As Task
                          frmSubCategoriaViewModel.PaginaActual = 1
                          Await frmSubCategoriaViewModel.BuscarSubcategoriasAsync()
                          ActualizarIconoOrdenamiento(DG_Subcategorias, frmSubCategoriaViewModel.SubcategoriaOrdenadoPor, frmSubCategoriaViewModel.SubcategoriaOrdenadoDireccion)
                          ActualizarIconoOrdenamiento(DG_Buscador, frmSubCategoriaViewModel.SubcategoriaOrdenadoPor, frmSubCategoriaViewModel.SubcategoriaOrdenadoDireccion)
                      End Function)
    End Sub

    Private Sub CargarSubcategoria(Subcategorias As DataGridView)
        EjecutarAsync(Async Function() As Task
                          Dim subcategoria As SubcategoriaItemViewModel = CType(Subcategorias.CurrentRow.DataBoundItem, SubcategoriaItemViewModel)
                          Await frmSubCategoriaViewModel.CargarSubcategoriaAsync(subcategoria.Id)
                      End Function)
    End Sub

    Private Sub ActualizarIconoOrdenamiento(datagridview As DataGridView, OrdenadoPor As String, OrdenadoDireccion As OrdenadoDireccion)

        Dim cabeceraText As String = String.Empty

        Select Case OrdenadoPor
            Case "Categoria.Descripcion"
                cabeceraText = "Categoría"
            Case "Descripcion"
                cabeceraText = "Subcategoría"
            Case "Habilitado"
                cabeceraText = "Habilitado"
            Case "IVA.Valor"
                cabeceraText = "IVA"
        End Select

        Dim columna As DataGridViewColumn = datagridview.Columns.Cast(Of DataGridViewColumn).Where(Function(x) x.HeaderText = cabeceraText).FirstOrDefault()

        columna.HeaderCell.SortGlyphDirection = If(OrdenadoDireccion = OrdenadoDireccion.ASC, SortOrder.Ascending, SortOrder.Descending)
        datagridview.Refresh()
    End Sub

    Private Sub Ejecutar(accion As Action)
        Try
            Me.UseWaitCursor = True
            accion()
        Catch ex As NegocioException
            MessageBox.Show(ex.Message, "Administración de Subcategorías", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Administración de Subcategorías", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.UseWaitCursor = False
        End Try
    End Sub

    Private Async Sub EjecutarAsync(accion As Func(Of Task))
        Try
            Me.UseWaitCursor = True
            Await accion()
        Catch ex As NegocioException
            MessageBox.Show(ex.Message, "Administración de Subcategorías", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Administración de Subcategorías", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.UseWaitCursor = False
        End Try
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Subcategoría_Crear)) Then

        Else
            TabSubcategorias.TabPages.Remove(TabSubcategorias.TabPages("TbAlta"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Subcategoría_Eliminar)) Then
            DG_Subcategorias.Columns("Eliminar").Visible = True
            DG_Buscador.Columns("Eliminar_bus").Visible = True
        Else
            DG_Subcategorias.Columns("Eliminar").Visible = False
            DG_Buscador.Columns("Eliminar_bus").Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Subcategoría_Modificar)) Then
            DG_Subcategorias.Columns("Modificar").Visible = True
        Else
            TabSubcategorias.TabPages.Remove(TabSubcategorias.TabPages("TbMod"))
            DG_Subcategorias.Columns("Modificar").Visible = False
            RemoveHandler DG_Subcategorias.CellDoubleClick, AddressOf DG_Subcategorias_CellDoubleClick
        End If
    End Sub
End Class