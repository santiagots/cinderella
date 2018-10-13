Public Class frmCambios
    'Instancias
    Dim NegProductos As New Negocio.NegProductos
    Public IdProducto As String

    Private dsProductos As DataSet

    Private Sub frmCambios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Obtengo el listado de productos guardados en cache
        dsProductos = NegProductos.ListadoProductosBuscadores(True)

        'Armo una lista que contiene los nombres y codigos de todos los producto
        Dim listaNombreCodigoProductos As AutoCompleteStringCollection = New AutoCompleteStringCollection()

        listaNombreCodigoProductos.AddRange(dsProductos.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.Item("Nombre").ToString).ToArray())
        listaNombreCodigoProductos.AddRange(dsProductos.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.Item("Codigo").ToString).ToArray())

        txt_Codigo.AutoCompleteCustomSource = listaNombreCodigoProductos
    End Sub

    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub Btn_Finalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Finalizar.Click
        Me.Cursor = Cursors.WaitCursor
        BuscarProducto()
        Me.DialogResult = DialogResult.OK
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub txt_CodigoBarra_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Codigo.KeyDown
        If e.KeyData = Keys.Enter Then
            Me.Cursor = Cursors.WaitCursor
            BuscarProducto()
            Me.DialogResult = DialogResult.OK
            Me.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub BuscarProducto()
        Dim dr As DataRow = dsProductos.Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x.Item("Nombre").ToString().ToUpper() = txt_Codigo.Text.ToUpper() Or x.Item("Codigo").ToString().ToUpper() = txt_Codigo.Text.ToUpper()).FirstOrDefault()
        If (dr IsNot Nothing) Then
            IdProducto = dr(3)
        Else
            MessageBox.Show("El código o nombre de producto no existe. Por favor verifique la información ingresada sea la correcta.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class