Public Class frmBuscarPrecioProductos
    Dim NegProductos As New Negocio.NegProductos

    'Boton cancelar, cierra el form.
    Private Sub Btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        Me.Close()
    End Sub

    'Boton Consultar precio.
    Private Sub Btn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Consultar.Click
        Try
            'Seteo el cursor.
            Me.Cursor = Cursors.WaitCursor

            If txt_Codigo.Text = "" Then
                MessageBox.Show("Debe ingresar el código de producto.", "Consultar Precio de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Try
                    'Inicio variables.
                    Dim Codigo, Precio As String
                    Codigo = Trim(txt_Codigo.Text)

                    'Consulto el precio.
                    Precio = NegProductos.TraerPrecio(Codigo, My.Settings("ListaPrecio"))

                    If Precio <> "" Then
                        lblPrecio.Text = Format(Precio, "Currency")
                    Else
                        lblPrecio.Text = "No disponible."
                    End If
                Catch ex As Exception
                    MessageBox.Show("Se ha encontrado un error al consultar el precio del producto. Por favor, vuelva a intentar más tarde o contáctese con el Administrador", "Consultar Precio de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            'Seteo los controles.
            txt_Codigo.Clear()
            txt_Codigo.Focus()

            'Seteo el cursor.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al consultar el precio del producto", "Consultar Precio de Producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Enter en campo de codigo, busca el precio del producto.
    Private Sub txt_Codigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Codigo.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True

                'Seteo el cursor.
                Me.Cursor = Cursors.WaitCursor

                If txt_Codigo.Text = "" Then
                    MessageBox.Show("Debe ingresar el código de producto.", "Consultar Precio de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Try
                        'Inicio variables.
                        Dim Codigo, Precio As String
                        Codigo = Trim(txt_Codigo.Text)

                        'Consulto el precio.
                        Precio = NegProductos.TraerPrecio(Codigo, My.Settings("ListaPrecio"))

                        If Precio <> "" Then
                            lblPrecio.Text = Format(Precio, "Currency")
                        Else
                            lblPrecio.Text = "No disponible."
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Se ha encontrado un error al consultar el precio del producto.", "Consultar Precio de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
                'Seteo los controles.
                txt_Codigo.Clear()
                txt_Codigo.Focus()

                'Seteo el cursor.
                Me.Cursor = Cursors.Arrow

            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al consultar el precio del producto", "Consultar Precio de Producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try        
    End Sub

End Class