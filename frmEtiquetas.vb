Public Class frmEtiquetas
    Dim Funciones As New Funciones
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim NegProductos As New Negocio.NegProductos
    Public EProductos As New Entidades.Productos

    'Click en generar reporte.
    Private Sub Btn_CrearReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CrearReporte.Click
        'Cambio el cursor.
        Me.Cursor = Cursors.WaitCursor

        Dim numImages As Int16
        Dim frm As New frmReporteEtiquetas
        numImages = Int16.Parse(txt_Numero.Text)
        If numImages > 66 Then
            MessageBox.Show("No se pueden mostrar más de 66 etiquetas.", "Administración de Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_Numero.Focus()
            Return
        ElseIf numImages < 1 Then
            MessageBox.Show("Como mínimo debe mostrarse una etiqueta.", "Administración de Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_Numero.Focus()
            Return
        End If
        frm.numReports = Int16.Parse(txt_Numero.Text) + Int16.Parse(txt_Desde.Text)
        frm.numReportsDesde = Int16.Parse(txt_Desde.Text)
        If CkPrecios.Checked Then
            frm.MostrarPrecios = 1
        Else
            frm.MostrarPrecios = 0
        End If

        If EProductos.id_Producto <> 0 Then
            frm.Codigo = txt_Codigo.Text
            Funciones.ControlInstancia(frm).MdiParent = MDIContenedor
            Funciones.ControlInstancia(frm).Show()
        Else
            MessageBox.Show("El código de producto ingresado es erróneo.", "Administración de Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        'Cambio el cursor.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Valido que ingrese solo numeros en el campo "Numero de Etiquetas".
    Private Sub txt_Numero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Numero.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valido que complete el campo "Numero de Etiquetas".
    Private Sub txt_Numero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Numero.TextChanged
        If txt_Numero.Text = "" Then
            ErrorEtiquetas.SetError(txt_Numero, "Debe completar el número de etiquetas.")
        Else
            ErrorEtiquetas.SetError(txt_Numero, Nothing)
        End If
    End Sub

    'Valido que ingrese solo numeros en el campo "Desde".
    Private Sub txt_Desde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Desde.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valido que complete el campo "Desde".
    Private Sub txt_Desde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Desde.TextChanged
        If txt_Desde.Text = "" Then
            ErrorEtiquetas.SetError(txt_Desde, "Debe completar el número desde donde se imprimen las etiquetas.")
        Else
            ErrorEtiquetas.SetError(txt_Desde, Nothing)
        End If
    End Sub

    Private Sub Btn_BuscarCodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_BuscarCodigo.Click
        'Cambio el cursor.
        Me.Cursor = Cursors.WaitCursor

        Funciones.ControlInstancia(frmBuscarCodigoProducto).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frmBuscarCodigoProducto).Show()
        frmBuscarCodigoProducto.TipoForm = 3

        'Cambio el cursor.
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub txt_Codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Codigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            'Cambio el cursor.
            Me.Cursor = Cursors.WaitCursor

            'lleno la entidad productos
            EProductos = NegProductos.TraerProducto(NegProductos.TraerID(txt_Codigo.Text))
            If EProductos.id_Producto <> 0 Then
                lbl_Producto.Text = EProductos.Nombre
            Else
                lbl_Producto.Text = "Producto no disponible."
            End If

            txt_Numero.Focus()

            'Cambio el cursor.
            Me.Cursor = Cursors.Arrow
        End If

    End Sub

    Private Sub txt_Codigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Codigo.LostFocus
        'Cambio el cursor.
        Me.Cursor = Cursors.WaitCursor

        'lleno la entidad productos
        EProductos = NegProductos.TraerProducto(NegProductos.TraerID(txt_Codigo.Text))
        If EProductos.id_Producto <> 0 Then
            lbl_Producto.Text = EProductos.Nombre
        Else
            lbl_Producto.Text = "Producto no disponible."
        End If

        'Cambio el cursor.
        Me.Cursor = Cursors.Arrow
    End Sub

End Class