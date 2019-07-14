Imports Negocio

Public Class frmInformacionTransacciones

    Private ControladorFiscal As NegControladorFiscal
    Dim NegErrores As New Negocio.NegManejadorErrores

    Private Sub frmInformacionTransacciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Me.Cursor = Cursors.WaitCursor
            ControladorFiscal = New NegControladorFiscal(My.Settings("ConexionControladora").ToString())

            ObtenerInformacionMemoriaTransacciones()

        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message, "Controlador Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al obtener los datos de la controladora fiscal. Por favor, vuelva a intentar más tarde o contáctese con el Administrador.", "Controlador Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Cursor = Cursors.Arrow
        End Try
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btn_BorrarJornada_Click(sender As Object, e As EventArgs) Handles btn_BorrarJornada.Click
        Try
            If (MessageBox.Show("Esta seguro que desea borrar jornadas fiscales.", "Controlador Fiscal", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
                ControladorFiscal.AbrirPuerto()
                ControladorFiscal.BorradoJornadasMemoriaTransacciones(My.Settings.ControladorModelo, txtBorrarJornadaHasta.Text)
                ControladorFiscal.CerrarPuerto()

                MessageBox.Show("Se han borrar las jornadas fiscales correctamente.", "Controlador Fiscal", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                ObtenerInformacionMemoriaTransacciones()
            End If
        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message, "Controlador Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Se ha producido un error al obtener los datos de la controladora fiscal. Por favor, vuelva a intentar más tarde o contáctese con el Administrador.", "Controlador Fiscal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_BorrarJornada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btn_BorrarJornada.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btn_BorrarJornada.Focus()
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub ObtenerInformacionMemoriaTransacciones()
        Dim DescargarCintaTestigoDigitalDesde As String = String.Empty
        Dim DescargarCintaTestigoDigitalHasta As String = String.Empty
        Dim DescargarDuplicadosTipoADesde As String = String.Empty
        Dim DescargarDuplicadosTipoAHasta As String = String.Empty
        Dim DescargarResumenTotalesDesde As String = String.Empty
        Dim DescargarResumenTotalesHasta As String = String.Empty
        Dim JornadasDescargadasCompletamenteDesde As String = String.Empty
        Dim JornadasDescargadasCompletamenteHasta As String = String.Empty
        Dim JornadasBorradasDesde As String = String.Empty
        Dim JornadasBorradasHasta As String = String.Empty

        ControladorFiscal.AbrirPuerto()
        ControladorFiscal.InformacionMemoriaTransacciones(My.Settings.ControladorModelo, DescargarCintaTestigoDigitalDesde, DescargarCintaTestigoDigitalHasta,
                                                          DescargarDuplicadosTipoADesde, DescargarDuplicadosTipoAHasta, DescargarResumenTotalesDesde, DescargarResumenTotalesHasta,
                                                          JornadasDescargadasCompletamenteDesde, JornadasDescargadasCompletamenteHasta, JornadasBorradasDesde, JornadasBorradasHasta)

        ControladorFiscal.CerrarPuerto()

        txtCitaTestigoDigitalDesde.Text = DescargarCintaTestigoDigitalDesde
        txtCitaTestigoDigitalHasta.Text = DescargarCintaTestigoDigitalHasta
        txtDupicadosTipoADesde.Text = DescargarDuplicadosTipoADesde
        txtDupicadosTipoAHasta.Text = DescargarDuplicadosTipoAHasta
        txtResumenTotalesDesde.Text = DescargarResumenTotalesDesde
        txtResumenTotalesHasta.Text = DescargarResumenTotalesHasta
        txtDescargasCompletasDesde.Text = JornadasDescargadasCompletamenteDesde
        txtDescargasCompletasHasta.Text = JornadasDescargadasCompletamenteHasta
        txtJornadasBorradasDesde.Text = JornadasBorradasDesde
        txtJornadasBorradasHasta.Text = JornadasBorradasHasta
    End Sub
End Class