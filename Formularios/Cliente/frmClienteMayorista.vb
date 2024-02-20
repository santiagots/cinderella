Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports SistemaCinderella.Formularios.Cliente
Imports SistemaCinderella.Formularios.Producto

Public Class frmClienteMayorista
    Inherits Comun

    Dim frmClienteMayoristaViewModel As frmClienteMayoristaViewModel = New frmClienteMayoristaViewModel()

    Private Sub frmClienteMayorista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmClienteMayoristaViewModelBindingSource.DataSource = frmClienteMayoristaViewModel
                          frmClienteMayoristaViewModel.ElementosPorPagina = Paginado.ElementosPorPagina
                          Await frmClienteMayoristaViewModel.CargarListaPreciosAsync()
                          Await frmClienteMayoristaViewModel.CargarProvinciasAsync()
                          Await frmClienteMayoristaViewModel.BuscarAsync()
                          AltaClienteMayoristaDetalleBindingSource.DataSource = frmClienteMayoristaViewModel.AltaClientes
                      End Function)
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmClienteMayoristaViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmClienteMayoristaViewModel.GuardarAsync()
                          Await frmClienteMayoristaViewModel.BuscarAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                      End Function)
    End Sub

    Private Sub Btn_Modificar_Click(sender As Object, e As EventArgs) Handles Btn_Modificar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmClienteMayoristaViewModel.ActualizarAsync()
                          Await frmClienteMayoristaViewModel.BuscarAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                      End Function)
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        EjecutarAsync(Async Function() As Task
                          Dim Result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar el cleinte?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                          If (Result = DialogResult.Yes) Then
                              Await frmClienteMayoristaViewModel.EliminarAsync()
                              Await frmClienteMayoristaViewModel.BuscarAsync()
                              MessageBox.Show(My.Resources.BorradoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                          End If
                          tabControl.SelectedTab = TbListado
                      End Function)
    End Sub

    Private Sub Btn_BuscarTransporte_Click(sender As Object, e As EventArgs) Handles Btn_BuscarTransporte.Click
        Ejecutar(Sub()
                     Dim frmTransporteBuscar As frmTransporteBuscar = New frmTransporteBuscar(TipoBase.Remota)
                     If (frmTransporteBuscar.ShowDialog = DialogResult.OK) Then
                         frmClienteMayoristaViewModel.AltaTransporte(frmTransporteBuscar.TransporteModel)
                         AltaClienteMayoristaDetalleBindingSource.ResetBindings(False)
                     End If
                 End Sub)
    End Sub

    Private Sub Btn_BuscarTransporte_Mod_Click(sender As Object, e As EventArgs) Handles Btn_BuscarTransporte_Mod.Click
        Ejecutar(Sub()
                     Dim frmTransporteBuscar As frmTransporteBuscar = New frmTransporteBuscar(TipoBase.Remota)
                     If (frmTransporteBuscar.ShowDialog = DialogResult.OK) Then
                         frmClienteMayoristaViewModel.ModificacionTransporte(frmTransporteBuscar.TransporteModel)
                         ModificacionClienteMayoristaDetalleBindingSource.ResetBindings(False)
                     End If
                 End Sub)
    End Sub

    Private Sub cb_Provincia_Facturacion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_Provincia_Facturacion.SelectionChangeCommitted
        EjecutarAsync(Async Function() As Task
                          If cb_Provincia_Facturacion.SelectedItem Is Nothing Then
                              Return
                          End If

                          frmClienteMayoristaViewModel.AltaClientes.FacturacionProvinciasSaleccionada = cb_Provincia_Facturacion.SelectedItem.Key

                          frmClienteMayoristaViewModel.AltaClientes.FacturacionDistritos = Await frmClienteMayoristaViewModel.CargarDistritoAsync(cb_Provincia_Facturacion.SelectedItem.Key)
                          frmClienteMayoristaViewModel.AltaClientes.FacturacionDistritosSaleccionada = frmClienteMayoristaViewModel.AltaClientes.FacturacionDistritos.First().Key

                          frmClienteMayoristaViewModel.AltaClientes.FacturacionLocalidades = Await frmClienteMayoristaViewModel.CargarLocalidadAsync(frmClienteMayoristaViewModel.AltaClientes.FacturacionDistritosSaleccionada)
                          frmClienteMayoristaViewModel.AltaClientes.FacturacionLocalidadesSaleccionada = frmClienteMayoristaViewModel.AltaClientes.FacturacionLocalidades.First().Key

                          AltaClienteMayoristaDetalleBindingSource.ResetBindings(False)
                      End Function)
    End Sub

    Private Sub cb_Provincia_Entrega_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_Provincia_Entrega.SelectionChangeCommitted
        EjecutarAsync(Async Function() As Task
                          If cb_Provincia_Entrega.SelectedItem Is Nothing Then
                              Return
                          End If

                          frmClienteMayoristaViewModel.AltaClientes.EntregaProvinciasSaleccionada = cb_Provincia_Entrega.SelectedItem.Key

                          frmClienteMayoristaViewModel.AltaClientes.EntregaDistritos = Await frmClienteMayoristaViewModel.CargarDistritoAsync(frmClienteMayoristaViewModel.AltaClientes.EntregaProvinciasSaleccionada)
                          frmClienteMayoristaViewModel.AltaClientes.EntregaDistritosSaleccionada = frmClienteMayoristaViewModel.AltaClientes.EntregaDistritos.First().Key

                          frmClienteMayoristaViewModel.AltaClientes.EntregaLocalidades = Await frmClienteMayoristaViewModel.CargarLocalidadAsync(frmClienteMayoristaViewModel.AltaClientes.EntregaDistritosSaleccionada)
                          frmClienteMayoristaViewModel.AltaClientes.EntregaLocalidadesSaleccionada = frmClienteMayoristaViewModel.AltaClientes.EntregaLocalidades.First().Key

                          AltaClienteMayoristaDetalleBindingSource.ResetBindings(False)
                      End Function)
    End Sub

    Private Sub cb_Provincia_Facturacion_Mod_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_Provincia_Facturacion_Mod.SelectionChangeCommitted
        EjecutarAsync(Async Function() As Task
                          If cb_Provincia_Facturacion_Mod.SelectedItem Is Nothing Then
                              Return
                          End If

                          frmClienteMayoristaViewModel.ModificacionClientes.FacturacionProvinciasSaleccionada = cb_Provincia_Facturacion_Mod.SelectedItem.Key

                          frmClienteMayoristaViewModel.ModificacionClientes.FacturacionDistritos = Await frmClienteMayoristaViewModel.CargarDistritoAsync(frmClienteMayoristaViewModel.ModificacionClientes.FacturacionProvinciasSaleccionada)
                          frmClienteMayoristaViewModel.ModificacionClientes.FacturacionDistritosSaleccionada = frmClienteMayoristaViewModel.ModificacionClientes.FacturacionDistritos.First().Key

                          frmClienteMayoristaViewModel.ModificacionClientes.FacturacionLocalidades = Await frmClienteMayoristaViewModel.CargarLocalidadAsync(frmClienteMayoristaViewModel.ModificacionClientes.FacturacionDistritosSaleccionada)
                          frmClienteMayoristaViewModel.ModificacionClientes.FacturacionLocalidadesSaleccionada = frmClienteMayoristaViewModel.ModificacionClientes.FacturacionLocalidades.First().Key

                          ModificacionClienteMayoristaDetalleBindingSource.ResetBindings(False)
                      End Function)
    End Sub

    Private Sub cb_Provincia_Entrega_Mod_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_Provincia_Entrega_Mod.SelectionChangeCommitted
        EjecutarAsync(Async Function() As Task
                          If cb_Provincia_Entrega_Mod.SelectedItem Is Nothing Then
                              Return
                          End If

                          frmClienteMayoristaViewModel.ModificacionClientes.EntregaProvinciasSaleccionada = cb_Provincia_Entrega_Mod.SelectedItem.Key

                          frmClienteMayoristaViewModel.ModificacionClientes.EntregaDistritos = Await frmClienteMayoristaViewModel.CargarDistritoAsync(frmClienteMayoristaViewModel.ModificacionClientes.EntregaProvinciasSaleccionada)
                          frmClienteMayoristaViewModel.ModificacionClientes.EntregaDistritosSaleccionada = frmClienteMayoristaViewModel.ModificacionClientes.EntregaDistritos.First().Key

                          frmClienteMayoristaViewModel.ModificacionClientes.EntregaLocalidades = Await frmClienteMayoristaViewModel.CargarLocalidadAsync(frmClienteMayoristaViewModel.ModificacionClientes.EntregaDistritosSaleccionada)
                          frmClienteMayoristaViewModel.ModificacionClientes.EntregaLocalidadesSaleccionada = frmClienteMayoristaViewModel.ModificacionClientes.EntregaLocalidades.First().Key

                          ModificacionClienteMayoristaDetalleBindingSource.ResetBindings(False)
                      End Function)
    End Sub

    Private Sub cb_Distrito_Facturacion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_Distrito_Facturacion.SelectionChangeCommitted
        EjecutarAsync(Async Function() As Task
                          If cb_Distrito_Facturacion.SelectedItem Is Nothing Then
                              Return
                          End If

                          frmClienteMayoristaViewModel.AltaClientes.FacturacionDistritosSaleccionada = cb_Distrito_Facturacion.SelectedItem.Key
                          frmClienteMayoristaViewModel.AltaClientes.FacturacionLocalidades = Await frmClienteMayoristaViewModel.CargarLocalidadAsync(frmClienteMayoristaViewModel.AltaClientes.FacturacionDistritosSaleccionada)
                          frmClienteMayoristaViewModel.AltaClientes.FacturacionLocalidadesSaleccionada = frmClienteMayoristaViewModel.AltaClientes.FacturacionLocalidades.First().Key
                          AltaClienteMayoristaDetalleBindingSource.ResetBindings(False)
                      End Function)
    End Sub

    Private Sub cb_Distrito_Entrega_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_Distrito_Entrega.SelectionChangeCommitted
        EjecutarAsync(Async Function() As Task
                          If cb_Distrito_Entrega.SelectedItem Is Nothing Then
                              Return
                          End If

                          frmClienteMayoristaViewModel.AltaClientes.EntregaDistritosSaleccionada = cb_Distrito_Entrega.SelectedItem.Key
                          frmClienteMayoristaViewModel.AltaClientes.EntregaLocalidades = Await frmClienteMayoristaViewModel.CargarLocalidadAsync(frmClienteMayoristaViewModel.AltaClientes.EntregaDistritosSaleccionada)
                          frmClienteMayoristaViewModel.AltaClientes.EntregaLocalidadesSaleccionada = frmClienteMayoristaViewModel.AltaClientes.EntregaLocalidades.First().Key
                          AltaClienteMayoristaDetalleBindingSource.ResetBindings(False)
                      End Function)
    End Sub

    Private Sub cb_Distrito_Facturacion_Mod_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_Distrito_Facturacion_Mod.SelectionChangeCommitted
        EjecutarAsync(Async Function() As Task
                          If cb_Distrito_Facturacion_Mod.SelectedItem Is Nothing Then
                              Return
                          End If

                          frmClienteMayoristaViewModel.ModificacionClientes.FacturacionDistritosSaleccionada = cb_Distrito_Facturacion_Mod.SelectedItem.Key
                          frmClienteMayoristaViewModel.ModificacionClientes.FacturacionLocalidades = Await frmClienteMayoristaViewModel.CargarLocalidadAsync(frmClienteMayoristaViewModel.ModificacionClientes.FacturacionDistritosSaleccionada)
                          frmClienteMayoristaViewModel.ModificacionClientes.FacturacionLocalidadesSaleccionada = frmClienteMayoristaViewModel.ModificacionClientes.FacturacionLocalidades.First().Key
                          ModificacionClienteMayoristaDetalleBindingSource.ResetBindings(False)
                      End Function)
    End Sub

    Private Sub cb_Distrito_Entrega_Mod_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cb_Distrito_Entrega_Mod.SelectionChangeCommitted
        EjecutarAsync(Async Function() As Task
                          If cb_Distrito_Entrega_Mod.SelectedItem Is Nothing Then
                              Return
                          End If

                          frmClienteMayoristaViewModel.ModificacionClientes.EntregaDistritosSaleccionada = cb_Distrito_Entrega_Mod.SelectedItem.Key
                          frmClienteMayoristaViewModel.ModificacionClientes.EntregaLocalidades = Await frmClienteMayoristaViewModel.CargarLocalidadAsync(frmClienteMayoristaViewModel.ModificacionClientes.EntregaDistritosSaleccionada)
                          frmClienteMayoristaViewModel.ModificacionClientes.EntregaLocalidadesSaleccionada = frmClienteMayoristaViewModel.ModificacionClientes.EntregaLocalidades.First().Key
                          ModificacionClienteMayoristaDetalleBindingSource.ResetBindings(False)
                      End Function)
    End Sub

    Private Sub DG_Clientes_SelectionChanged(sender As Object, e As EventArgs) Handles DG_Clientes.SelectionChanged
        EjecutarAsync(Async Function() As Task
                          If (DG_Clientes.CurrentRow Is Nothing) Then
                              Return
                          End If

                          Dim cliente As ClienteMayoristaItem = CType(DG_Clientes.CurrentRow.DataBoundItem, ClienteMayoristaItem)
                          Await frmClienteMayoristaViewModel.CargarClienteAsync(cliente.ClienteMayorista)
                          ModificacionClienteMayoristaDetalleBindingSource.DataSource = frmClienteMayoristaViewModel.ModificacionClientes
                      End Function)
    End Sub

    Private Sub DG_Clientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Clientes.CellClick
        EjecutarAsync(Async Function() As Task
                          If DG_Clientes.Columns(e.ColumnIndex).Name = "CuentaCorriente" Then
                              CargarCuentaCorriente(DG_Clientes.CurrentRow.DataBoundItem, Me.MdiParent)
                          End If
                          If DG_Clientes.Columns(e.ColumnIndex).Name = "Modificar" Then
                              tabControl.SelectedTab = TbMod
                          End If
                          If DG_Clientes.Columns(e.ColumnIndex).Name = "Eliminar" Then
                              Dim Result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar el cliente?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                              If (Result = DialogResult.Yes) Then
                                  Await frmClienteMayoristaViewModel.EliminarAsync()
                                  Await frmClienteMayoristaViewModel.BuscarAsync()
                                  MessageBox.Show(My.Resources.BorradoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                              End If
                          End If
                      End Function)
    End Sub

    Private Sub DG_Clientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Clientes.CellDoubleClick
        Ejecutar(Sub()
                     CargarCuentaCorriente(DG_Clientes.CurrentRow.DataBoundItem, Me.MdiParent)
                 End Sub)
    End Sub

    Private Sub DG_Clientes_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG_Clientes.ColumnHeaderMouseClick
        EjecutarAsync(Async Function() As Task
                          If (DG_Clientes.Columns(e.ColumnIndex).SortMode <> DataGridViewColumnSortMode.NotSortable) Then
                              frmClienteMayoristaViewModel.OrdenadoPor = DG_Clientes.Columns(e.ColumnIndex).DataPropertyName
                              frmClienteMayoristaViewModel.DireccionOrdenamiento = If(frmClienteMayoristaViewModel.DireccionOrdenamiento = OrdenadoDireccion.ASC, OrdenadoDireccion.DESC, OrdenadoDireccion.ASC)

                              Await frmClienteMayoristaViewModel.BuscarAsync()

                              DG_Clientes.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = If(frmClienteMayoristaViewModel.DireccionOrdenamiento = OrdenadoDireccion.ASC, SortOrder.Ascending, SortOrder.Descending)
                          End If
                      End Function)
    End Sub

    Private Sub Paginado_PaginaAnteriorClick(sender As Object, e As EventArgs) Handles Paginado.PaginaAnteriorClick
        EjecutarAsync(Async Function() As Task
                          frmClienteMayoristaViewModel.PaginaActual += -1
                          Await frmClienteMayoristaViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaFinalClick(sender As Object, e As EventArgs) Handles Paginado.PaginaFinalClick
        EjecutarAsync(Async Function() As Task
                          frmClienteMayoristaViewModel.PaginaActual = Paginado.TotalPaginas
                          Await frmClienteMayoristaViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaInicalClick(sender As Object, e As EventArgs) Handles Paginado.PaginaInicalClick
        EjecutarAsync(Async Function() As Task
                          frmClienteMayoristaViewModel.PaginaActual = 1
                          Await frmClienteMayoristaViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub Paginado_PaginaSiguienteClick(sender As Object, e As EventArgs) Handles Paginado.PaginaSiguienteClick
        EjecutarAsync(Async Function() As Task
                          frmClienteMayoristaViewModel.PaginaActual += 1
                          Await frmClienteMayoristaViewModel.BuscarAsync()
                      End Function)
    End Sub

    Friend Sub CargarCuentaCorriente(clienteMayoristaItem As ClienteMayoristaItem, mdiParent As Form)
        Dim frmClienteMayoristaCuentaCorriente As frmClienteMayoristaCuentaCorriente = New frmClienteMayoristaCuentaCorriente(clienteMayoristaItem.ClienteMayorista, AddressOf CargarCuentaCorrienteCallback)
        frmClienteMayoristaCuentaCorriente.MdiParent = mdiParent
        frmClienteMayoristaCuentaCorriente.Show()
        Hide()
    End Sub

    Public Sub CargarCuentaCorrienteCallback()
        EjecutarAsync(Async Function() As Task
                          Show()
                          Await frmClienteMayoristaViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub DG_Clientes_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DG_Clientes.CellFormatting
        Ejecutar(Sub()

                     Dim ClienteMayoristaItem As ClienteMayoristaItem = DG_Clientes.Rows(e.RowIndex).DataBoundItem

                     If (ClienteMayoristaItem.CuentaCorrienteMonto = 0) Then
                         Return
                     End If

                     If (ClienteMayoristaItem.CuentaCorrienteMonto > 0) Then
                         e.CellStyle.BackColor = VariablesGlobales.colorFondoOk
                         e.CellStyle.ForeColor = VariablesGlobales.colorTextoOk
                     Else
                         e.CellStyle.BackColor = VariablesGlobales.colorFondoAlerta
                         e.CellStyle.ForeColor = VariablesGlobales.colorTextoAlerta
                     End If
                 End Sub)
    End Sub

    Sub EvaluarPermisos()
        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cliente_Mayorista_Crear)) Then

        Else
            tabControl.TabPages.Remove(TbAlta)
        End If

        If (VariablesGlobales.Patentes.ContainsKey(Entidades.TipoPatente.Administración_Cliente_Mayorista_Modificar)) Then
            DG_Clientes.Columns("Modificar").Visible = True
        Else
            tabControl.TabPages.Remove(TbMod)
            DG_Clientes.Columns("Modificar").Visible = False
        End If
    End Sub
End Class