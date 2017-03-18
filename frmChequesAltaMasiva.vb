Imports Negocio
Imports Entidades

Public Class frmChequesAltaMasiva
    Dim NegErrores As New Negocio.NegManejadorErrores

    Public Facturado As Boolean = False
    Public ReturnCheque As Boolean = False
    Public MontoVenta As Double = 0
    Public DiferenciaPagoCheques As Double = 0

    Private Sub frmChequesAltaMasiva_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GroupBox.Text += " " & My.Settings.NombreSucursal
        BancoBindingSource.DataSource = NegBanco.TraerBancos().Where(Function(x) x.Habilitado).ToList()

        FechaIngreso.Text = Date.Now.ToString("dd/MM/yyyy")

        'la fecha de vencimiento es 30 dias despues de la fecha de deposito
        FechaVencimiento.Value = FechaDeposito.Value.AddDays(30)

        MarcaFacturado.Checked = Facturado
        MontoPagar.Text = MontoVenta
        Importe.Text = MontoVenta


        Dim ChequeMaxOrden As Cheque = NegCheque.TraerCheques(My.Settings.Sucursal).OrderBy(Function(x) x.NumeroOrden).LastOrDefault()
        If (Not ChequeMaxOrden Is Nothing) Then
            NumeroOrden.Text = ChequeMaxOrden.NumeroOrden + 1
        Else
            NumeroOrden.Text = 1
        End If
    End Sub

    Private Sub btnAgregarConsecutivo_Click(sender As Object, e As EventArgs) Handles btnAgregarConsecutivo.Click

        If AddChequeToGrid() Then

            NumeroOrden.Text = Integer.Parse(NumeroOrden.Text) + 1
            NumeroCheque.Text = Integer.Parse(NumeroCheque.Text) + 1
            FechaDeposito.Value = Date.Now
            FechaVencimiento.Value = Date.Now
            Importe.Text = DiferenciaMontos()
        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If AddChequeToGrid() Then

            NumeroOrden.Text = Integer.Parse(NumeroOrden.Text) + 1
            NumeroCheque.Text = Integer.Parse(NumeroCheque.Text) + 1
            LibradorID.Clear()
            LibradorNombre.Clear()
            BancoEmisor.SelectedIndex = 0
            NumeroCheque.Clear()
            FechaDeposito.Value = Date.Now
            FechaVencimiento.Value = Date.Now
            Importe.Text = DiferenciaMontos()
        End If
    End Sub

    Private Sub Btn_Buscar_Cliente_Click(sender As Object, e As EventArgs) Handles Btn_Buscar_Cliente.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmBuscarClienteMayorista As frmBuscarClienteMayorista = New frmBuscarClienteMayorista()
        frmBuscarClienteMayorista.ShowDialog()

        If frmBuscarClienteMayorista.clienteMayorista IsNot Nothing Then
            ClienteID.Clear()
            ClienteNombre.Clear()
            ClienteID.Text = frmBuscarClienteMayorista.clienteMayorista.Id
            ClienteNombre.Text = frmBuscarClienteMayorista.clienteMayorista.RazonSocial
        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmBuscarClienteMayorista As frmBuscarClienteMayorista = New frmBuscarClienteMayorista()
        frmBuscarClienteMayorista.ShowDialog()

        If frmBuscarClienteMayorista.clienteMayorista IsNot Nothing Then
            LibradorID.Clear()
            LibradorNombre.Clear()
            ClienteID.Text = frmBuscarClienteMayorista.clienteMayorista.Id
            ClienteNombre.Text = frmBuscarClienteMayorista.clienteMayorista.RazonSocial
        End If
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Btn_Agregar_Banco_Click(sender As Object, e As EventArgs) Handles Btn_Agregar_Banco.Click
        Me.Cursor = Cursors.WaitCursor
        Dim frmBanco As frmBanco = New frmBanco()
        frmBanco.ShowDialog()
        BancoBindingSource.DataSource = NegBanco.TraerBancos().Where(Function(x) x.Habilitado).ToList()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If (ChequeBindingSource.List.Count = 0) Then
            MessageBox.Show("No se encuentran cheques en el listado. Por favor, agregue cheques para poder guardarlos.", "Alta de cheques", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim montoFaltante As Double = DiferenciaMontos()

        If (montoFaltante > 0) Then
            If (MessageBox.Show(String.Format("Hay una diferencia de ${0} entre el importe de la venta y el cheque cargado, desea saldarla en efectivo?", montoFaltante), "Alta de cheques", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
                Return
            Else
                DiferenciaPagoCheques = montoFaltante
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            For Each cheque As Cheque In ChequeBindingSource.List
                cheque.IdCheque = NegCheque.AltaCheque(cheque)
            Next
        Catch ex As Exception
            MessageBox.Show("Se ha encontrado un error al cargar los cheque. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Alta de cheques", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Cursor = Cursors.Arrow

        MessageBox.Show("Los cheques se cargaron correctamente.", "Alta de cheques", MessageBoxButtons.OK, MessageBoxIcon.Information)

        DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    'Valido que sea solo numeros.
    Private Sub NumeroCheque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumeroCheque.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valido que sea solo moneda.
    Private Sub Importe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Importe.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub FechaDeposito_ValueChanged(sender As Object, e As EventArgs) Handles FechaDeposito.ValueChanged
        'la fecha de vencimiento es 30 dias despues de la fecha de deposito
        FechaVencimiento.Value = FechaDeposito.Value.AddDays(30)
    End Sub

    Private Function AddChequeToGrid() As Boolean
        If (ClienteNombre.Text = String.Empty) Then
            MessageBox.Show("El cheque no puede ser cargado. Debe ingresar un cliente.", "Alta de cheques", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        If (LibradorNombre.Text = String.Empty) Then
            MessageBox.Show("El cheque no puede ser cargado. Debe ingresar un librador.", "Alta de cheques", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        If (FechaVencimiento.Value.Date < Date.Now.Date) Then
            MessageBox.Show("El cheque no puede ser cargado. La fecha de vencimiento debe ser mayor al día de la fecha", "Alta de cheques", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        If (ChequeBindingSource.List.Cast(Of Cheque).Sum(Function(x) x.Importe) + Double.Parse(Importe.Text) > MontoVenta) Then
            MessageBox.Show("El cheque no puede ser cargado. El monto del cheque que intenta ingresar más los cheques ya ingresados supera el monto a pagar, por favor ingrese otro monto", "Alta de cheques", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim cheque As Entidades.Cheque = New Entidades.Cheque()
        cheque.BancoEmisorId = BancoEmisor.SelectedValue
        cheque.ClienteId = If(String.IsNullOrEmpty(ClienteID.Text), -1, ClienteID.Text)
        cheque.ClienteNombre = ClienteNombre.Text
        cheque.FechaDesposito = FechaDeposito.Value
        cheque.FechaIngreso = Date.Now
        cheque.FechaVencimiento = FechaVencimiento.Value
        cheque.Importe = Double.Parse(Importe.Text)
        cheque.LibradorId = If(String.IsNullOrEmpty(LibradorID.Text), -1, LibradorID.Text)
        cheque.LibradorNombre = LibradorNombre.Text
        cheque.MarcaFacturado = MarcaFacturado.Checked
        cheque.NumeroCheque = NumeroCheque.Text
        cheque.NumeroOrden = NumeroOrden.Text
        cheque.SucursalId = My.Settings.Sucursal
        cheque.Estado = ChequeEstado.Ingresado

        'Verifico si el cheque que se esta ingresando ya existe en la base
        Dim ChequesRepetidos As List(Of Cheque) = NegCheque.TraerCheques(cheque.LibradorNombre, cheque.NumeroCheque, cheque.BancoEmisorId)

        If (ChequesRepetidos.Count > 0) Then
            If (MessageBox.Show("Un cheque con esos mismo Numero, Librador y Banco ya fue ingresado previamente. ¿Desea continuar?", "Alta de cheques", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No) Then
                Me.Cursor = Cursors.Arrow
                Return False
            End If
        End If

        ChequeBindingSource.Add(cheque)
        txt_Total.Text = ChequeBindingSource.List.Cast(Of Cheque).Sum(Function(x) x.Importe)

        Me.Cursor = Cursors.Arrow
        Return True
    End Function

    Private Function DiferenciaMontos() As Double
        Dim montoTotalCheque As Double = ChequeBindingSource.List.Cast(Of Cheque).Sum(Function(x) x.Importe)
        Return (MontoVenta - montoTotalCheque)
    End Function

    Private Sub dgCheques_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgCheques.CellFormatting
        If (e.ColumnIndex = 1) Then
            e.Value = If(e.Value, "Si", "No")
        End If
    End Sub

    Private Sub dgCheques_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCheques.CellContentClick
        If dgCheques.Columns(e.ColumnIndex).Name = "Quitar" Then 'Si se hace click en el boton "Quitar" de la fila.
            Dim Result As DialogResult
            Result = MessageBox.Show("¿Está seguro que desea eliminar el item seleccionado?", "Alta de cheques", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then 'Si acepta eliminar el item
                Dim cheque As Cheque = ChequeBindingSource.List(e.RowIndex)
                txt_Total.Text = Double.Parse(txt_Total.Text) - cheque.Importe
                ChequeBindingSource.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        Me.Close()
    End Sub

    Private Sub frmChequesAltaMasiva_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Consulto si el resultado del formulario no es OK por la accion del boton Aceptar que cierra el fomulario e invoca este evento
        If (Not Me.DialogResult = Windows.Forms.DialogResult.OK) Then
            If (MessageBox.Show("Está seguro que desea regresar al proceso de ventas?", "Alta de cheques", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class