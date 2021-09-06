Imports System.Threading.Tasks
Imports Common.Core.Enum
Imports Negocio
Imports SistemaCinderella.Formularios.Facturacion
Imports Ventas.Core.Model.RemitoAgreggate
Imports Ventas.Core.Model.VentaAggregate

Public Class frmRemito

    Private Errores As NegManejadorErrores = New NegManejadorErrores()

    Private frmRemitoDetalleViewModel As frmRemitoDetalleViewModel

    Sub New(ventaModel As Venta)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        frmRemitoDetalleViewModel = New frmRemitoDetalleViewModel(ventaModel)
    End Sub

    Sub New(remitoModel As Remito, ventaModel As Venta)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        frmRemitoDetalleViewModel = New frmRemitoDetalleViewModel(remitoModel, ventaModel)
    End Sub

    Private Sub frmRemitoDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmRemitoDetalleViewModelBindingSource.DataSource = frmRemitoDetalleViewModel
                          Await frmRemitoDetalleViewModel.InicializarDatosAsync()
                      End Function)
    End Sub

    Private Sub Btn_Imprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click
        EjecutarAsync(Async Function() As Task
                          Await frmRemitoDetalleViewModel.GuardarAsync()
                          MessageBox.Show(My.Resources.GuardadoOk, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

                          frmRemitoDetalleViewModel.ImprimirRemito()

                          If (frmRemitoDetalleViewModel.CantidadBultos > 0 AndAlso
                              MessageBox.Show("¿Desea imprimir las etiquetas para los bultos?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

                              frmRemitoDetalleViewModel.ImprimirBulto()
                          End If
                      End Function)
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs)
        EjecutarAsync(Async Function() As Task

                      End Function)
    End Sub

    Private Sub DG_Productos_KeyPressEnter(sender As Object, e As KeyEventArgs) Handles DG_Productos.KeyPressEnter
        If (String.IsNullOrEmpty(DG_Productos.CurrentCell.EditedFormattedValue)) Then

            Dim nombreColumna As String = DG_Productos.Columns(DG_Productos.CurrentCell.ColumnIndex).Name

            If (nombreColumna = "ProductosMonto") Then
                DG_Productos.CurrentCell.Value = 0
            End If
        End If

        DG_Productos.NotifyCurrentCellDirty(True)
        DG_Productos.EndEdit()
        DG_Productos.NotifyCurrentCellDirty(False)

        Btn_Imprimir.Focus()
    End Sub

    Private Sub DG_Productos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Productos.CellEndEdit
        Ejecutar(
            Sub()
                Dim columnas As List(Of String) = New List(Of String) From {"ProductosMonto"}
                If (columnas.Any(Function(x) DG_Productos.Columns(e.ColumnIndex).Name = x)) Then
                    frmRemitoDetalleViewModel.ActualizarItemRemito(DG_Productos.CurrentRow.DataBoundItem)
                End If
            End Sub)
    End Sub

    'Sobresalto la celda que se está editando.
    Private Sub DG_Productos_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DG_Productos.EditingControlShowing
        RemoveHandler e.Control.LostFocus, New EventHandler(AddressOf moneda_LostFocus)

        If DG_Productos.Columns(DG_Productos.CurrentCell.ColumnIndex).Name = "ProductosMonto" Then
            'agrego los eventos al control TextBox 
            Dim textBox As TextBox = TryCast(e.Control, TextBox)
            If textBox IsNot Nothing Then
                AddHandler textBox.KeyPress, New KeyPressEventHandler(AddressOf moneda_KeyPress)
                AddHandler textBox.LostFocus, New EventHandler(AddressOf moneda_LostFocus)
            End If
        End If

        ' Obtenemos el estilo de la celda actual
        Dim style As DataGridViewCellStyle = e.CellStyle
        ' Mientras se edita la celda, aumentaremos la fuente
        ' y rellenaremos el color de fondo de la celda actual.
        With style
            .Font = New Font(style.Font.FontFamily, 10, FontStyle.Bold)
            .BackColor = Color.Red
            .ForeColor = Color.White
        End With
    End Sub

    Private Sub moneda_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim txt As TextBox = TryCast(sender, TextBox)
        If txt.Text.Trim = "" Then
            txt.Text = "0"
        End If
    End Sub

    Private Sub moneda_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
        End If

        Dim txt As TextBox = TryCast(sender, TextBox)
        Dim texto As String = txt.Text + e.KeyChar
        Dim cantidadComas = texto.Count(Function(x) x = ",")

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(Errores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 OrElse cantidadComas > 1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Btn_BuscarTransporte_Click(sender As Object, e As EventArgs) Handles Btn_BuscarTransporte.Click
        Ejecutar(Sub()
                     Dim frmTransporteBuscar As frmTransporteBuscar = New frmTransporteBuscar(TipoBase.Local)
                     If (frmTransporteBuscar.ShowDialog() = DialogResult.OK) Then
                         frmRemitoDetalleViewModel.AgregarTrasporte(frmTransporteBuscar.TransporteModel)
                     End If
                 End Sub)
    End Sub
End Class