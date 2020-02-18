Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Common.Core.Exceptions
Imports Common.Core.Helper
Imports SistemaCinderella.Formularios.Cheque
Imports Ventas.Core.Model.VentaAggregate

Public Class frmChequeAdministracion

    Private chequeAdminnistracionViewModel As frmChequeAdministracionViewModel

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        chequeAdminnistracionViewModel = New frmChequeAdministracionViewModel(My.Settings.Sucursal)
        AddHandler txtImporteDesde.DataBindings(0).Parse, AddressOf NullParseHandler
        AddHandler txtImporteHasta.DataBindings(0).Parse, AddressOf NullParseHandler
    End Sub

    Private Sub FrmChequeAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmChequeAdministracionViewModelBindingSource.DataSource = chequeAdminnistracionViewModel
                          ucChequeDetalle.AutoScaleMode = AutoScaleMode.None
                          Await chequeAdminnistracionViewModel.CargarDatosAsync()
                          Await chequeAdminnistracionViewModel.BuscarAsync(ObtenerEstadosCheques(), ObtenerDestinoSalidaCheques())
                      End Function)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        EjecutarAsync(Async Function() As Task
                          Await chequeAdminnistracionViewModel.BuscarAsync(ObtenerEstadosCheques(), ObtenerDestinoSalidaCheques())
                      End Function)
    End Sub

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        SaveFileDialog.FileName = String.Format("Listado Cheques Sucursal {0}", My.Settings.NombreSucursal)
        SaveFileDialog.Filter = "Excel Files|*.xlsx;"

        If SaveFileDialog.ShowDialog() = DialogResult.OK Then
            Ejecutar(Sub()
                         chequeAdminnistracionViewModel.Exportar(SaveFileDialog.FileName, My.Settings.NombreSucursal)
                         MessageBox.Show("Se ha exportado el listado de cheques de forma exitosa", "Administración de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Information)
                     End Sub)

        End If
    End Sub

    Private Sub DgvCheques_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCheques.CellContentDoubleClick
        EjecutarAsync(Async Function() As Task
                          Dim chequeAdministracionItemViewModel As ChequeAdministracionItemViewModel = dgvCheques.CurrentRow.DataBoundItem
                          Await chequeAdminnistracionViewModel.CargarChequesAsync(chequeAdministracionItemViewModel.Id)
                          ucChequeDetalle.ChequeDetalleViewModelBindingSource.DataSource = chequeAdminnistracionViewModel.ChequeDetalle
                          tabAdministracion.SelectedTab = TabDetalle
                      End Function)
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        EjecutarAsync(Async Function() As Task
                          Await chequeAdminnistracionViewModel.CargarChequesAsync(chequeAdminnistracionViewModel.ChequeDetalle.Id)
                          ucChequeDetalle.ChequeDetalleViewModelBindingSource.DataSource = chequeAdminnistracionViewModel.ChequeDetalle
                      End Function)
    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        EjecutarAsync(Async Function() As Task
                          Await chequeAdminnistracionViewModel.Actualizar()
                          Await chequeAdminnistracionViewModel.BuscarAsync(ObtenerEstadosCheques(), ObtenerDestinoSalidaCheques())
                          MessageBox.Show("Los datos se han actualizado de forma correcta.", "Administración de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Information)
                      End Function)
    End Sub

    Private Sub dgvCheques_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCheques.CellFormatting

        If (dgvCheques.Columns(e.ColumnIndex).Name = "MarcaFacturado") Then
            e.Value = If(e.Value, "Si", "No")
        End If

        Dim cheque As ChequeAdministracionItemViewModel = chequeAdminnistracionViewModel.Cheques(e.RowIndex)

        'Si el cheque esta en fecha para ser cobrado lo resalto en verde
        If (cheque.Estado <> EstadoCheque.Salido AndAlso cheque.FechaDesposito.Date = Date.Now) Then
            e.CellStyle.BackColor = System.Drawing.Color.Green
        End If

        'Si el cheque esta vencido o faltan 7 dias para su vencimiento lo resalto en rojo
        If (cheque.Estado <> EstadoCheque.Salido AndAlso cheque.FechaVencimiento.Date < Date.Now.AddDays(7).Date) Then
            e.CellStyle.BackColor = Color.FromArgb(255, 255, 75, 58)

            'Si el cheque esta en fecha para ser cobrado lo resalto en verde
        ElseIf (cheque.Estado <> EstadoCheque.Salido AndAlso cheque.FechaDesposito.Date <= Date.Now) Then
            e.CellStyle.BackColor = Color.FromArgb(255, 0, 205, 106)
        End If
    End Sub

    Private Sub Ejecutar(accion As Action)
        Try
            accion()
        Catch ex As NegocioException
            Log.Error(ex)
            MessageBox.Show(ex.Message, "Facturación de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Administración de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Administración de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NullParseHandler(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If e.Value IsNot Nothing AndAlso String.IsNullOrEmpty(e.Value.ToString()) Then e.Value = Nothing
    End Sub

    Private Function ObtenerEstadosCheques() As List(Of EstadoCheque)
        Dim estados As List(Of EstadoCheque) = New List(Of EstadoCheque)
        For Each item As KeyValuePair(Of EstadoCheque?, String) In ListBoxEstado.SelectedItems
            estados.Add(item.Key.Value)
        Next
        Return estados
    End Function

    Private Function ObtenerDestinoSalidaCheques() As List(Of DestinoSalidaCheque)
        Dim destinoSalida As List(Of DestinoSalidaCheque) = New List(Of DestinoSalidaCheque)
        For Each item As KeyValuePair(Of DestinoSalidaCheque?, String) In ListBoxDestinoSalida.SelectedItems
            destinoSalida.Add(item.Key.Value)
        Next
        Return destinoSalida
    End Function
End Class