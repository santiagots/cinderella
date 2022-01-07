Imports System.Configuration
Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Helper
Imports Datos
Imports SistemaCinderella.Formularios.Stock

Public Class frmStock

    Dim frmStockViewModel As frmStockViewModel

    Dim NegStock As New Negocio.NegStock
    Dim NegProductos As New Negocio.NegProductos

    Private Sub frmStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          frmStockViewModel = New frmStockViewModel(My.Settings.Sucursal)
                          frmStockViewModel.ElementosPorPagina = Paginado.ElementosPorPagina

                          FrmStockViewModelBindingSource.DataSource = frmStockViewModel
                          Await frmStockViewModel.CargarAsync()
                          Await frmStockViewModel.BuscarAsync()

                          AltaStockBindingSource.DataSource = frmStockViewModel.AltaStock

                          CargarNombreYCodigoDeProductos(txt_Codigo, frmStockViewModel.NombreCodigoProductos)
                          CargarNombreYCodigoDeProductos(txt_Codigo_mod, frmStockViewModel.NombreCodigoProductos)
                      End Function)
    End Sub

    'Limpio los filtros del buscador.
    Private Sub btn_Restablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Restablecer.Click
    End Sub

    'Realizo la busqueda - CLICK.
    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmStockViewModel.BuscarAsync()
                      End Function)
    End Sub


    'Al modificar el stock.
    Private Sub Btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modificar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmStockViewModel.ActualizarAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          TabStock.SelectedTab = TabListado
                          Await frmStockViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmStockViewModel.AltaAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

                          AltaStockBindingSource.ResetBindings(False)

                          TabStock.SelectedTab = TabListado
                          Await frmStockViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Eliminar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmStockViewModel.EliminarAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          TabStock.SelectedTab = TabListado
                          Await frmStockViewModel.BuscarAsync()
                      End Function)
    End Sub

    'doble click en el datagrid.
    Private Sub DG_Stock_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Stock.CellDoubleClick
        TabStock.SelectedTab = TabModificacion
    End Sub

    Private Sub DG_Stock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Stock.CellContentClick
        EjecutarAsync(Async Function() As Task
                          If DG_Stock.Columns(e.ColumnIndex).Name = "Eliminar" Then
                              Dim Result As DialogResult
                              Result = MessageBox.Show("¿Está seguro que desea eliminar el Stock?", "Administración de Stock", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                              If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                                  Dim StockItemViewModel As StockItemViewModel = DG_Stock.CurrentRow.DataBoundItem
                                  Dim frmStockMotivo As frmStockMotivoBorrado = New frmStockMotivoBorrado(StockItemViewModel.Stock)
                                  frmStockMotivo.ShowDialog()

                                  Await frmStockViewModel.BuscarAsync()
                                  TabStock.SelectedTab = TabListado
                              End If
                          End If
                          If DG_Stock.Columns(e.ColumnIndex).Name = "Modificar" Then
                              TabStock.SelectedTab = TabModificacion
                          End If

                          If DG_Stock.Columns(e.ColumnIndex).Name = "Reservado" Then
                              Dim StockItemViewModel As StockItemViewModel = DG_Stock.CurrentRow.DataBoundItem
                              Dim FrmStockEnNotaPedido As frmStockEnNotaPedido = New frmStockEnNotaPedido(StockItemViewModel.Stock.IdProducto, Me.MdiParent, AddressOf ActualizarPantallaCallback)
                              FrmStockEnNotaPedido.ShowDialog()
                          End If
                      End Function)
    End Sub

    Public Async Function ActualizarPantallaCallback() As Task
        EjecutarAsync(Async Function() As Task
                          Await frmStockViewModel.BuscarAsync()
                      End Function)
    End Function

    Private Sub TabStock_Selected(sender As Object, e As TabControlEventArgs) Handles TabStock.Selected
        Ejecutar(Sub()
                     If TabStock.SelectedTab Is TabModificacion AndAlso DG_Stock.CurrentRow IsNot Nothing Then
                         frmStockViewModel.Modificar(DG_Stock.CurrentRow.DataBoundItem)
                         ModificacionStockBindingSource.DataSource = frmStockViewModel.ModificacionStock
                     End If
                 End Sub)
    End Sub

    Private Sub Paginado_PaginaAnteriorClick(sender As Object, e As EventArgs) Handles Paginado.PaginaAnteriorClick
        EjecutarAsync(Async Function() As Task
                          frmStockViewModel.PaginaActual += -1
                          Await frmStockViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaFinalClick(sender As Object, e As EventArgs) Handles Paginado.PaginaFinalClick
        EjecutarAsync(Async Function() As Task
                          frmStockViewModel.PaginaActual = Paginado.TotalPaginas
                          Await frmStockViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaInicalClick(sender As Object, e As EventArgs) Handles Paginado.PaginaInicalClick
        EjecutarAsync(Async Function() As Task
                          frmStockViewModel.PaginaActual = 1
                          Await frmStockViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaSiguienteClick(sender As Object, e As EventArgs) Handles Paginado.PaginaSiguienteClick
        EjecutarAsync(Async Function() As Task
                          frmStockViewModel.PaginaActual += 1
                          Await frmStockViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub DG_Stock_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG_Stock.ColumnHeaderMouseClick
        EjecutarAsync(Async Function() As Task
                          If (DG_Stock.Columns(e.ColumnIndex).SortMode <> DataGridViewColumnSortMode.NotSortable) Then

                              Select Case DG_Stock.Columns(e.ColumnIndex).HeaderText
                                  Case "Codigo"
                                      frmStockViewModel.OrdenadoPor = "Producto.Codigo"
                                  Case "Nombre"
                                      frmStockViewModel.OrdenadoPor = "Producto.Nombre"
                                  Case "Minimo"
                                      frmStockViewModel.OrdenadoPor = "Minimo"
                                  Case "Optimo"
                                      frmStockViewModel.OrdenadoPor = "Optimo"
                                  Case "Actual"
                                      frmStockViewModel.OrdenadoPor = "Cantidad"
                                  Case "VentaMensual"
                                      frmStockViewModel.OrdenadoPor = "VentaMensual"

                              End Select

                              frmStockViewModel.DireccionOrdenamiento = If(frmStockViewModel.DireccionOrdenamiento = OrdenadoDireccion.ASC, OrdenadoDireccion.DESC, OrdenadoDireccion.ASC)
                              Await frmStockViewModel.BuscarAsync()

                              DG_Stock.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = If(frmStockViewModel.DireccionOrdenamiento = OrdenadoDireccion.ASC, SortOrder.Ascending, SortOrder.Descending)
                          End If
                      End Function)
    End Sub

    Public Sub CargarNombreYCodigoDeProductos(txt As TextBox, nombreCodigoProductos As List(Of String))
        Dim AutoCompleteStringCollection As AutoCompleteStringCollection = New AutoCompleteStringCollection()
        nombreCodigoProductos.ForEach(Sub(x) AutoCompleteStringCollection.Add(x))
        txt.AutoCompleteCustomSource = AutoCompleteStringCollection
        txt.Enabled = True
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_Administración_Crear)) Then

        Else
            TabStock.TabPages.Remove(TabStock.TabPages("TabAlta"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_Administración_Eliminar)) Then
            DG_Stock.Columns("Eliminar").Visible = True
            Btn_Eliminar.Enabled = True
        Else
            DG_Stock.Columns("Eliminar").Visible = False
            Btn_Eliminar.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Stock_Administración_Modificar)) Then
            DG_Stock.Columns("Modificar").Visible = True
        Else
            TabStock.TabPages.Remove(TabStock.TabPages("TabModificacion"))
            DG_Stock.Columns("Modificar").Visible = False
            RemoveHandler DG_Stock.CellDoubleClick, AddressOf DG_Stock_CellDoubleClick
        End If
    End Sub

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        Try
            'Configuro la pantalla de guardado de archivos
            SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            SaveFileDialog.FileName = String.Format("Stock_{0}", My.Settings.NombreSucursal)
            SaveFileDialog.Filter = "Excel Files|*.xlsx;"

            If SaveFileDialog.ShowDialog() = DialogResult.OK Then
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                frmCargadorDeEspera.Show()
                frmCargadorDeEspera.Text = "Generando Exportación a Excel "
                frmCargadorDeEspera.lbl_Descripcion.Text = "iniciando..."
                frmCargadorDeEspera.BarraProgreso.Minimum = 0
                frmCargadorDeEspera.BarraProgreso.Maximum = 5
                frmCargadorDeEspera.BarraProgreso.Value = 1
                frmCargadorDeEspera.Refresh()

                AddHandler NegProductos.UpdateProgress, AddressOf UpdateProgress

                'Exporto el listado de productos a Excel
                NegStock.ExportarExcelStock(My.Settings.Sucursal, SaveFileDialog.FileName, ConfigurationManager.AppSettings("ExportarExcelPlantillaProductoSucursal"))

                'Voy seteando la barra de progreso
                frmCargadorDeEspera.Close()
                frmCargadorDeEspera.Dispose()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                'si no completo la descripcion, muestro un msg de error.
                MessageBox.Show("Se ha exportado el listado de productos de forma exitosa", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            'Voy seteando la barra de progreso
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error en la exportación de la información. Verifique que el documento no se encuentre en uso o esté abierto. Por favor, intente más tarde.", "Administración de Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log.Error(ex)
        End Try
    End Sub

    Public Sub UpdateProgress(ProgressStep As Integer, ProgressText As String)
        frmCargadorDeEspera.lbl_Descripcion.Text = ProgressText
        frmCargadorDeEspera.BarraProgreso.Value = ProgressStep
        frmCargadorDeEspera.Refresh()
    End Sub

    Private Sub btn_Importar_Click(sender As Object, e As EventArgs) Handles btn_Importar.Click
        Try
            OpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            OpenFileDialog.Filter = "Excel Files|*.xlsx;"
            OpenFileDialog.FileName = String.Empty

            If OpenFileDialog.ShowDialog() = DialogResult.OK Then
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                frmCargadorDeEspera.Show()
                frmCargadorDeEspera.Text = "Generando Importación del Excel "
                frmCargadorDeEspera.lbl_Descripcion.Text = "iniciando..."
                frmCargadorDeEspera.BarraProgreso.Minimum = 0
                frmCargadorDeEspera.BarraProgreso.Maximum = 4
                frmCargadorDeEspera.BarraProgreso.Value = 1
                frmCargadorDeEspera.Refresh()

                AddHandler NegProductos.UpdateProgress, AddressOf UpdateProgress

                Dim Mensaje As String = NegStock.ImportarExcelStock(My.Settings.Sucursal, VariablesGlobales.objUsuario.id_Usuario, VariablesGlobales.objUsuario.Nombre, OpenFileDialog.FileName)

                'Voy seteando la barra de progreso
                frmCargadorDeEspera.Close()
                frmCargadorDeEspera.Dispose()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                MessageBox.Show(Mensaje, "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btn_Restablecer_Click(Nothing, Nothing)
            End If

        Catch ex As Exception
            'Voy seteando la barra de progreso
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error en la importación de la información. Por favor, intente más tarde.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Log.Error(ex)
        End Try
    End Sub
End Class