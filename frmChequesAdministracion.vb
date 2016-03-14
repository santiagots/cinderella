Imports Negocio
Imports Entidades
Imports System.Linq
Imports Microsoft.Office.Interop

Public Class frmChequesAdministracion

    Dim NegErrores As New Negocio.NegManejadorErrores
    Public ReturnCheque As Boolean = False
    Public ChequeSeleccionado As Cheque = New Cheque()

    Private Sub frmChequesAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Maximizo la pantalla
        WindowState = FormWindowState.Maximized

        'seteo el font a 8px
        dgvCheques.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dgvCheques.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dgvCheques.RowHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        dgvCheques.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'Cargo los combos de banco
        Dim Bancos As List(Of Banco) = NegBanco.TraerBancos()

        BancoBindingSource.DataSource = Bancos

        Dim defOpcion As Banco = New Banco()
        defOpcion.BancoId = -1
        defOpcion.Nombre = "Seleccione una opción"
        BancoBindingSource.Insert(0, defOpcion)
        cmbBancoEmisor.SelectedIndex = 0

        DetalleBancoBindingSource.DataSource = Bancos

        'Cargo el combo de destino salida
        cmbDestinoSalida.DataSource = [Enum].GetValues(GetType(ChequeDestinoSalida)).Cast(Of ChequeDestinoSalida).Where(Function(x) x <> ChequeDestinoSalida.SinSalida).ToArray()

        Dim cheques As List(Of Cheque) = NegCheque.TraerCheques(My.Settings.Sucursal)
        Dim chequesSortable As SortableBindingList(Of Cheque) = New SortableBindingList(Of Cheque)()
        For Each item As Cheque In NegCheque.TraerCheques(My.Settings.Sucursal).OrderBy(Function(x) x.NumeroOrden).ToList()
            'Si la pantalla se abre en modo para seleccionar un cheque se tiene que listar todos los cheques menos los que esten en estado salido
            If (ReturnCheque) Then
                If (item.Estado <> ChequeEstado.Salido) Then
                    chequesSortable.Add(item)
                End If
            Else
                chequesSortable.Add(item)
            End If
        Next
        ChequeBindingSource.DataSource = chequesSortable

        If (ReturnCheque) Then
            TabCheques.TabPages.Remove(DetalleTab)
            btn_Exportar.Visible = False
            ChkSalido.Checked = False
            ChkSalido.Enabled = False
        End If

        ActualizarTotalesCartera(cheques)
        ActualizarPantallaCartera()

        CargarDetalleCheque()
    End Sub

    Private Sub ActualizarTotalesCartera(ByRef cheques As List(Of Cheque))
        Dim cartera As Double = cheques.Where(Function(x) x.Estado <> ChequeEstado.Salido).Sum(Function(x) x.Importe)
        lbl_TotalCartera.Text = ("$ " & Format(CType((cartera), Decimal), "###0.00") & ".-")
    End Sub

    Private Sub ActualizarPantallaCartera()
        Dim pantalla As Double = ChequeBindingSource.List.Cast(Of Cheque).Sum(Function(x) x.Importe)
        lbl_TotalPantalla.Text = ("$ " & Format(CType((pantalla), Decimal), "###0.00") & ".-")
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        Try
            'recupero los cheques de la base para la sucursal correspondinte
            Dim Cheques As List(Of Cheque) = NegCheque.TraerCheques(My.Settings.Sucursal).OrderBy(Function(x) x.NumeroOrden).ToList()

            'filtro por estado Ingresado
            Dim cheuqesIngresado = New List(Of Cheque)()
            If (chkIngresado.Checked) Then
                cheuqesIngresado = Cheques.Where(Function(x) x.Estado = ChequeEstado.Ingresado).ToList()
            End If

            'filtro por estado Salido
            Dim cheuqesSalidos = New List(Of Cheque)()
            If (ChkSalido.Checked) Then
                cheuqesSalidos = Cheques.Where(Function(x) x.Estado = ChequeEstado.Salido).ToList()
            End If

            'filtro por estado Reingresado
            Dim cheuqesReingresado = New List(Of Cheque)()
            If (ChkReingresado.Checked) Then
                cheuqesReingresado = Cheques.Where(Function(x) x.Estado = ChequeEstado.Reingresado).ToList()
            End If

            Cheques.Clear()
            Cheques.AddRange(cheuqesIngresado)
            Cheques.AddRange(cheuqesSalidos)
            Cheques.AddRange(cheuqesReingresado)

            'filtro por Marca facturado Si
            Dim cheuqesMarcaFacturadoSi = New List(Of Cheque)()
            If (ChkMarcaFacturadoSi.Checked) Then
                cheuqesMarcaFacturadoSi = Cheques.Where(Function(x) x.MarcaFacturado).ToList()
            End If

            'filtro por Marca facturado No
            Dim cheuqesMarcaFacturadoNo = New List(Of Cheque)()
            If (ChkMarcaFacturadoNo.Checked) Then
                cheuqesMarcaFacturadoNo = Cheques.Where(Function(x) Not x.MarcaFacturado).ToList()
            End If

            Cheques.Clear()
            Cheques.AddRange(cheuqesMarcaFacturadoSi)
            Cheques.AddRange(cheuqesMarcaFacturadoNo)

            'filtro por Marca Sin Salida
            Dim cheuqesSinSalida = New List(Of Cheque)()
            If (chkSinSalida.Checked) Then
                cheuqesSinSalida = Cheques.Where(Function(x) x.DestinoSalida = ChequeDestinoSalida.SinSalida).ToList()
            End If

            'filtro por Marca Depositado
            Dim cheuqesDepositado = New List(Of Cheque)()
            If (chkDepositado.Checked) Then
                cheuqesDepositado = Cheques.Where(Function(x) x.DestinoSalida = ChequeDestinoSalida.Depositado).ToList()
            End If

            'filtro por Marca Pasado
            Dim cheuqesPasado = New List(Of Cheque)()
            If (chkPasado.Checked) Then
                cheuqesPasado = Cheques.Where(Function(x) x.DestinoSalida = ChequeDestinoSalida.Pasado).ToList()
            End If

            'filtro por Marca Pasado
            Dim cheuqesDevuleto = New List(Of Cheque)()
            If (chkDevuelto.Checked) Then
                cheuqesDevuleto = Cheques.Where(Function(x) x.DestinoSalida = ChequeDestinoSalida.Devuelto).ToList()
            End If

            'filtro por Marca Pasado
            Dim cheuqesOtros = New List(Of Cheque)()
            If (chkOtros.Checked) Then
                cheuqesOtros = Cheques.Where(Function(x) x.DestinoSalida = ChequeDestinoSalida.Otro).ToList()
            End If

            Cheques.Clear()
            Cheques.AddRange(cheuqesSinSalida)
            Cheques.AddRange(cheuqesDepositado)
            Cheques.AddRange(cheuqesPasado)
            Cheques.AddRange(cheuqesDevuleto)
            Cheques.AddRange(cheuqesOtros)

            'filtro por cliente
            If (Not String.IsNullOrEmpty(txtClienteNombre.Text)) Then
                Cheques = Cheques.Where(Function(x) x.ClienteNombre.Contains(txtClienteNombre.Text)).ToList()
            End If

            'filtro por librador
            If (Not String.IsNullOrEmpty(txtLibradorNombre.Text)) Then
                Cheques = Cheques.Where(Function(x) x.LibradorNombre.Contains(txtLibradorNombre.Text)).ToList()
            End If

            'filtro por fecha ingreso
            If (chkFechaIngreso.Checked) Then
                Cheques = Cheques.Where(Function(x) dtFechaIngresoDesde.Value.Date <= x.FechaVencimiento.Date AndAlso dtFechaIngresoHasta.Value.Date >= x.FechaVencimiento.Date).ToList()
            End If

            'filtro por fecha deposito
            If (chkFechaDeposito.Checked) Then
                Cheques = Cheques.Where(Function(x) dtFechaDepositoDesde.Value.Date <= x.FechaVencimiento.Date AndAlso dtFechaDepositoHasta.Value.Date >= x.FechaVencimiento.Date).ToList()
            End If

            'filtro por fecha vencimiento
            If (chkFechaVencimiento.Checked) Then
                Cheques = Cheques.Where(Function(x) dtFechaVencimientoDesde.Value.Date <= x.FechaVencimiento.Date AndAlso dtFechaVencimientoHasta.Value.Date >= x.FechaVencimiento.Date).ToList()
            End If

            'filtro por fecha salida
            If (chkFechaSalida.Checked) Then
                Cheques = Cheques.Where(Function(x) x.FechaSalida.HasValue AndAlso (dtFechaSalidaDesde.Value.Date <= x.FechaSalida.Value.Date AndAlso dtFechaSalidaHasta.Value.Date >= x.FechaSalida.Value.Date)).ToList()
            End If

            'filtro por Importe Desde
            If (Not String.IsNullOrEmpty(txtImporteDesde.Text)) Then
                Cheques = Cheques.Where(Function(x) x.Importe >= Double.Parse(txtImporteDesde.Text)).ToList()
            End If

            'filtro por Importe Hasta
            If (Not String.IsNullOrEmpty(txtImporteHasta.Text)) Then
                Cheques = Cheques.Where(Function(x) x.Importe <= Double.Parse(txtImporteHasta.Text)).ToList()
            End If

            'filtro por numero cheque
            If (Not String.IsNullOrEmpty(txtNumero.Text)) Then
                Cheques = Cheques.Where(Function(x) x.NumeroCheque = Integer.Parse(txtNumero.Text)).ToList()
            End If

            'filtro por banco emisor
            If (cmbBancoEmisor.SelectedValue <> -1) Then
                Cheques = Cheques.Where(Function(x) x.BancoEmisorId = cmbBancoEmisor.SelectedValue).ToList()
            End If

            lbl_Msg.Visible = Cheques.Count = 0

            Dim ChequesSortable As SortableBindingList(Of Cheque) = New SortableBindingList(Of Cheque)()
            For Each item As Cheque In Cheques
                'Si la pantalla se abre en modo para seleccionar un cheque se tiene que listar todos los cheques menos los que esten en estado salido
                If (ReturnCheque) Then
                    If (item.Estado <> ChequeEstado.Salido) Then
                        ChequesSortable.Add(item)
                    End If
                Else
                    ChequesSortable.Add(item)
                End If
            Next

            ChequeBindingSource.DataSource = ChequesSortable

            ActualizarPantallaCartera()

            Dim pantalla As Double = Cheques.Sum(Function(x) x.Importe)
            lbl_TotalPantalla.Text = ("$ " & Format(CType((pantalla), Decimal), "###0.00") & ".-")

        Catch ex As Exception
            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al filtrar los cheque. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Administración de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow

    End Sub
    Private Sub btn_Restablecer_Click(sender As Object, e As EventArgs) Handles btn_Restablecer.Click

        'Cambio el cursor a "WAIT"
        Me.Cursor = Cursors.WaitCursor

        ChkMarcaFacturadoSi.Checked = True
        ChkMarcaFacturadoNo.Checked = True
        txtClienteNombre.Clear()
        txtImporteDesde.Clear()
        txtImporteHasta.Clear()
        txtLibradorNombre.Clear()
        txtNumero.Clear()
        dtFechaSalidaDesde.Value = Date.Now
        dtFechaDepositoHasta.Value = Date.Now
        dtFechaDepositoDesde.Value = Date.Now
        dtFechaDepositoHasta.Value = Date.Now
        dtFechaIngresoDesde.Value = Date.Now
        dtFechaIngresoHasta.Value = Date.Now
        dtFechaVencimientoDesde.Value = Date.Now
        dtFechaVencimientoHasta.Value = Date.Now
        chkFechaDeposito.Checked = False
        chkFechaIngreso.Checked = False
        chkFechaSalida.Checked = False
        chkFechaVencimiento.Checked = False
        cmbBancoEmisor.SelectedIndex = 0
        chkDepositado.Checked = True
        chkDevuelto.Checked = True
        chkSinSalida.Checked = True
        chkOtros.Checked = True
        chkPasado.Checked = True
        chkIngresado.Checked = True
        If (Not ReturnCheque) Then
            ChkSalido.Checked = True
        End If
        ChkReingresado.Checked = True

        Try
            'recupero los cheques de la base para la sucursal correspondinte
            Dim cheques As SortableBindingList(Of Cheque) = New SortableBindingList(Of Cheque)()
            For Each item As Cheque In NegCheque.TraerCheques(My.Settings.Sucursal).OrderBy(Function(x) x.NumeroOrden).ToList()
                'Si la pantalla se abre en modo para seleccionar un cheque se tiene que listar todos los cheques menos los que esten en estado salido
                If (ReturnCheque) Then
                    If (item.Estado <> ChequeEstado.Salido) Then
                        cheques.Add(item)
                    End If
                Else
                    cheques.Add(item)
                End If
            Next
            ChequeBindingSource.DataSource = cheques

            lbl_Msg.Visible = cheques.Count = 0

            ChequeBindingSource.DataSource = cheques
        Catch ex As Exception
            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al restablecer la busqueda. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Administración de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub dgvCheques_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCheques.CellFormatting

        If (e.ColumnIndex = 2) Then
            e.Value = If(e.Value, "Si", "No")
        End If

        Dim cheque As Cheque = ChequeBindingSource.List(e.RowIndex)

        'Si el cheque esta en fecha para ser cobrado lo resalto en verde
        If (cheque.Estado <> ChequeEstado.Salido AndAlso cheque.FechaDesposito = Date.Now) Then
            e.CellStyle.BackColor = System.Drawing.Color.Green
        End If

        'Si el cheque esta vencido o faltan 7 dias para su vencimiento lo resalto en rojo
        If (cheque.Estado <> ChequeEstado.Salido AndAlso cheque.FechaVencimiento.Date < Date.Now.AddDays(7).Date) Then
            e.CellStyle.BackColor = Color.FromArgb(255, 255, 75, 58)

            'Si el cheque esta en fecha para ser cobrado lo resalto en verde
        ElseIf (cheque.Estado <> ChequeEstado.Salido AndAlso cheque.FechaDesposito <= Date.Now) Then
            e.CellStyle.BackColor = Color.FromArgb(255, 0, 205, 106)
        End If
    End Sub

    Private Sub chkFechaIngreso_CheckedChanged(sender As Object, e As EventArgs) Handles chkFechaIngreso.CheckedChanged
        dtFechaIngresoDesde.Enabled = chkFechaIngreso.Checked
        dtFechaIngresoHasta.Enabled = chkFechaIngreso.Checked
    End Sub

    Private Sub chkFechaDeposito_CheckedChanged(sender As Object, e As EventArgs) Handles chkFechaDeposito.CheckedChanged
        dtFechaDepositoDesde.Enabled = chkFechaDeposito.Checked
        dtFechaDepositoHasta.Enabled = chkFechaDeposito.Checked
    End Sub

    Private Sub chkFechaVencimiento_CheckedChanged(sender As Object, e As EventArgs) Handles chkFechaVencimiento.CheckedChanged
        dtFechaVencimientoDesde.Enabled = chkFechaVencimiento.Checked
        dtFechaVencimientoHasta.Enabled = chkFechaVencimiento.Checked
    End Sub

    Private Sub chkFechaSalida_CheckedChanged(sender As Object, e As EventArgs) Handles chkFechaSalida.CheckedChanged
        dtFechaSalidaDesde.Enabled = chkFechaSalida.Checked
        dtFechaSalidaHasta.Enabled = chkFechaSalida.Checked
    End Sub

    'Valido que sea solo moneda.
    Private Sub txtImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporteDesde.KeyPress
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = CChar(",")
        End If
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    'Valido que sea solo numeros.
    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgvCheques_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCheques.CellDoubleClick
        If (Not ReturnCheque) Then
            If dgvCheques.SelectedRows.Count > 0 Then
                If e.RowIndex >= 0 Then
                    'Cambio el cursor a "ESPERA"
                    TabCheques.Cursor = Cursors.WaitCursor

                    CargarDetalleCheque()

                    'Cambio el cursor a "NORMAL"
                    TabCheques.Cursor = Cursors.Arrow

                    'hago foco en el tab_modificacion 
                    TabCheques.SelectedIndex = 1
                End If
            End If
        Else
            ChequeSeleccionado = ChequeBindingSource.Current
            Me.Close()
        End If

    End Sub

    Private Sub dgvCheques_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCheques.CellClick

        CargarDetalleCheque()

    End Sub

    Private Function CargarDetalleCheque() As Boolean
        Dim cheque As Cheque = ChequeBindingSource.Current

        If (cheque Is Nothing) Then
            Return False
        End If

        [Enum].TryParse(Of ChequeDestinoSalida)(cheque.DestinoSalida, cmbDestinoSalida.SelectedItem)
        EstadoDetalle.Text = cheque.Estado.ToString()
        NumeroOrden.Text = cheque.NumeroOrden
        chkDetalleMarcaFacturado.Checked = cheque.MarcaFacturado
        FechaIngreso.Text = cheque.FechaIngreso.ToString("dddd, dd MMMM yyyy")
        BancoEmisor.SelectedValue = cheque.BancoEmisorId
        ClienteID.Text = cheque.ClienteId
        ClienteNombre.Text = cheque.ClienteNombre
        LibradorID.Text = cheque.LibradorId
        LibradorNombre.Text = cheque.LibradorNombre
        NumeroCheque.Text = cheque.NumeroCheque
        Importe.Text = cheque.Importe
        FechaDeposito.Value = cheque.FechaDesposito
        FechaVencimiento.Value = cheque.FechaVencimiento
        DetalleFechaSalida.Text = If(cheque.FechaSalida.HasValue, cheque.FechaSalida.Value.ToString("dddd, dd MMMM yyyy"), String.Empty)
        DetalleSalida.Text = cheque.DetalleSalida

        EstadoDetalle.Enabled = cheque.Estado <> ChequeEstado.Salido
        NumeroOrden.Enabled = cheque.Estado <> ChequeEstado.Salido
        chkDetalleMarcaFacturado.Enabled = cheque.Estado <> ChequeEstado.Salido
        FechaIngreso.Enabled = cheque.Estado <> ChequeEstado.Salido
        DetalleFechaSalida.Enabled = cheque.Estado <> ChequeEstado.Salido
        ClienteID.Enabled = cheque.Estado <> ChequeEstado.Salido
        ClienteNombre.Enabled = cheque.Estado <> ChequeEstado.Salido
        LibradorID.Enabled = cheque.Estado <> ChequeEstado.Salido
        LibradorNombre.Enabled = cheque.Estado <> ChequeEstado.Salido
        Btn_Agregar_Banco.Enabled = cheque.Estado <> ChequeEstado.Salido
        Btn_Buscar_Cliente.Enabled = cheque.Estado <> ChequeEstado.Salido
        Btn_Buscar_Librador.Enabled = cheque.Estado <> ChequeEstado.Salido
        BancoEmisor.Enabled = cheque.Estado <> ChequeEstado.Salido
        NumeroCheque.Enabled = cheque.Estado <> ChequeEstado.Salido
        Importe.Enabled = cheque.Estado <> ChequeEstado.Salido
        FechaDeposito.Enabled = cheque.Estado <> ChequeEstado.Salido
        FechaVencimiento.Enabled = cheque.Estado <> ChequeEstado.Salido
        cmbDestinoSalida.Enabled = cheque.Estado <> ChequeEstado.Salido
        DetalleSalida.Enabled = cheque.Estado <> ChequeEstado.Salido
        btn_Modificar.Enabled = cheque.Estado <> ChequeEstado.Salido
        Btn_Salida.Enabled = cheque.Estado <> ChequeEstado.Salido

        Return True
    End Function

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click

        If (String.IsNullOrEmpty(ClienteNombre.Text().Trim())) Then
            MessageBox.Show("El campo Cliente no puede estar vacío para modificar la información del cheque.", "Administración de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If (String.IsNullOrEmpty(LibradorNombre.Text().Trim())) Then
            MessageBox.Show("El campo Librador no puede estar vacío para modificar la información del cheque.", "Administración de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If (String.IsNullOrEmpty(NumeroCheque.Text().Trim())) Then
            MessageBox.Show("El campo N° Cheque no puede estar vacío para modificar la información del cheque.", "Administración de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If (String.IsNullOrEmpty(Importe.Text().Trim())) Then
            MessageBox.Show("El campo Importe no puede estar vacío para modificar la información del cheque.", "Administración de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        Cursor = Cursors.WaitCursor
        Try
            Dim chequeSeleccionado As Cheque = ChequeBindingSource.Current

            chequeSeleccionado.BancoEmisorId = BancoEmisor.SelectedValue
            chequeSeleccionado.ClienteId = ClienteID.Text
            chequeSeleccionado.ClienteNombre = ClienteNombre.Text
            chequeSeleccionado.LibradorId = LibradorID.Text
            chequeSeleccionado.LibradorNombre = LibradorNombre.Text
            chequeSeleccionado.FechaDesposito = FechaDeposito.Value
            chequeSeleccionado.FechaVencimiento = FechaVencimiento.Value
            chequeSeleccionado.Importe = Double.Parse(Importe.Text)
            chequeSeleccionado.MarcaFacturado = chkDetalleMarcaFacturado.Checked
            chequeSeleccionado.NumeroCheque = NumeroCheque.Text
            chequeSeleccionado.NumeroOrden = NumeroOrden.Text
            chequeSeleccionado.SucursalId = My.Settings.Sucursal
            chequeSeleccionado.DetalleSalida = DetalleSalida.Text

            NegCheque.ModificacionCheque(chequeSeleccionado)

            ActualizarTotalesCartera(NegCheque.TraerCheques(My.Settings.Sucursal))
            ActualizarPantallaCartera()

        Catch ex As Exception
            Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al actualizar la información del cheque. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Administración de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Cursor = Cursors.Arrow
        MessageBox.Show("El cheque se actualizado correctamente.", "Administración de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Btn_Salida_Click(sender As Object, e As EventArgs) Handles Btn_Salida.Click
        Cursor = Cursors.WaitCursor
        Try
            Dim chequeSeleccionado As Cheque = ChequeBindingSource.Current

            chequeSeleccionado.Estado = ChequeEstado.Salido
            chequeSeleccionado.FechaSalida = Date.Now
            [Enum].TryParse(Of ChequeDestinoSalida)(cmbDestinoSalida.SelectedValue.ToString(), chequeSeleccionado.DestinoSalida)
            chequeSeleccionado.DetalleSalida = DetalleSalida.Text

            NegCheque.ModificacionCheque(chequeSeleccionado)

            ActualizarTotalesCartera(NegCheque.TraerCheques(My.Settings.Sucursal))
            ActualizarPantallaCartera()

        Catch ex As Exception
            Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error derle salida al cheque. Por favor, vuelva a intentar más tarde o contáctese con el Administrador ", "Administración de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Cursor = Cursors.Arrow
        MessageBox.Show("El cheque se actualizo correctamente.", "Administración de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Information)

        TabCheques.SelectedIndex = 0
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        TabCheques.SelectedIndex = 0
    End Sub

    Private Sub TabCheques_Selected(sender As Object, e As TabControlEventArgs) Handles TabCheques.Selected
        If (TabCheques.SelectedIndex = 1) Then
            If (Not CargarDetalleCheque()) Then
                MessageBox.Show("Para ver el detalle de un cheque debe seleccionar un cheque de la lista de cheques.", "Administración de Cheques", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        Try
            'Configuro la pantalla de guardado de archivos
            Dim DialogSave As New SaveFileDialog()
            DialogSave.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            DialogSave.FileName = String.Format("Libro de cheques {0}", My.Settings.NombreSucursal)
            DialogSave.Filter = "Excel Files|*.xlsx;"

            If DialogSave.ShowDialog() = DialogResult.OK Then
                Me.Cursor = Cursors.WaitCursor
                ExportarAExcel(DialogSave.FileName)
                'si no completo la descripcion, muestro un msg de error.
                MessageBox.Show("Se ha exportado el listado de movimientos de forma exitosa", "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Se ha producido un error en la exportación de la información. Verifique que el documento no se encuentre en uso o esté abierto. Por favor, intente más tarde.", "Planilla de Movimientos de Sucursales", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            'Cambio el cursor a "NORMAL"
            Me.Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub ExportarAExcel(nombreArchivo As String)
        Dim source1 As New BindingSource
        Dim APP As New Excel.Application
        Dim worksheet As Excel.Worksheet
        Dim workbook As Excel.Workbook
        Dim misValue As Object = System.Reflection.Missing.Value

        workbook = APP.Workbooks.Add(misValue)
        worksheet = CType(workbook.Worksheets.Item(1), Excel.Worksheet)

        '------------------------------------------Estilos para el excel------------------------------------------'
        Dim EstiloEncabezado As Microsoft.Office.Interop.Excel.Style
        EstiloEncabezado = workbook.Styles.Add("EstiloEncabezado")
        EstiloEncabezado.Font.Bold = True
        EstiloEncabezado.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White)
        EstiloEncabezado.Font.Size = 11
        EstiloEncabezado.Font.Name = "Microsoft Sans Serif"
        EstiloEncabezado.Interior.Color = Color.FromArgb(255, 91, 155, 213)
        EstiloEncabezado.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternSolid

        Dim EstiloCategoria As Microsoft.Office.Interop.Excel.Style
        EstiloCategoria = workbook.Styles.Add("EstiloCategoria")
        EstiloCategoria.Font.Bold = True
        EstiloCategoria.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White)
        EstiloCategoria.Font.Size = 9
        EstiloCategoria.Font.Name = "Microsoft Sans Serif"
        EstiloCategoria.Interior.Color = Color.FromArgb(255, 91, 155, 213)
        EstiloCategoria.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternSolid
        '------------------------------------------Estilos para el excel------------------------------------------'

        worksheet.Cells(1, 1).Value = "Sucursal:"
        worksheet.Cells(1, 1).style = "EstiloEncabezado"
        worksheet.Cells(1, 2).Value = My.Settings.NombreSucursal
        worksheet.Cells(1, 2).style = "EstiloEncabezado"

        'Export Header Names Start
        Dim columnIndex As Integer = 0
        For j As Integer = 0 To dgvCheques.Columns.Count - 1
            If (Not dgvCheques.Columns(j).Visible) Then
                Continue For
            End If
            worksheet.Cells(4, columnIndex + 1).Value = dgvCheques.Columns(j).HeaderText
            worksheet.Cells(4, columnIndex + 1).style = "EstiloEncabezado"
            columnIndex += 1
        Next
        'Export Header Name End

        'Export Each Row Start
        For i As Integer = 0 To ChequeBindingSource.List.Count - 1
            Dim cheque As Cheque = ChequeBindingSource.List(i)
            worksheet.Cells(i + 5, 1).Value = cheque.NumeroOrden
            worksheet.Cells(i + 5, 2).Value = If(cheque.MarcaFacturado, "Si", "No")
            worksheet.Cells(i + 5, 3).Value = cheque.ClienteNombre
            worksheet.Cells(i + 5, 4).Value = cheque.LibradorNombre

            Dim bancoSeleccionado = BancoBindingSource.List.Cast(Of Banco).Where(Function(x) x.BancoId = cheque.BancoEmisorId).FirstOrDefault()
            worksheet.Cells(i + 5, 5).Value = If(bancoSeleccionado IsNot Nothing, bancoSeleccionado.Nombre, "")

            worksheet.Cells(i + 5, 6).Value = cheque.NumeroCheque
            worksheet.Cells(i + 5, 7).Value = cheque.Importe
            worksheet.Cells(i + 5, 8).Value = cheque.FechaIngreso
            worksheet.Cells(i + 5, 9).Value = cheque.FechaDesposito
            worksheet.Cells(i + 5, 10).Value = cheque.FechaVencimiento
            worksheet.Cells(i + 5, 11).Value = If(cheque.FechaSalida.HasValue, cheque.FechaSalida.Value.ToString("dd/MM/yyyy"), "")
            worksheet.Cells(i + 5, 12).Value = cheque.Estado.ToString()
            worksheet.Cells(i + 5, 13).Value = cheque.DestinoSalida.ToString()
        Next
        'Export Each Row End


        'Auto fit columns
        Dim startCell As Excel.Range = CType(worksheet.Cells(1, 1), Excel.Range)
        Dim endCell As Excel.Range = CType(worksheet.Cells(dgvCheques.Rows.Count + 1, dgvCheques.Columns.Count), Excel.Range)
        Dim writeRange As Excel.Range = worksheet.Range(startCell, endCell)
        writeRange.Columns.AutoFit()

        APP.DisplayAlerts = False
        workbook.SaveAs(nombreArchivo, Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, False, False, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlUserResolution, True, misValue, misValue, misValue)
        APP.DisplayAlerts = True
        workbook.Close(0)
        APP.Workbooks.Close()
        APP.Quit()
        KillExcel()
    End Sub

    Private Sub KillExcel()

        Dim proc As System.Diagnostics.Process
        For Each proc In System.Diagnostics.Process.GetProcessesByName("EXCEL")
            If proc.MainWindowTitle.ToString = "" Then
                proc.Kill()
            End If
        Next

    End Sub

End Class