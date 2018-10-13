Imports Entidades

Public Class frmEtiquetas
    Dim Funciones As New Funciones
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim NegProductos As New Negocio.NegProductos
    Public EProductos As New Entidades.Productos

    Dim dsProductos As DataSet

    Private Sub frmEtiquetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProductos()
    End Sub

    Private Sub CargarProductos()
        'Obtengo el listado de productos guardados en cache
        dsProductos = NegProductos.ListadoProductos(True)

        'Armo una lista que contiene los nombres y codigos de todos los producto
        Dim listaNombreCodigoProductos As AutoCompleteStringCollection = New AutoCompleteStringCollection()

        listaNombreCodigoProductos.AddRange(dsProductos.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.Item("Nombre").ToString).ToArray())
        listaNombreCodigoProductos.AddRange(dsProductos.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.Item("Codigo").ToString).ToArray())

        txt_Codigo.AutoCompleteCustomSource = listaNombreCodigoProductos
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click

        If (String.IsNullOrEmpty(txt_Codigo.Text) Or String.IsNullOrEmpty(txtCantidad.Text)) Then
            MessageBox.Show("Debe ingresar un Producto y/o cantidad de etiquetas", "Administración de Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dr As DataRow = dsProductos.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x.Item("Nombre").ToString().ToUpper() = txt_Codigo.Text.ToUpper() Or x.Item("Codigo").ToString().ToUpper() = txt_Codigo.Text.ToUpper()).FirstOrDefault()
        Dim etiqueta As Etiqueta = New Etiqueta() With
            {.Codigo = dr("Codigo"),
            .Nombre = dr("Nombre"),
            .idProducto = dr("id_Producto"),
            .Cantiadad = Integer.Parse(txtCantidad.Text)}

        EtiquetaBindingSource.Add(etiqueta)
    End Sub

    'Click en generar reporte.
    Private Sub Btn_CrearReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CrearReporte.Click

        If (EtiquetaBindingSource.Count = 0) Then
            MessageBox.Show("Debe cargar un Producto para generar las etiquetas", "Administración de Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Cambio el cursor.
        Me.Cursor = Cursors.WaitCursor

        Dim frm As New frmReporteEtiquetas
        frm.MostrarPrecios = CkPrecios.Checked
        frm.Etiquetas = EtiquetaBindingSource.List
        Funciones.ControlInstancia(frm).MdiParent = MDIContenedor
        Funciones.ControlInstancia(frm).Show()

        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub SoloNumeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub


    Private Sub dgEtiquetas_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgEtiquetas.EditingControlShowing
        'Referenciamos el control TextBox subyacente en la celda actual.
        Dim cellTextBox As DataGridViewTextBoxEditingControl
        cellTextBox = TryCast(e.Control, DataGridViewTextBoxEditingControl)

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
End Class