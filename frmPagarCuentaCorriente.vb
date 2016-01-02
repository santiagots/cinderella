Public Class frmPagarCuentaCorriente
    Dim id_Sucursal As Integer = My.Settings("Sucursal")
    Dim NombreSucursal As String = My.Settings("NombreSucursal")
    Dim Funciones As New Funciones
    Dim NegCuenta As New Negocio.NegCuentaCorriente
    Dim NegMov As New Negocio.NegMovimientos
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim NegProveedores As New Negocio.NegProveedores
    Dim NegSucursal As New Negocio.NegSucursales
    Dim ECuenta As New Entidades.Cuenta_Corriente

    'Boton que efectua el pago.
    Private Sub Btn_Pagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Pagar.Click
        Try
            'inserto el pago.
            Me.Cursor = Cursors.WaitCursor
            ECuenta.id_Mercaderia = 0
            ECuenta.Fecha = txt_Fecha.Value
            ECuenta.id_Proveedor = Cb_Proveedores.SelectedValue
            ECuenta.id_Sucursal = Cb_Sucursales.SelectedValue
            ECuenta.Monto = Trim(txt_Monto.Text)

            If NegCuenta.AltaCuentaCorriente(ECuenta) = 0 Then
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("El pago no ha podido ser registrado. Por favor, consulte con el administrador.", "Ingreso de Mercadería", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Inserto el movimiento.
                Dim eGasto As New Entidades.MovGasto
                eGasto.id_Sucursal = id_Sucursal
                eGasto.id_Tipo = 20
                eGasto.Fecha = txt_Fecha.Value
                eGasto.Monto = Trim(txt_Monto.Text)
                eGasto.id_Registro = NegCuenta.ObtenerUltimoID()
                eGasto.SoloLectura = False

                NegMov.AltaMovGasto(eGasto)

                LimpiarForm()
                Me.Cursor = Cursors.Arrow
                MessageBox.Show("El pago se ha efectuado correctamente.", "Ingreso de Mercadería", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()
                Me.Dispose()
                frmProveedoresCuentaCorriente.WindowState = FormWindowState.Normal
                If VariablesGlobales.objUsuario.id_Perfil = 1 Then 'si es administrador
                    frmProveedoresCuentaCorriente.RecargarListadoAdministrador()
                Else
                    frmProveedoresCuentaCorriente.RecargarListadoEncargado()
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

    'funcion que borra el formulario.
    Sub LimpiarForm()
        txt_Fecha.Value = Now
        Cb_Proveedores.SelectedItem = Nothing
        Cb_Sucursales.SelectedItem = Nothing
        txt_Monto.Clear()
        txt_Monto.Focus()
    End Sub

    'Load.
    Private Sub frmPagarCuentaCorriente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            LimpiarForm()

            'Cargo las sucursales
            Dim dsSucursales As New DataSet
            dsSucursales = NegSucursal.ListadoSucursales()
            If dsSucursales.Tables(0).Rows.Count > 0 Then
                Cb_Sucursales.DataSource = Nothing
                Cb_Sucursales.DataSource = dsSucursales.Tables(0)
                Cb_Sucursales.DisplayMember = "Nombre"
                Cb_Sucursales.ValueMember = "id_Sucursal"
                Cb_Sucursales.SelectedValue = id_Sucursal
                Cb_Sucursales.Refresh()
            End If

            'Dependiendo que es el usuario dejo o no seleccionar la sucursal.
            If VariablesGlobales.objUsuario.id_Perfil = 1 Then 'si es administrador
                Cb_Sucursales.Enabled = True
            Else
                Cb_Sucursales.Enabled = False
            End If

            'Cargo los proveedores
            Dim dsProveedores As New DataSet
            dsProveedores = NegProveedores.ListadoProveedores()
            If dsProveedores.Tables(0).Rows.Count > 0 Then
                Cb_Proveedores.DataSource = Nothing
                Cb_Proveedores.DataSource = dsProveedores.Tables(0)
                Cb_Proveedores.DisplayMember = "RazonSocial"
                Cb_Proveedores.ValueMember = "id_Proveedor"
                Cb_Proveedores.Refresh()
            End If

            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar el formulario.", "Ingreso de Mercadería", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Cancelar.
    Private Sub Btn_Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Volver.Click
        Me.Close()
        Me.Dispose()
        frmProveedoresCuentaCorriente.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Cb_Proveedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Proveedores.SelectedIndexChanged
        txt_Monto.Focus()
    End Sub

End Class