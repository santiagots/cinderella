Imports Entidades

Public Class frmSeniaDatos

    Private _Senia As Entidades.Senia
    Public Property Senia() As Entidades.Senia
        Get
            Return _Senia
        End Get
        Set(ByVal value As Entidades.Senia)
            _Senia = value
        End Set
    End Property

    Private TipoVenta As Clientes.Tipo
    Private Vendedor As Entidades.Empleados
    Private Encargado As Entidades.Empleados
    Private TipoPago As String
    Private Facturado As Boolean
    Private STotal As Decimal
    Private Descuento As Decimal
    Private MontoSenia As Decimal
    Private MontoTotal As Decimal
    Private IVATotal As Decimal
    Private Productos As DataTable
    Private FechaSeña As DateTime
    Private ClienteMinorista As Entidades.ClienteMinorista
    Private ClienteMayorista As Entidades.Clientes

    Private negClienteMinorista As Negocio.NegClienteMinorista = New Negocio.NegClienteMinorista()
    Private negClienteMayorista As Negocio.NegClientes = New Negocio.NegClientes()
    Private negSenia As Negocio.NegSenia = New Negocio.NegSenia()

    Sub New(tipoVenta As Clientes.Tipo, vendedor As String, encargado As String, tipoPago As String, facturado As Boolean, idClienteMayorista As Integer, subTotal As Decimal, descuento As Decimal, senia As Decimal, montoTotal As Decimal, IVA As Decimal, Productos As DataTable, FechaSeña As DateTime)

        ' This call is required by the designer.
        InitializeComponent()

        Dim negEmpleado As Negocio.NegEmpleados = New Negocio.NegEmpleados()
        Dim negTipoPago As Negocio.NegTipoPago = New Negocio.NegTipoPago()

        Me.TipoVenta = tipoVenta
        Me.Vendedor = negEmpleado.TraerEmpleadoPorIdEmpleado(vendedor)
        Me.Encargado = negEmpleado.TraerEmpleadoPorIdEmpleado(encargado)
        Me.TipoPago = tipoPago
        Me.Facturado = facturado
        Me.STotal = subTotal
        Me.Descuento = descuento
        Me.MontoSenia = senia
        Me.MontoTotal = montoTotal
        Me.IVATotal = IVA
        Me.Productos = Productos
        Me.FechaSeña = FechaSeña
        Me.ClienteMayorista = negClienteMayorista.TraerCliente(idClienteMayorista)
    End Sub

    Private Sub frmSeniaDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTipoVenta.Text = If(TipoVenta = Clientes.Tipo.Mayorista, "Mayorista", "Minorista")
        lblPago.Text = TipoPago
        lblFacturado.Text = If(Facturado, "Si", "No")
        lblFechaSeña.Text = FechaSeña.ToString("dd-MM-yyyy")
        cmbModoEntrega.SelectedIndex = 0
        dpkFechaRetiro.MinDate = DateTime.Now.AddDays(1).Date

        Dim negEmpleado As Negocio.NegEmpleados = New Negocio.NegEmpleados()
        lblVendedor.Text = String.Format("{0} {1}", Vendedor.Apellido, Vendedor.Nombre)
        lblEncargado.Text = String.Format("{0} {1}", Encargado.Apellido, Encargado.Nombre)

        DG_Productos.AutoGenerateColumns = False
        DG_Productos.DataSource = Productos
        lblCantidad.Text = Productos.Rows.Count

        If (TipoVenta = Clientes.Tipo.Minorista) Then
            DG_Productos.Columns("PRECIO").Visible = False
            DG_Productos.Columns("IVA").Visible = False

            lblSubtotalMinorista.Text = Format(STotal, "###0.00")
            lblDescuentoMinorista.Text = Format(Descuento, "###0.00")
            lblMontoMinorista.Text = Format(MontoTotal, "###0.00")
            lblSeniaMinorista.Text = Format(MontoSenia, "###0.00")
            lblImporteSaldarMinorista.Text = Format(MontoTotal - MontoSenia, "###0.00")

            PanelTotalMayorista.Visible = False
        Else
            Btn_BuscarConsumidorFinal.Visible = False
            txtApellido.Visible = False
            lblApellido.Visible = False
            lblNombre.Text = "Razón Social"
            txtNombre.Enabled = False
            txtNombre.Text = ClienteMayorista.RazonSocial
            txtMail.Enabled = False
            txtMail.Text = ClienteMayorista.Mail
            txtDireccion.Enabled = False
            txtDireccion.Text = ClienteMayorista.Direccion
            txtTelefono.Enabled = False
            txtTelefono.Text = ClienteMayorista.Telefono
            rblEnvioPromocionesNo.Enabled = False
            rblEnvioPromocionesSi.Enabled = False

            lblSubtotalMayorista.Text = Format(STotal, "###0.00")
            lblDescuentoMayorista.Text = Format(Descuento, "###0.00")
            lblSeniaMayorista.Text = Format(MontoSenia, "###0.00")
            lblMontoMayorista.Text = Format(MontoTotal, "###0.00")
            lblImporteSaldarMayorista.Text = Format(MontoTotal - MontoSenia, "###0.00")
            lblIVAMayorista.Text = Format(IVATotal, "###0.00")

            PanelTotalMinorista.Visible = False
            PanelTotalMayorista.Location = PanelTotalMinorista.Location
        End If

        If (Not Negocio.Funciones.HayInternet) Then
            txtApellido.Enabled = False
            txtNombre.Enabled = False
            txtMail.Enabled = False
            txtDireccion.Enabled = False
            txtTelefono.Enabled = False
            rblEnvioPromocionesNo.Enabled = False
            rblEnvioPromocionesSi.Enabled = False
        End If

    End Sub

    Private Sub Btn_Finalizar_Click(sender As Object, e As EventArgs) Handles Btn_Finalizar.Click
        If TipoVenta = Clientes.Tipo.Minorista AndAlso (txtApellido.Text = "" Or (txtDireccion.Visible AndAlso txtDireccion.Text = "") Or txtMail.Text = "" Or txtNombre.Text = "" Or txtTelefono.Text = "" Or cmbModoEntrega.SelectedIndex = 0) Then
            MessageBox.Show("Debe completar los campos requeridos.", "Información de la seña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If TipoVenta = Clientes.Tipo.Mayorista AndAlso cmbModoEntrega.SelectedIndex = 0 Then
            MessageBox.Show("Debe completar los campos requeridos.", "Información de la seña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If (TipoVenta = Clientes.Tipo.Minorista) Then
            GuardarCliente()
        End If

        _Senia = New Senia()
        With _Senia
            .FechaAlta = Date.Now.Date
            .FechaEstimadaRetiro = dpkFechaRetiro.Value.Date
            .IdSucursal = My.Settings.Sucursal
            .Observaciones = txtObservaciones.Text
            .FormaEntrega = cmbModoEntrega.SelectedItem
            If (TipoVenta = Clientes.Tipo.Minorista) Then
                .IdClienteMinorista = ClienteMinorista.Id
            Else
                .IdClienteMayorista = ClienteMayorista.id_Cliente
            End If
        End With

        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub GuardarCliente()

        If (ClienteMinorista Is Nothing) Then
            ClienteMinorista = New ClienteMinorista()
        End If

        ClienteMinorista.Apellido = txtApellido.Text
        ClienteMinorista.Nombre = txtNombre.Text
        ClienteMinorista.Email = txtMail.Text
        ClienteMinorista.Direccion = txtDireccion.Text
        ClienteMinorista.Telefono = txtTelefono.Text
        ClienteMinorista.EnviarNovedades = rblEnvioPromocionesSi.Checked

        If (ClienteMinorista.Id > 0) Then
            negClienteMinorista.ModificarCliente(ClienteMinorista)
        Else
            ClienteMinorista.Id = negClienteMinorista.CrearCliente(ClienteMinorista)
        End If
    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub Btn_BuscarConsumidorFinal_Click(sender As Object, e As EventArgs) Handles Btn_BuscarConsumidorFinal.Click
        Dim frmBuscarClienteMinorista As frmBuscarClienteMinorista = New frmBuscarClienteMinorista()
        If (frmBuscarClienteMinorista.ShowDialog() = DialogResult.OK) Then
            ClienteMinorista = frmBuscarClienteMinorista.clienteMinorista
            txtApellido.Text = ClienteMinorista.Apellido
            txtNombre.Text = ClienteMinorista.Nombre
            txtMail.Text = ClienteMinorista.Email
            txtDireccion.Text = ClienteMinorista.Direccion
            txtTelefono.Text = ClienteMinorista.Telefono
            rblEnvioPromocionesNo.Checked = Not ClienteMinorista.EnviarNovedades
            rblEnvioPromocionesSi.Checked = ClienteMinorista.EnviarNovedades
        End If
    End Sub

    Private Sub cmbModoEntrega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModoEntrega.SelectedIndexChanged
        If (cmbModoEntrega.SelectedItem = "Retira de la sucursal" Or cmbModoEntrega.SelectedItem = "Seleccione una opción") Then
            txtDireccion.Visible = False
            Label34.Visible = False
        Else
            txtDireccion.Visible = True
            Label34.Visible = True
        End If
    End Sub
End Class