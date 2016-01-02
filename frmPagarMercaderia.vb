Public Class frmPagarMercaderia
    Public ArrayProductos As New Collection
    Public id_Mercaderia As Integer = 0
    Dim id_Sucursal As Integer = My.Settings("Sucursal")
    Dim Funciones As New Funciones
    Dim NegMerca As New Negocio.NegMercaderia
    Dim NegCuenta As New Negocio.NegCuentaCorriente
    Dim NegMov As New Negocio.NegMovimientos
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim ECuenta As New Entidades.Cuenta_Corriente
    Dim dsMercaderia As New DataSet

    'Load del formulario.
    Private Sub frmPagarMercaderia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LimpiarForm()
            If id_Mercaderia <> 0 Then
                Me.Cursor = Cursors.WaitCursor
                dsMercaderia = NegMerca.TraerMercaderia(id_Mercaderia)

                'Cargo los datos.
                lbl_Fecha.Text = Now.Date.ToShortDateString
                lbl_MontoTotal.Text = "$ " & Format(CType(dsMercaderia.Tables(0).Rows(0).Item("MontoTotal").ToString, Decimal), "###0.00") & ".-"
                txt_Monto.Text = Format(CType(dsMercaderia.Tables(0).Rows(0).Item("MontoTotal").ToString, Decimal), "###0.00")
                lbl_Proveedor.Text = dsMercaderia.Tables(0).Rows(0).Item("Proveedor").ToString
                lbl_Cantidad.Text = dsMercaderia.Tables(0).Rows(0).Item("CantidadTotal").ToString

                Me.Cursor = Cursors.Arrow
            Else
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("No se ha encontrado el registro de la mercadería ingresada.", "Ingreso de Mercadería", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar el formulario.", "Ingreso de Mercadería", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'funcion que borra el formulario.
    Sub LimpiarForm()
        lbl_Fecha.Text = "No disponible."
        lbl_Cantidad.Text = "No disponible."
        lbl_MontoTotal.Text = "No disponible."
        lbl_Proveedor.Text = "No disponible."
        txt_Monto.Clear()
        txt_Monto.Focus()
    End Sub

    'Volver al formulario de dialog.
    Private Sub Btn_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Volver.Click
        'Cierro el form.
        Me.Close()
        Me.Dispose()

        'Abro el form de consulta.
        DialogIngresos.ArrayProductos = ArrayProductos
        DialogIngresos.id_Mercaderia = id_Mercaderia
        Funciones.ControlInstancia(DialogIngresos).MdiParent = MDIContenedor
        Funciones.ControlInstancia(DialogIngresos).Show()
        Me.Close()
        Me.Dispose()
    End Sub

    'Boton que paga la mercaderia.
    Private Sub Btn_Pagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Pagar.Click
        Try
            'inserto el pago.
            Me.Cursor = Cursors.WaitCursor
            ECuenta.id_Mercaderia = 0
            ECuenta.Fecha = Now
            ECuenta.id_Proveedor = dsMercaderia.Tables(0).Rows(0).Item("id_Proveedor").ToString
            ECuenta.id_Sucursal = id_Sucursal
            ECuenta.Monto = Trim(txt_Monto.Text)

            If NegCuenta.AltaCuentaCorriente(ECuenta) = 0 Then
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("El pago no ha podido ser registrado. Por favor, consulte con el administrador.", "Ingreso de Mercadería", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Inserto el movimiento.
                Dim eGasto As New Entidades.MovGasto
                eGasto.id_Sucursal = id_Sucursal
                eGasto.id_Tipo = 20
                eGasto.Fecha = Now
                eGasto.Monto = Trim(txt_Monto.Text)
                NegMov.AltaMovGasto(eGasto)
                eGasto.SoloLectura = False

                Me.Cursor = Cursors.Arrow

                MessageBox.Show("El pago se ha efectuado correctamente.", "Ingreso de Mercadería", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar el formulario.", "Ingreso de Mercadería", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Valida que sea moneda.
    Private Sub txt_Monto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Monto.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            ErrorPago.SetError(txt_Monto, "Debe ingresar el monto en el formato permitido. Ejemplo: 725,50")
        Else
            ErrorPago.SetError(txt_Monto, Nothing)
        End If
    End Sub

End Class