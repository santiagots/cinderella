Imports System.Configuration
Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports Common.Core.Model
Imports Datos
Imports Producto.Core.Model.ProductoAgreggate
Imports SistemaCinderella.Formularios.Producto

Public Class frmProductos
    Dim NegProductos As New Negocio.NegProductos
    Dim fuc As New Funciones
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim NegProductosCat As New Negocio.NegProductosCategorias
    Dim NegProductosSubCat As New Negocio.NegProductosSubcategorias
    Dim NegProveedores As New Negocio.NegProveedores
    Dim NegAromas As New Negocio.NegAromas
    Dim NegMateriales As New Negocio.NegMateriales
    Dim NegColores As New Negocio.NegColores

    Private frmProductosViewModel As frmProductosViewModel

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        frmProductosViewModel = New frmProductosViewModel()
    End Sub

    Private Sub frmProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmProductosViewModelBindingSource.DataSource = frmProductosViewModel
                          ProductoAltaViewModelBindingSource.DataSource = frmProductosViewModel.ProductoNuevo
                          ProductoModificacionViewModelBindingSource.DataSource = frmProductosViewModel.ProductoDetalle
                          Await frmProductosViewModel.CargarDatosAsync()
                          EvaluarPermisos()
                          DG_Productos.Cursor = Cursors.Hand
                      End Function)
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmProductosViewModel.BuscarProductosAsync()
                      End Function)
    End Sub

    Private Sub txt_buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_buscar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            EjecutarAsync(Async Function() As Task
                              Await frmProductosViewModel.BuscarProductosAsync()
                          End Function)

            DG_Productos.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub btn_Restablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Restablecer.Click
        EjecutarAsync(Async Function() As Task
                          Await frmProductosViewModel.RestablecerProductosAsync()
                      End Function)

        DG_Productos.Cursor = Cursors.Hand
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click
        EjecutarAsync(Async Function() As Task
                          Await frmProductosViewModel.BuscarUltimaPaginaAsync()
                      End Function)

        DG_Productos.Cursor = Cursors.Hand
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        EjecutarAsync(Async Function() As Task
                          Await frmProductosViewModel.BuscarPaginaSiguienteAsync()
                      End Function)

        DG_Productos.Cursor = Cursors.Hand
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        EjecutarAsync(Async Function() As Task
                          Await frmProductosViewModel.BuscarPaginaAnteriorAsync()
                      End Function)

        DG_Productos.Cursor = Cursors.Hand
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        EjecutarAsync(Async Function() As Task
                          Await frmProductosViewModel.BuscarPrimerPaginaAsync()
                      End Function)

        DG_Productos.Cursor = Cursors.Hand
    End Sub

    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmProductosViewModel.AgregarProductoAsync()
                          MessageBox.Show("Los datos se han guardado de forma correcta", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                          TabProductos.SelectedTab = TabProductos.TabPages("TbListado")
                      End Function)
    End Sub

    Private Sub DG_Productos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Productos.CellDoubleClick
        TabProductos.SelectedTab = TabProductos.TabPages("TbMod")
    End Sub

    Private Sub TabProductos_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabProductos.Selected
        If TabProductos.SelectedTab.Name = "TbMod" AndAlso DG_Productos.CurrentRow IsNot Nothing Then
            EjecutarAsync(Async Function() As Task
                              Dim producto As ProductoItemViewModel = CType(DG_Productos.CurrentRow.DataBoundItem, ProductoItemViewModel)
                              Await frmProductosViewModel.CargarProductoAsync(producto.Id)
                              ProductoModificacionViewModelBindingSource.DataSource = frmProductosViewModel.ProductoDetalle
                          End Function)
        End If

        If TabProductos.SelectedTab.Name = "TbAlta" Then
            EjecutarAsync(Async Function() As Task
                              Await frmProductosViewModel.LimpiarProductoNuevo()
                              ProductoAltaViewModelBindingSource.DataSource = frmProductosViewModel.ProductoNuevo
                          End Function)
        End If
    End Sub

    Private Sub DG_Productos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Productos.CellContentClick
        If DG_Productos.Columns(e.ColumnIndex).Name = "Eliminar" Then
            EliminarProducto()
        ElseIf DG_Productos.Columns(e.ColumnIndex).Name = "Modificar" Then
            TabProductos.SelectedTab = TabProductos.TabPages("TbMod")
        End If
    End Sub

    Private Sub cb_Categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Categoria.SelectedIndexChanged
        EjecutarAsync(Async Function() As Task
                          Dim categoria As Categoria = CType(cb_Categoria.SelectedItem, Categoria)
                          If (categoria IsNot Nothing) Then
                              Await frmProductosViewModel.CargarSubcategoriasAsync(categoria.Id)
                          End If
                      End Function)
    End Sub

    Private Sub cb_Categoria_mod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Categoria_mod.SelectedIndexChanged
        EjecutarAsync(Async Function() As Task
                          Dim categoria As Categoria = CType(cb_Categoria_mod.SelectedItem, Categoria)
                          If (categoria IsNot Nothing) Then
                              Await frmProductosViewModel.CargarSubcategoriasAsync(categoria.Id)
                          End If
                      End Function)
    End Sub

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmProductosViewModel.ModificarProductoAsync()
                          Await frmProductosViewModel.BuscarPaginaActualAsync(True)
                          MessageBox.Show("Los datos se han guardado de forma correcta", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                          TabProductos.SelectedTab = TabProductos.TabPages("TbListado")
                      End Function)
    End Sub

    Private Sub Btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Eliminar.Click
        EliminarProducto()
    End Sub

    Private Sub EliminarProducto()
        If MessageBox.Show("¿Está seguro que desea eliminar el producto?", "Administración de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                                                = DialogResult.Yes Then

            EjecutarAsync(Async Function() As Task
                              Dim producto As ProductoItemViewModel = CType(DG_Productos.CurrentRow.DataBoundItem, ProductoItemViewModel)
                              Await frmProductosViewModel.EliminarProductoAsync(producto.Id)
                              Await frmProductosViewModel.BuscarPaginaActualAsync(True)
                              MessageBox.Show("El producto se ha eliminado.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                              TabProductos.SelectedTab = TabProductos.TabPages("TbListado")
                          End Function)
        End If
    End Sub

    Private Sub Ejecutar(accion As Action)
        Try
            Me.UseWaitCursor = True
            accion()
        Catch ex As NegocioException
            MessageBox.Show(ex.Message, "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.UseWaitCursor = False
        End Try
    End Sub

    Private Async Sub EjecutarAsync(accion As Func(Of Task))
        Try
            Me.UseWaitCursor = True
            Await accion()
        Catch ex As NegocioException
            MessageBox.Show(ex.Message, "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.UseWaitCursor = False
        End Try
    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        TabProductos.SelectedTab = TabProductos.TabPages("TbListado")
    End Sub

    Private Sub Categoria_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Categoria.SelectionChangeCommitted, cb_Categoria_mod.SelectionChangeCommitted

    End Sub

    'abro el open dialog para que seleccione una foto.
    Private Sub btn_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Open.Click, btn_Open_mod.Click
        Cargar.Title = "Seleccione una Fotografía" 'Título de la ventana que se abrirá para seleccionar el archivo.
        Cargar.Filter = "Jpg|*.jpg|Png|*.png|Gif|*.gif|Todos los archivos|*.*" 'Tipo de extensiones soportadas, fijaros como en la primera parte se pone el nombre, el que se quiera, después ponemos una barra vertical a modo de separación y ponemos *."extensión", el asterisco significa que nos permitirá cualquier nombre de archivo, la extensión hay que ponerla IGUAL que las que queramos abrir, lo de todos los archivos es opcional..
        Cargar.FilterIndex = 0 'Elegimos que se quede por defecto la primera extensión a la vista.
        Cargar.InitialDirectory = "C:\Documents and Settings\" & My.User.Name & "\Escritorio" 'Con esto haremos que el directorio inicial sea nuestro escritorio, podemos modificarlo a nuestro antojo si quisieramos abrirlo en mis documentos o en algún otro lugar lo ponemos y ya está.
        Cargar.RestoreDirectory = True 'De esta forma, mientras no cerremos la aplicación se "guardará" el último directorio seleccionado para no tener que elegirlo cada vez.
        Cargar.FileName = "" 'Con esto hacemos que al abrir la ventana no haya un nombre escrito.
        If Cargar.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Si pulsamos aceptar en la ventanita.
            'productoVistaModelo.ActualizarFoto(Cargar.FileName)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        Try
            'Configuro la pantalla de guardado de archivos
            SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            SaveFileDialog.FileName = "Productos"
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
                NegProductos.ExportarExcel(SaveFileDialog.FileName, ConfigurationManager.AppSettings("ExportarExcelPlantillaProducto"))

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
            MessageBox.Show("Se ha producido un error en la exportación de la información. Verifique que el documento no se encuentre en uso o esté abierto. Por favor, intente más tarde.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogHelper.WriteLog("ERROR Metodo: ExportarExcel" + Environment.NewLine + ex.ToString())
        End Try
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

                Dim DatosConError As DataTable = New DataTable()

                Dim Mensaje As String = NegProductos.ImportarExcel(OpenFileDialog.FileName, DatosConError)

                'Voy seteando la barra de progreso
                frmCargadorDeEspera.Close()
                frmCargadorDeEspera.Dispose()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                MessageBox.Show(Mensaje, "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Si se genero el backup habilito el boton de restaurar
                If (System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\ProductosBKP.xml")) Then
                    Me.ToolProd.SetToolTip(Me.btn_Restore, String.Format("Haz click aquí para restaurar la informacion del los productos con la ultima copia de seguridad con fecha {0}", System.IO.File.GetCreationTime(AppDomain.CurrentDomain.BaseDirectory + "\ProductosBKP.xml").ToString("dd/MM/yyyy hh:mm:ss")))
                Else
                    btn_Restore.Enabled = False
                End If

                'si en el proceso de importacion alguna fila modificada no fue importada por algun motivo 
                If (DatosConError.Rows.Count > 0) Then
                    'muestro en pantalla las filas con errores
                    Dim frmProductosErrorImportar As frmProductosErrorImportar = New frmProductosErrorImportar()

                    'Elimino la columna de ID para que no se muestre
                    DatosConError.Columns.RemoveAt(0)
                    frmProductosErrorImportar.productosError = DatosConError
                    frmProductosErrorImportar.ShowDialog()
                End If
            End If

        Catch ex As Exception
            'Voy seteando la barra de progreso
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()

            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha producido un error en la importación de la información. Por favor, intente más tarde.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)

            LogHelper.WriteLog("ERROR Metodo: ImportarExcel" + Environment.NewLine + ex.ToString())
        End Try
    End Sub

    Private Sub btn_Restore_Click(sender As Object, e As EventArgs) Handles btn_Restore.Click

        If (MessageBox.Show("Esta seguro que desea restaurar los valores de los productos en la base de datos?", "Administración de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Try
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                frmCargadorDeEspera.Show()
                frmCargadorDeEspera.Text = "Restaurando valores a la Base"
                frmCargadorDeEspera.lbl_Descripcion.Text = "iniciando..."
                frmCargadorDeEspera.BarraProgreso.Minimum = 0
                frmCargadorDeEspera.BarraProgreso.Maximum = 4
                frmCargadorDeEspera.BarraProgreso.Value = 1
                frmCargadorDeEspera.Refresh()

                AddHandler NegProductos.UpdateProgress, AddressOf UpdateProgress

                NegProductos.Restaurar()

                'Voy seteando la barra de progreso
                frmCargadorDeEspera.Close()
                frmCargadorDeEspera.Dispose()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow

                MessageBox.Show("Se han restaurado lo valores en la base de datos correctamente", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                'Voy seteando la barra de progreso
                frmCargadorDeEspera.Close()
                frmCargadorDeEspera.Dispose()

                'Cambio el cursor a "NORMAL"
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("Se ha producido un error en la restauracion de la información. Por favor, intente más tarde.", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Public Sub UpdateProgress(ProgressStep As Integer, ProgressText As String)
        frmCargadorDeEspera.lbl_Descripcion.Text = ProgressText
        frmCargadorDeEspera.BarraProgreso.Value = ProgressStep
        frmCargadorDeEspera.Refresh()
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Crear)) Then

        Else
            TabProductos.TabPages.Remove(TabProductos.TabPages("TbAlta"))
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Exportar)) Then
            btn_Exportar.Enabled = True
        Else
            btn_Exportar.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Importar)) Then
            btn_Importar.Enabled = True
        Else
            btn_Importar.Enabled = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Eliminar)) Then
            Btn_Eliminar.Enabled = True
            DG_Productos.Columns("Eliminar").Visible = True
        Else
            Btn_Eliminar.Enabled = False
            DG_Productos.Columns("Eliminar").Visible = False
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Productos_Administración_Modificar)) Then
            DG_Productos.Columns("Modificar").Visible = True
        Else
            TabProductos.TabPages.Remove(TabProductos.TabPages("TbMod"))
            DG_Productos.Columns("Modificar").Visible = False
            RemoveHandler DG_Productos.CellDoubleClick, AddressOf DG_Productos_CellDoubleClick
        End If
    End Sub
End Class