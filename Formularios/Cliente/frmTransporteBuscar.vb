Imports System.Threading.Tasks
Imports AutoMapper
Imports Common.Core.Enum
Imports Common.Core.Model
Imports SistemaCinderella.Formularios.Cliente

Public Class frmTransporteBuscar
    Inherits Comun

    Public TransporteModel As Transporte

    Dim frmTransporteBuscarViewModel As frmTransporteBuscarViewModel

    Sub New(ObtenerDatosDesde As TipoBase)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        frmTransporteBuscarViewModel = New frmTransporteBuscarViewModel(ObtenerDatosDesde)
    End Sub

    Private Sub frmTransporteBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmTransporteBuscarViewModelBindingSource.DataSource = frmTransporteBuscarViewModel
                          frmTransporteBuscarViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmTransporteBuscarViewModel.BuscarAsync()
                      End Function)
    End Sub

    Private Sub txt_Buscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Buscar.KeyDown
        EjecutarAsync(Async Function() As Task
                          If e.KeyData = Keys.Enter Then
                              Await frmTransporteBuscarViewModel.BuscarAsync()
                          End If
                      End Function)
    End Sub

    Private Sub DG_Clientes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Clientes.CellDoubleClick
        Ejecutar(Sub()
                     Dim transporteViewModel As TransporteViewModel = DG_Clientes.CurrentRow.DataBoundItem

                     TransporteModel = Mapper.Map(Of Transporte)(transporteViewModel)
                     Me.DialogResult = DialogResult.OK
                 End Sub)
    End Sub

    Private Sub Btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpiar.Click
        EjecutarAsync(Async Function() As Task
                          Await frmTransporteBuscarViewModel.LimpiarAsync()
                      End Function)
    End Sub
End Class