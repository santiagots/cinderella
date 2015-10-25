Public Class frmCargarMercaderiaCantidad
    Public Codigo As String = ""
    Public Cantidad As String = ""
    Public Tipo As Integer = 0
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim NegStock As New Negocio.NegStock
    Dim EntProducto As New Entidades.Productos
    Dim NegProductos As New Negocio.NegProductos
    Dim id_Sucursal As Integer
    Private Sub frmCargarMercaderiaCantidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        id_Sucursal = My.Settings("Sucursal")
        lbl_Producto.Text = Codigo
        EntProducto = NegProductos.TraerProductoPorCodigo(Codigo) 'Traigo el producto.
        Dim entStock As New Entidades.Stock
        entStock = NegStock.TraerStockProducto(EntProducto.id_Producto, id_Sucursal)
        lblStock.Text = entStock.Stock_Actual


    End Sub

    'Boton Cerrar.
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    'Boton agregar.
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If txt_Cantidad.Text = "" Then
                MessageBox.Show("El campo Cantidad no puede estar vacio.", "Movimientos | Envió a Otras Sucursales | Cargar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Cantidad = Trim(txt_Cantidad.Text)
                frmCargarMercaderiaEgreso.AgregarItem(Codigo, Tipo, Cantidad)
                Me.Close()
                frmCargarMercaderiaEgreso.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Movimientos | Envió a Otras Sucursales | Cargar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Valido que sea solo numeros. - CANTIDAD y ACCION ENTER.
    Private Sub txt_Cantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cantidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            Try
                If txt_Cantidad.Text = "" Then
                    MessageBox.Show("El campo Cantidad no puede estar vacio.", "Movimientos | Envió a Otras Sucursales | Cargar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Cantidad = Trim(txt_Cantidad.Text)
                    frmCargarMercaderiaEgreso.AgregarItem(Codigo, Tipo, Cantidad)
                    Me.Close()
                    frmCargarMercaderiaEgreso.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Movimientos | Envió a Otras Sucursales | Cargar Mercaderías", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
            KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
            If KeyAscii = 0 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class