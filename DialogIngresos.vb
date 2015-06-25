Public Class DialogIngresos
    Public ArrayProductos As New Collection
    Public id_Mercaderia As Integer = 0
    Dim Funciones As New Funciones

    Private Sub DialogIngresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCuentaCorriente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCuentaCorriente.Click
        Me.Close()
        Me.Dispose()
        'Si quiere realizar las etiquetas le muestro el formulario correspondiente.
        If (MessageBox.Show("Se llevará a cabo la generación de etiquetas, ¿Desea Continuar?.", "Ingreso de Mercadería", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes) Then
            'Seteo el cursor.
            Me.Cursor = Cursors.WaitCursor

            'Abro el form de Etiquetas.
            frmEtiquetasMasivas.ArrayProductos = ArrayProductos
            Funciones.ControlInstancia(frmEtiquetasMasivas).MdiParent = MDIContenedor
            Funciones.ControlInstancia(frmEtiquetasMasivas).Show()

            'Seteo el cursor.
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub BtnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPagar.Click
        'Seteo el cursor.
        Me.Cursor = Cursors.WaitCursor

        'Cierro el form.
        Me.Close()
        Me.Dispose()

        'Abro el form de Etiquetas.
        frmPagarMercaderia.ArrayProductos = ArrayProductos
        frmPagarMercaderia.id_Mercaderia = id_Mercaderia    
        Funciones.ControlInstancia(frmPagarMercaderia).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmPagarMercaderia).Show()

        'Seteo el cursor.
        Me.Cursor = Cursors.Arrow
    End Sub
End Class