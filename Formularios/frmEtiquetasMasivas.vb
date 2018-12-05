Imports System.Math
Public Class frmEtiquetasMasivas
    Dim Funciones As New Funciones
    Public ArrayProductos As New Collection
    Dim NegProductos As New Negocio.NegProductos
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim EProductos As New Entidades.Productos

    'Click en generar reporte.
    Private Sub Btn_CrearReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CrearReporte.Click
        'Cambio el cursor.
        Me.Cursor = Cursors.WaitCursor

        Dim frm As New frmReporteEtiquetasMasivas
        frm.numReportsDesde = Int16.Parse(txt_Desde.Text)
        If CkPrecios.Checked Then
            frm.MostrarPrecios = 1
        Else
            frm.MostrarPrecios = 0
        End If

        If ArrayProductos.Count <> 0 Then
            frm.ArrayProductos = ArrayProductos
            Funciones.ControlInstancia(frm).MdiParent = MDIContenedor
            Funciones.ControlInstancia(frm).Show()
        Else
            MessageBox.Show("No se encontraron productos.", "Administración de Etiquetas Masivas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        'Cambio el cursor.
        Me.Cursor = Cursors.Arrow
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

    Private Sub frmEtiquetasMasivas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cambio de Cursor.
        Me.Cursor = Cursors.WaitCursor

        'Cantidad de productos.
        lbl_Cantidad.Text = ArrayProductos.Count & " productos."

        'Cantidad de etiquetas
        Dim TotEtiquetas As Integer = 0
        For Each prod In ArrayProductos
            TotEtiquetas += prod.item(2)
        Next
        lbl_CantidadE.Text = TotEtiquetas & " etiquetas."

        'Cargo el listado de productos.
        lstProductos.Sorted = True
        For Each prod In ArrayProductos
            EProductos = NegProductos.TraerProducto(prod.item(1))
            lstProductos.Items.Add(EProductos.Nombre & " (" & prod.item(2) & ")")
        Next

        'Cambio de Cursor.
        Me.Cursor = Cursors.Arrow
    End Sub
End Class