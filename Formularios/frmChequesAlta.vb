Imports Entidades
Imports Negocio

Public Class frmChequesAlta

    Dim NegErrores As New Negocio.NegManejadorErrores

    Public Facturado As Boolean = False
    Public ChequeModificar As Cheque = Nothing
    Public ReturnCheque As Boolean = False

    Private Sub frmChequesAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GroupBox.Text += " " & My.Settings.NombreSucursal
        BancoBindingSource.DataSource = NegBanco.TraerBancos().Where(Function(x) x.Habilitado).ToList()

        FechaIngreso.Text = Date.Now.ToString("dd/MM/yyyy")
        MarcaFacturado.Checked = Facturado

        FechaVencimiento.Value = FechaDeposito.Value.AddDays(30)

        Dim ChequeMaxOrden As Cheque = NegCheque.TraerCheques(My.Settings.Sucursal).OrderBy(Function(x) x.NumeroOrden).LastOrDefault()
        If (Not ChequeMaxOrden Is Nothing) Then
            NumeroOrden.Text = ChequeMaxOrden.NumeroOrden + 1
        Else
            NumeroOrden.Text = 1
        End If

        'Si se ingresa al formulario con un cheque cargo su información
        If (ChequeModificar IsNot Nothing) Then
            BancoEmisor.SelectedValue = ChequeModificar.BancoEmisorId
            ClienteID.Text = If(ChequeModificar.ClienteId > -1, ChequeModificar.ClienteId, String.Empty)
            ClienteNombre.Text = ChequeModificar.ClienteNombre
            FechaDeposito.Value = ChequeModificar.FechaDesposito
            FechaVencimiento.Value = ChequeModificar.FechaVencimiento
            Importe.Text = ChequeModificar.Importe
            LibradorID.Text = If(ChequeModificar.LibradorId > -1, ChequeModificar.LibradorId, String.Empty)
            LibradorNombre.Text = ChequeModificar.LibradorNombre
            MarcaFacturado.Checked = ChequeModificar.MarcaFacturado
            NumeroCheque.Text = ChequeModificar.NumeroCheque
            NumeroOrden.Text = ChequeModificar.NumeroOrden
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
            LibradorID.Text = frmBuscarClienteMayorista.clienteMayorista.Id
            LibradorNombre.Text = frmBuscarClienteMayorista.clienteMayorista.RazonSocial
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

        If (ClienteNombre.Text = String.Empty) Then
            MessageBox.Show("El cheque no puede ser cargado. Debe ingresar un cliente.", "Alta de cheques", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        If (LibradorNombre.Text = String.Empty) Then
            MessageBox.Show("El cheque no puede ser cargado. Debe ingresar un librador.", "Alta de cheques", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        If (FechaVencimiento.Value.Date < Date.Now.Date) Then
            MessageBox.Show("El cheque no puede ser cargado. La fecha de vencimiento debe ser mayor al día de la fecha", "Alta de cheques", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
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
        cheque.IdCheque = If(ChequeModificar Is Nothing, 0, ChequeModificar.IdCheque)

        'Verifico si el cheque que se esta ingresando ya existe en la base
        Dim ChequesRepetidos As List(Of Cheque) = NegCheque.TraerCheques(cheque.LibradorNombre, cheque.NumeroCheque, cheque.BancoEmisorId)

        If (ChequesRepetidos.Count > 0) Then
            Dim negSucursal As NegSucursales = New NegSucursales
            Dim sucursal As DataRow = negSucursal.ListadoSucursalesCompleto().Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x("id_Sucursal").ToString() = ChequesRepetidos.First().SucursalId.ToString()).FirstOrDefault()
            If (MessageBox.Show("Un cheque con esos mismo Numero, Librador y Banco ya fue ingresado previamente en la sucursal " & sucursal("Nombre").ToString() & ". ¿Desea continuar?", "Alta de cheques", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No) Then
                Me.Cursor = Cursors.Arrow
                Return
            End If
        End If

        If (ReturnCheque) Then
            Me.ChequeModificar = cheque
        Else
            Try
                cheque.IdCheque = NegCheque.AltaCheque(cheque)
            Catch ex As Exception
                MessageBox.Show("Se ha encontrado un error al cargado el cheque. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Alta de cheques", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Me.Cursor = Cursors.Arrow

            MessageBox.Show("El cheque se cargó correctamente.", "Alta de cheques", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Me.Close()

    End Sub

    Private Sub Btn_Salir_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click
        ChequeModificar = Nothing
        Me.Close()
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
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub FechaDeposito_ValueChanged(sender As Object, e As EventArgs) Handles FechaDeposito.ValueChanged
        FechaVencimiento.Value = FechaDeposito.Value.AddDays(30)
    End Sub
End Class