Imports System.Linq
Imports Entidades
Imports Negocio

Public Class frmFacturar
    Dim NegCondicionesIva As New Negocio.NegCondicionesIva
    Dim NegFacturacion As New Negocio.NegFacturacion
    Dim NegVentas As New Negocio.NegVentas
    Dim NegNotaCredito As New Negocio.NegNotaCredito
    Dim NegDevolucion As New Negocio.NegDevolucion
    Dim NegErrores As New Negocio.NegManejadorErrores
    Dim NegCliente As New Negocio.NegClienteMayorista
    Dim NegDireccion As New Negocio.NegDireccion
    Dim NegLocalidades As New Negocio.NegLocalidades
    Dim Func As New Funciones
    Dim EntFacturacion As New Entidades.Facturacion
    Dim EntNotaCredito As New Entidades.NotaCredito
    Dim EntControlador As New Entidades.ControladorFiscal

    Public NotaCredito As Boolean = False
    Dim TipoFactura As String = ""
    Public Monto As Double
    Public TipoPago As String
    Public id_Venta As Integer
    Public id_Devolucion As Integer
    Public Descuento As Double
    Public CostoFinanciero As Double
    Public SubTotal As Double
    Public MontoSenia As Double
    Public id_Cliente As Integer
    Public TipoCliente As TipoCliente
    Public EsSenia As Boolean = False
    Public PorcentajeFacturacion As Double
    Private IdSucursal As Integer = My.Settings("Sucursal")
    Private PuntoVentaFacturacionTicket As Integer = My.Settings("PuntoVentaFacturacionTicket")
    Private PuntoVentaFacturacionManual As Integer = My.Settings("PuntoVentaFacturacionManual")
    Private PuntoVentaFacturacionElectronica As Integer = My.Settings("PuntoVentaFacturacionElectronica")
    Private ControladoraFiscal As Boolean = My.Settings("ControladorStatus") = "SI" 'Variable de configuración que indica si la sucursal puede facturar o no.
    Public IvaTotal As Double

    'Cambia de categoria de IVA.
    Private Sub Cb_IVA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_IVA.SelectedIndexChanged
        Select Case (Cb_IVA.Text)
            Case "Consumidor Final"
                DesHabilitarInformacionTicket("B")
                Cb_TipoFacturacion.Enabled = True
                Cb_TipoFacturacion.SelectedIndex = 0
            Case "Responsable Inscripto"
                HabilitarInformacionTicket("A")
                Cb_TipoFacturacion.Enabled = True
                Cb_TipoFacturacion.SelectedIndex = 0
            Case "Exento sin IVA"
                HabilitarInformacionTicket("A")
                Cb_TipoFacturacion.Enabled = False
                Cb_TipoFacturacion.SelectedIndex = 1
            Case "Monotributo"
                HabilitarInformacionTicket("B")
                Cb_TipoFacturacion.Enabled = True
                Cb_TipoFacturacion.SelectedIndex = 0
            Case "Exento"
                HabilitarInformacionTicket("B")
                Cb_TipoFacturacion.Enabled = True
                Cb_TipoFacturacion.SelectedIndex = 0
        End Select

        txt_NumeroFacturaManual.Text = Integer.Parse(NegFacturacion.ObtenerUltimoNumeroFactura(Entidades.TipoFactura.Manual, PuntoVentaFacturacionManual, IdSucursal, TipoFactura)) + 1
        FacturasList.Items.Clear()

    End Sub

    'Load del Formulario
    Private Sub frmFacturar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_Fecha.Text = Now.Date.ToString("d MMM yyyy")
        lbl_TipoPago.Text = TipoPago
        Cb_TipoFacturacion.Items.Clear()

        For Each tipo As Entidades.TipoFactura In [Enum].GetValues(GetType(Entidades.TipoFactura))
            If (tipo = Entidades.TipoFactura.Ticket) Then
                If (ControladoraFiscal) Then
                    Cb_TipoFacturacion.Items.Add(tipo)
                End If
            Else
                Cb_TipoFacturacion.Items.Add(tipo)
            End If
        Next

        Dim NegCondicionesIva As NegCondicionesIva = New NegCondicionesIva()
        Dim dsCondiciones As New DataSet
        dsCondiciones = NegCondicionesIva.ListadoCondiciones()

        'Si no se tiene habilitada la opcion de Excento sin IVA quito la opcion
        If (My.Settings.HabilitarExentoSinIVA = "SI") Then
            Dim dr As DataRow = dsCondiciones.Tables(0).NewRow
            dr("Descripcion") = "Exento sin IVA"
            dr("id_CondicionIva") = 99
            dsCondiciones.Tables(0).Rows.Add(dr)
        End If

        Cb_IVA.DataSource = dsCondiciones.Tables(0)
        Cb_IVA.DisplayMember = "Descripcion"
        Cb_IVA.ValueMember = "id_CondicionIva"

        Cb_TipoFacturacion.SelectedIndex = 0

        btnFacturar.Enabled = Not NotaCredito
        btnNotaCredito.Enabled = NotaCredito

        'Si el cliente es mayorista elimino la condicion de iva consumidor final
        If (TipoCliente = TipoCliente.Mayorista) Then
            ConfigurarMayorista()
        Else
            ConfigurarMinorista()
        End If

        If (NotaCredito) Then
            Me.Text = "Nota de Crédito"
            txt_Pago.Text = "No Requerido."
            txt_Pago.ReadOnly = True
            If (id_Venta > 0) Then
                EntFacturacion = NegFacturacion.TraerFacturacionPorIdVenta(id_Venta)
                txt_Factura_Origen.Text = EntFacturacion.NumeroFactura
            End If
        Else
            txt_Pago.Text = CType(Monto, Decimal)
            txt_Factura_Origen.Text = "No Requerido."
            txt_Factura_Origen.ReadOnly = True
        End If

        'Si la facturacion es para un cliente 
        If (id_Cliente <> 0) Then
            'cargo de forma automatica la infomacion del cliente
            Dim cliente As ClienteMayorista = NegCliente.TraerCliente(id_Cliente)
            Dim direccion As Direccion = NegDireccion.Consulta(cliente.IdDireccionFacturacion)
            'Si el cliente es "responsable inscripto" selecciono dicha opcion en caso contrario selecciono "consumidor final"
            Cb_IVA.SelectedValue = cliente.IdCondicionIva
            txt_Nombre.Text = cliente.RazonSocial
            txt_Direccion.Text = direccion.Direccion
            Dim localidad As DataRow = NegLocalidades.ListadoLocalidades(direccion.IdDistito).Tables(0).Rows.Cast(Of DataRow).Where(Function(x) x.ItemArray(0) = direccion.IdLocalidad).FirstOrDefault()
            txt_Localidad.Text = If(localidad Is Nothing, "", localidad.ItemArray(2))
            txt_Cuit.Text = cliente.Cuit
        End If

        'verifico que el monto a facturar no supere los limites permitidos
        ValidarMontoTopeFacturacion()
    End Sub

    Private Sub ConfigurarMinorista()
        PanelTotalMayorista.Visible = False
        PanelTotalMinorista.Visible = True
        Cb_IVA.SelectedIndex = 0

        If (EsSenia) Then
            lbl_SubtotalMinorista.Text = "$ " & Format(CType(SubTotal, Decimal), "###0.00") & ".-"
            lbl_CostoFinancieroMinorista.Text = "$ " & Format(CType(CostoFinanciero, Decimal), "###0.00") & ".-"
            Label1.Text = "Total Seña:"
            lbl_TotalMinorista.Text = "$ " & Format(CType(Monto, Decimal), "###0.00") & ".-"

            Label11.Visible = False
            lbl_DescuentoMinorista.Visible = False
        Else
            lbl_TotalMinorista.Text = "$ " & Format(CType(Monto, Decimal), "###0.00") & ".-"
            lbl_DescuentoMinorista.Text = "$ " & Format(CType(Descuento, Decimal), "###0.00") & ".-"
            lbl_CostoFinancieroMinorista.Text = "$ " & Format(CType(CostoFinanciero, Decimal), "###0.00") & ".-"
            lbl_SubtotalMinorista.Text = "$ " & Format(CType(SubTotal, Decimal), "###0.00") & ".-"
        End If
    End Sub

    Private Sub ConfigurarMayorista()
        PanelTotalMayorista.Visible = True
        PanelTotalMinorista.Visible = False

        PanelTotalMayorista.Location = PanelTotalMinorista.Location
        Cb_IVA.Items.Remove("Consumidor Final")
        Cb_IVA.SelectedIndex = 0

        If (EsSenia) Then
            If (CostoFinanciero > 0) Then
                lbl_CostoFinancieroMayorista.Text = "$ " & Format(CType(CostoFinanciero, Decimal), "###0.00") & ".-"
            Else
                Label20.Visible = False
                lbl_CostoFinancieroMayorista.Visible = False
            End If
            lbl_SubtotalMayorista.Text = "$ " & Format(CType(SubTotal, Decimal), "###0.00") & ".-"
            lbl_IvaMayorista.Text = "$ " & Format(CType(IvaTotal, Decimal), "###0.00") & ".-"
            lbl_TotalMayorista.Text = "$ " & Format(CType(Monto, Decimal), "###0.00") & ".-"

            Label17.Visible = False
            lbl_DescuentoMayorista.Visible = False
        Else
            lbl_TotalMayorista.Text = "$ " & Format(CType(Monto, Decimal), "###0.00") & ".-"
            lbl_DescuentoMayorista.Text = "$ " & Format(CType(Descuento, Decimal), "###0.00") & ".-"
            lbl_CostoFinancieroMayorista.Text = "$ " & Format(CType(CostoFinanciero, Decimal), "###0.00") & ".-"
            lbl_SubtotalMayorista.Text = "$ " & Format(CType(SubTotal, Decimal), "###0.00") & ".-"
            lbl_IvaMayorista.Text = "$ " & Format(CType(IvaTotal, Decimal), "###0.00") & ".-"
        End If
    End Sub

    'Click en Facturar!
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturar.Click
        Dim Facturo As Boolean = False 'Variable que indicará si se genero la factura.
        Dim PuntoVenta As Integer = 0
        Dim NumeroFactura As IList(Of Integer) = New List(Of Integer) 'Numero de Factura generada. Lo instancio como lista porque una factura manual puede utilizar mas de una factura para su venta

        If (Cb_TipoFacturacion.SelectedItem = Entidades.TipoFactura.Manual And FacturasList.Items.Count = 0) Then
            MessageBox.Show("Debe ingresar un número de factura.", "Facturación de Venta", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        If ((Cb_IVA.Text = "Responsable Inscripto" Or Cb_IVA.Text = "Monotributo" Or Cb_IVA.Text = "Exento" Or Cb_IVA.Text = "Exento sin IVA") And Not NegErrores.ValidarCuit(Trim(txt_Cuit.Text))) Then
            MessageBox.Show("El CUIL ingresado es incorrecto.", "Facturación de Venta", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        If txt_Cuit.Text = "" Or txt_Direccion.Text = "" Or txt_Localidad.Text = "" Or txt_Nombre.Text = "" Or txt_Pago.Text = "" Then
            'Si algún campo está vacio, muestro Mensaje.
            MessageBox.Show("Todos los campos habilitados son requeridos.", "Facturación de Venta", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        If MessageBox.Show("¿Ésta seguro que los datos ingresados son correctos?. No podrá modificarlos más adelante.", "Facturación de Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Select Case Cb_TipoFacturacion.SelectedItem
                Case Entidades.TipoFactura.Ticket
                    Facturo = FacturacionTicket(NumeroFactura, Descuento, CostoFinanciero)
                    PuntoVenta = PuntoVentaFacturacionTicket
                Case Entidades.TipoFactura.Manual
                    Facturo = FacturacionManual(NumeroFactura)
                    PuntoVenta = PuntoVentaFacturacionManual
                Case Entidades.TipoFactura.Electronica
                    MessageBox.Show("Método de facturación no implementado", "Facturación de Venta", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Return
            End Select


            'Se facturo correctamente, se almacena en la BDD.
            If Facturo Then
                For Each numero In NumeroFactura
                    'MAGIC MOMENT: FACTURA MACHINE !
                    'Completo la entidad de Facturacion.
                    EntFacturacion.id_Venta = id_Venta
                    EntFacturacion.Monto = If(EsSenia, MontoSenia, Monto)
                    EntFacturacion.NumeroFactura = numero
                    EntFacturacion.CondicionIva = Cb_IVA.Text
                    EntFacturacion.Nombre = Trim(txt_Nombre.Text)
                    EntFacturacion.Cuit = Trim(txt_Cuit.Text)
                    EntFacturacion.Direccion = Trim(txt_Direccion.Text)
                    EntFacturacion.Localidad = Trim(txt_Localidad.Text)
                    EntFacturacion.TipoFactura = TipoFactura
                    EntFacturacion.PuntoVenta = PuntoVenta
                    EntFacturacion.IdSucursal = IdSucursal
                    EntFacturacion.TipoRecibo = Cb_TipoFacturacion.SelectedItem

                    'Inserto la nueva factura.
                    NegFacturacion.NuevaFacturacion(EntFacturacion)
                Next

                'Actualizo la venta como Facturada.
                NegVentas.FacturoVenta(True, id_Venta)

                MessageBox.Show(String.Format("Se ha generado la factura correctamente.{0}El vuelto es: {1}", Environment.NewLine, Double.Parse(txt_Pago.Text) - Monto), "Facturación de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("No se ha generado la factura correctamente.", "Facturación de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            'Rechazo.
        End If
    End Sub

    Private Sub txt_Cuit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cuit.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Function FacturacionTicket(ByRef Numero As IList(Of Integer), Descuento As Double, CostoFinanciero As Double) As Boolean
        'Valores de la entidad "Controlador" fijos.
        EntControlador.DE1 = ""
        EntControlador.DE2 = ""
        EntControlador.DE3 = ""
        EntControlador.DE4 = ""
        EntControlador.IIF = "0"
        EntControlador.IIP = "0"
        EntControlador.COLAR1 = "Gracias por su compra."
        EntControlador.COLAR2 = ""
        EntControlador.COLAR3 = ""
        EntControlador.LREMITO1 = "."
        EntControlador.LREMITO2 = ""

        'Acepto.
        Select Case (Cb_IVA.Text)
            Case "Consumidor Final"
                EntControlador.NCOMP1 = ""
                EntControlador.NCOMP2 = ""
                EntControlador.NCUIT = ""
                EntControlador.DCOMP1 = ""
                EntControlador.DCOMP2 = ""
                EntControlador.DCOMP3 = ""
                EntControlador.RI = "F"
                EntControlador.TIVA = "2100"

                'Si se NO esta disciminando el IVA en la factura y el tipo de cliente es Mayorista 
                'le tengo que agregar el IVA al Decuento y al Costo Financiero
                If (TipoCliente = TipoCliente.Mayorista) Then
                    Descuento = Math.Round(Descuento * 1.21, 2)
                    CostoFinanciero = Math.Round(CostoFinanciero * 1.21, 2)
                End If

            Case "Responsable Inscripto"
                EntControlador.NCOMP1 = txt_Nombre.Text.Trim
                EntControlador.NCOMP2 = ""
                EntControlador.CUIT = "T"
                EntControlador.NCUIT = txt_Cuit.Text.Trim
                EntControlador.DCOMP1 = txt_Direccion.Text.Trim
                EntControlador.DCOMP2 = txt_Localidad.Text.Trim
                EntControlador.DCOMP3 = ""
                EntControlador.RI = "I"
                EntControlador.TIVA = "2100"

                'Si se esta disciminando el IVA en la factura y el tipo de cliente es Minorista 
                'le tengo que quitar el IVA al Decuento y al Costo Financiero
                If (TipoCliente = TipoCliente.Minorista) Then
                    Descuento = Math.Round(Descuento / 1.21, 2)
                    CostoFinanciero = Math.Round(CostoFinanciero / 1.21, 2)
                End If

            Case "Monotributo"
                EntControlador.NCOMP1 = txt_Nombre.Text.Trim
                EntControlador.NCOMP2 = ""
                EntControlador.CUIT = "T"
                EntControlador.NCUIT = txt_Cuit.Text.Trim
                EntControlador.DCOMP1 = txt_Direccion.Text.Trim
                EntControlador.DCOMP2 = txt_Localidad.Text.Trim
                EntControlador.DCOMP3 = ""
                EntControlador.RI = "M"
                EntControlador.TIVA = "2100"

                'Si se NO esta disciminando el IVA en la factura y el tipo de cliente es Mayorista 
                'le tengo que agregar el IVA al Decuento y al Costo Financiero
                If (TipoCliente = TipoCliente.Mayorista) Then
                    Descuento = Math.Round(Descuento * 1.21, 2)
                    CostoFinanciero = Math.Round(CostoFinanciero * 1.21, 2)
                End If
            Case "Exento"
                EntControlador.NCOMP1 = txt_Nombre.Text.Trim
                EntControlador.NCOMP2 = ""
                EntControlador.CUIT = "T"
                EntControlador.NCUIT = txt_Cuit.Text.Trim
                EntControlador.DCOMP1 = txt_Direccion.Text.Trim
                EntControlador.DCOMP2 = txt_Localidad.Text.Trim
                EntControlador.DCOMP3 = ""
                EntControlador.RI = "E"
                EntControlador.TIVA = "2100"

                'Si se NO esta disciminando el IVA en la factura y el tipo de cliente es Mayorista 
                'le tengo que agregar el IVA al Decuento y al Costo Financiero
                If (TipoCliente = TipoCliente.Mayorista) Then
                    Descuento = Math.Round(Descuento * 1.21, 2)
                    CostoFinanciero = Math.Round(CostoFinanciero * 1.21, 2)
                End If
            Case "Exento sin IVA"
                EntControlador.NCOMP1 = txt_Nombre.Text.Trim
                EntControlador.NCOMP2 = ""
                EntControlador.CUIT = "T"
                EntControlador.NCUIT = txt_Cuit.Text.Trim
                EntControlador.DCOMP1 = txt_Direccion.Text.Trim
                EntControlador.DCOMP2 = txt_Localidad.Text.Trim
                EntControlador.DCOMP3 = ""
                EntControlador.RI = "E"
                EntControlador.TIVA = "0000"

                'Si se esta disciminando el IVA en la factura y el tipo de cliente es Minorista 
                'le tengo que quitar el IVA al Decuento y al Costo Financiero
                If (TipoCliente = TipoCliente.Minorista) Then
                    Descuento = Math.Round(Descuento / 1.21, 2)
                    CostoFinanciero = Math.Round(CostoFinanciero / 1.21, 2)
                End If
        End Select


        Dim NegControlador As New Negocio.NegControladorFiscal(My.Settings("ConexionControladora").ToString())

        'Abro el pruesto de la controladora
        If NegControlador.AbrirPuerto() Then

            If NegControlador.AbrirTicket(EntControlador) Then
                lblEstado.Text = "Imprimiendo"
                Me.Refresh()
                Dim dsVentas As DataSet = New DataSet()
                'Si es una seña
                If (EsSenia) Then
                    'Agrego al ticket un item de seña por el valor señado
                    EntControlador.DPPAL = Func.ReemplazarCaracteres("Seña")
                    EntControlador.CANTIDAD = Func.FormatearCantidad("1")
                    EntControlador.PUNITARIO = Func.FormatearPrecio(MontoSenia)
                    NegControlador.AgregarItemTicket(EntControlador)
                Else
                    'Agrego items al ticket
                    dsVentas = NegVentas.TraerVentaDetalle(id_Venta)
                    If dsVentas.Tables(0).Rows.Count > 0 Then
                        For Each prod In dsVentas.Tables(0).Rows
                            'Seteo la entidad para cada Item.
                            EntControlador.DPPAL = Func.ReemplazarCaracteres(prod.Item("Nombre").ToString)
                            EntControlador.CANTIDAD = Func.FormatearCantidad(prod.Item("Cantidad"))
                            If (TipoCliente = TipoCliente.Mayorista) Then
                                EntControlador.PUNITARIO = Func.FormatearPrecio(prod.Item("Precio") * PorcentajeFacturacion * 1.21)
                            Else
                                EntControlador.PUNITARIO = Func.FormatearPrecio(prod.Item("Monto"))
                            End If
                            NegControlador.AgregarItemTicket(EntControlador)
                        Next
                    End If
                End If
                'Si hay descuentos, los agrego al ticket
                If Descuento > 0 Then
                    NegControlador.DescuentosTicket(Func.ReemplazarCaracteres("Descuento"), Func.FormatearPrecio(Descuento, 2))
                End If

                'Si hay Costo Financiero, los agrego al ticket
                If CostoFinanciero > 0 Then
                    NegControlador.RecargosTicket(Func.ReemplazarCaracteres("Costo Financiero"), Func.FormatearPrecio(CostoFinanciero, 2))
                End If

                'Subtotal y pago.
                If Descuento = 0 AndAlso CostoFinanciero = 0 Then
                    Dim sSubtotal As String = NegControlador.SubtotalTicket()
                End If

                NegControlador.PagarTicket(lbl_TipoPago.Text, Func.FormatearPrecio(txt_Pago.Text, 2))

                'Cierra Ticket.
                Dim NumeroFactura As Integer = NegControlador.CerrarTicket(EntControlador)

                'Si devuelve un numero de factura significa que facturo correctamente.
                If NumeroFactura > 0 Then
                    Numero.Add(NumeroFactura)
                    NegControlador.CerrarPuerto()
                    Return True
                End If
            End If
        Else
            lblEstado.Text = "Error"
        End If
        NegControlador.CerrarPuerto()
        Return False
    End Function

    Private Function FacturacionManual(ByRef Numeros As IList(Of Integer)) As Boolean

        For Each numero In FacturasList.Items
            Numeros.Add(Integer.Parse(numero.ToString().TrimStart("0")))
        Next

        Return True
    End Function

    Private Function FacturacionElectronica(ByRef Numero As IList(Of Integer)) As Boolean
        MessageBox.Show("Falta implementar", "Facturación de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return False
    End Function

    Private Sub AgregarNumeroFactura_Click(sender As Object, e As EventArgs) Handles AgregarNumeroFactura.Click

        'Verifico que el numero que se esta por ingresar ya no se encuentre en la lista de numero de facturas ingresados 
        For Each numero In FacturasList.Items
            If (Integer.Parse(numero.ToString) = Integer.Parse(txt_NumeroFacturaManual.Text)) Then
                MessageBox.Show("El número ingresado ya se encuentra cargado. Por favor, ingrese otro número de factura.", "Facturación de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
        Next

        If (NegFacturacion.NumeroFacturaUtilizado(Entidades.TipoFactura.Manual, PuntoVentaFacturacionManual, IdSucursal, txt_NumeroFacturaManual.Text, TipoFactura)) Then
            MessageBox.Show("El número ingresado ya se encuentra guardado en la base de datos. Por favor, ingrese otro número de factura.", "Facturación de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        FacturasList.Items.Add(txt_NumeroFacturaManual.Text.PadLeft(10, "0"))

        txt_NumeroFacturaManual.Text = Integer.Parse(txt_NumeroFacturaManual.Text) + 1
    End Sub

    Private Sub QuitarNumeroFactura_Click(sender As Object, e As EventArgs) Handles QuitarNumeroFactura.Click
        FacturasList.Items.Remove(FacturasList.SelectedItem)
    End Sub

    Private Sub Cb_TipoFacturacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_TipoFacturacion.SelectedIndexChanged
        If (Cb_TipoFacturacion.SelectedItem = Entidades.TipoFactura.Manual) Then
            GB_FacturacionManual.Enabled = True
        Else
            GB_FacturacionManual.Enabled = False
        End If

        lblError.Enabled = True

        'verifico que el monto a facturar no supere los limites permitidos
        ValidarMontoTopeFacturacion()
    End Sub

    Private Sub txt_NumeroFacturaManual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_NumeroFacturaManual.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnNotaCredito_Click(sender As Object, e As EventArgs) Handles btnNotaCredito.Click
        Dim GeneracionNotaCredito As Boolean = False 'Variable que indicará si se genero la factura.
        Dim PuntoVenta As Integer = 0
        Dim NumeroComprobante As IList(Of Integer) = New List(Of Integer) 'Numero de Factura generada. Lo instancio como lista porque una factura manual puede utilizar mas de una factura para su venta

        If txt_Cuit.Text = "" Or txt_Direccion.Text = "" Or txt_Localidad.Text = "" Or txt_Nombre.Text = "" Or txt_Factura_Origen.Text = "" Or txt_Pago.Text = "" Then
            'Si algún campo está vacio, muestro Mensaje.
            MessageBox.Show("Todos los campos son requeridos.", "Facturación de Venta", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        If (Cb_IVA.Text = "Responsable Inscripto" And Not NegErrores.ValidarCuit(Trim(txt_Cuit.Text))) Then
            MessageBox.Show("El CUIL ingresado es incorrecto.", "Facturación de Venta", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        If MessageBox.Show("¿Ésta seguro que los datos ingresados son correctos?. No podrá modificarlos más adelante.", "Nota de crédito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Select Case Cb_TipoFacturacion.SelectedItem
                Case Entidades.TipoFactura.Ticket
                    GeneracionNotaCredito = GenerarNotaCredito(NumeroComprobante, Descuento, CostoFinanciero)
                    PuntoVenta = PuntoVentaFacturacionTicket
                Case Entidades.TipoFactura.Manual
                    GeneracionNotaCredito = FacturacionManual(NumeroComprobante)
                    PuntoVenta = PuntoVentaFacturacionManual
                Case Entidades.TipoFactura.Electronica
                    MessageBox.Show("Método de generacion de notas de creditos no implementado", "Nota de crédito", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Return
            End Select


            'Se facturo correctamente, se almacena en la BDD.
            If GeneracionNotaCredito Then
                For Each numero In NumeroComprobante
                    'MAGIC MOMENT: FACTURA MACHINE !
                    'Completo la entidad de Facturacion.
                    EntNotaCredito.id_Devolucion = id_Devolucion
                    EntNotaCredito.Monto = If(EsSenia, MontoSenia, Monto)
                    EntNotaCredito.NumeroNotaCredito = numero
                    EntNotaCredito.Nombre = Trim(txt_Nombre.Text)
                    EntNotaCredito.Cuit = Trim(txt_Cuit.Text)
                    EntNotaCredito.Direccion = Trim(txt_Direccion.Text)
                    EntNotaCredito.Localidad = Trim(txt_Localidad.Text)
                    EntNotaCredito.TipoFactura = TipoFactura
                    EntNotaCredito.PuntoVenta = PuntoVenta
                    EntNotaCredito.id_Sucursal = IdSucursal
                    EntNotaCredito.TipoRecibo = Cb_TipoFacturacion.SelectedItem
                    EntNotaCredito.id_Factura = CType(EntFacturacion.id_Facturacion, Integer)

                    'Inserto la nueva NotaCredito.
                    NegNotaCredito.NuevaNotaCredito(EntNotaCredito)
                Next

                'Actualizo la DEVOLUCION.
                NegDevolucion.GeneracionNotaCredito(True, id_Devolucion)

                MessageBox.Show("Se ha generado la nota de crédito correctamente.", "Nota de crédito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("No se ha generado la  nota de crédito correctamente.", "Nota de crédito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            'Rechazo.
        End If

    End Sub

    Private Function GenerarNotaCredito(NumeroComprobante As IList(Of Integer), Descuento As Double, CostoFinanciero As Double) As Boolean
        Dim dsDevoluciones As DataSet
        'Valores de la entidad "Controlador" fijos.
        EntControlador.DE1 = ""
        EntControlador.DE2 = ""
        EntControlador.DE3 = ""
        EntControlador.DE4 = ""
        EntControlador.TIVA = "2100"
        EntControlador.IIF = ""
        EntControlador.IIP = ""
        EntControlador.COLAR1 = "Gracias por su compra."
        EntControlador.COLAR2 = ""
        EntControlador.COLAR3 = ""
        EntControlador.LREMITO1 = "."
        EntControlador.LREMITO2 = ""
        EntControlador.COMPROBANTEORIGEN = txt_Factura_Origen.Text

        'Acepto.
        Select Case (Cb_IVA.Text)
            Case "Consumidor Final"
                EntControlador.NCOMP1 = txt_Nombre.Text.Trim
                EntControlador.NCOMP2 = ""
                EntControlador.CUIT = "D"
                EntControlador.NCUIT = txt_Cuit.Text.Trim
                EntControlador.DCOMP1 = txt_Direccion.Text.Trim
                EntControlador.DCOMP2 = txt_Localidad.Text.Trim
                EntControlador.DCOMP3 = ""
                EntControlador.RI = "F"

                'Si se NO esta disciminando el IVA en la factura y el tipo de cliente es Mayorista 
                'le tengo que agregar el IVA al Decuento y al Costo Financiero
                If (TipoCliente = TipoCliente.Mayorista) Then
                    Descuento = Math.Round(Descuento * 1.21, 2)
                    CostoFinanciero = Math.Round(CostoFinanciero * 1.21, 2)
                End If

            Case "Responsable Inscripto"
                EntControlador.NCOMP1 = txt_Nombre.Text.Trim
                EntControlador.NCOMP2 = ""
                EntControlador.CUIT = "T"
                EntControlador.NCUIT = txt_Cuit.Text.Trim
                EntControlador.DCOMP1 = txt_Direccion.Text.Trim
                EntControlador.DCOMP2 = txt_Localidad.Text.Trim
                EntControlador.DCOMP3 = ""
                EntControlador.RI = "I"

                'Si se esta disciminando el IVA en la factura y el tipo de cliente es Minorista 
                'le tengo que quitar el IVA al Decuento y al Costo Financiero
                If (TipoCliente = TipoCliente.Minorista) Then
                    Descuento = Math.Round(Descuento / 1.21, 2)
                    CostoFinanciero = Math.Round(CostoFinanciero / 1.21, 2)
                End If

            Case "Monotributo"
                EntControlador.NCOMP1 = txt_Nombre.Text.Trim
                EntControlador.NCOMP2 = ""
                EntControlador.CUIT = "T"
                EntControlador.NCUIT = txt_Cuit.Text.Trim
                EntControlador.DCOMP1 = txt_Direccion.Text.Trim
                EntControlador.DCOMP2 = txt_Localidad.Text.Trim
                EntControlador.DCOMP3 = ""
                EntControlador.RI = "M"

                'Si se NO esta disciminando el IVA en la factura y el tipo de cliente es Mayorista 
                'le tengo que agregar el IVA al Decuento y al Costo Financiero
                If (TipoCliente = TipoCliente.Mayorista) Then
                    Descuento = Math.Round(Descuento * 1.21, 2)
                    CostoFinanciero = Math.Round(CostoFinanciero * 1.21, 2)
                End If

            Case "Exento"
                EntControlador.NCOMP1 = txt_Nombre.Text.Trim
                EntControlador.NCOMP2 = ""
                EntControlador.CUIT = "T"
                EntControlador.NCUIT = txt_Cuit.Text.Trim
                EntControlador.DCOMP1 = txt_Direccion.Text.Trim
                EntControlador.DCOMP2 = txt_Localidad.Text.Trim
                EntControlador.DCOMP3 = ""
                EntControlador.RI = "E"

                'Si se NO esta disciminando el IVA en la factura y el tipo de cliente es Mayorista 
                'le tengo que agregar el IVA al Decuento y al Costo Financiero
                If (TipoCliente = TipoCliente.Mayorista) Then
                    Descuento = Math.Round(Descuento * 1.21, 2)
                    CostoFinanciero = Math.Round(CostoFinanciero * 1.21, 2)
                End If

            Case "Exento sin IVA"
                EntControlador.NCOMP1 = txt_Nombre.Text.Trim
                EntControlador.NCOMP2 = ""
                EntControlador.CUIT = "T"
                EntControlador.NCUIT = txt_Cuit.Text.Trim
                EntControlador.DCOMP1 = txt_Direccion.Text.Trim
                EntControlador.DCOMP2 = txt_Localidad.Text.Trim
                EntControlador.DCOMP3 = ""
                EntControlador.RI = "E"

                'Si se esta disciminando el IVA en la factura y el tipo de cliente es Minorista 
                'le tengo que quitar el IVA al Decuento y al Costo Financiero
                If (TipoCliente = TipoCliente.Minorista) Then
                    Descuento = Math.Round(Descuento / 1.21, 2)
                    CostoFinanciero = Math.Round(CostoFinanciero / 1.21, 2)
                End If

        End Select

        Dim NegControlador As New Negocio.NegControladorFiscal(My.Settings("ConexionControladora").ToString())

        'Abro el pruesto de la controladora
        If NegControlador.AbrirPuerto() Then

            If NegControlador.AbrirNotaCredito(EntControlador) Then
                lblEstado.Text = "Imprimiendo"
                Me.Refresh()
                'Si es una seña
                If (EsSenia) Then
                    'Agrego al ticket un item de seña por el valor señado
                    EntControlador.DPPAL = Func.ReemplazarCaracteres("Seña")
                    EntControlador.CANTIDAD = Func.FormatearCantidad("1")
                    EntControlador.PUNITARIO = Func.FormatearPrecio(MontoSenia)
                    NegControlador.AgregarItemNotaCredito(EntControlador)
                Else
                    'Agrego items al ticket
                    If (id_Venta > 0) Then
                        dsDevoluciones = NegVentas.TraerVentaDetalle(id_Venta)
                    Else
                        dsDevoluciones = NegDevolucion.TraerDevolucionDetalle(id_Devolucion)
                    End If
                    If dsDevoluciones.Tables(0).Rows.Count > 0 Then
                        For Each prod In dsDevoluciones.Tables(0).Rows
                            'Seteo la entidad para cada Item.
                            EntControlador.DPPAL = Func.ReemplazarCaracteres(prod.Item("Nombre").ToString)
                            EntControlador.CANTIDAD = Func.FormatearCantidad(prod.Item("Cantidad"))
                            If (TipoCliente = TipoCliente.Mayorista) Then
                                EntControlador.PUNITARIO = Func.FormatearPrecio(prod.Item("Precio") * PorcentajeFacturacion * 1.21)
                            Else
                                EntControlador.PUNITARIO = Func.FormatearPrecio(prod.Item("Monto"))
                            End If
                            NegControlador.AgregarItemNotaCredito(EntControlador)
                        Next
                    End If
                End If

                'Si hay descuentos, los agrego al ticket
                If Descuento > 0 Then
                    NegControlador.DescuentosNotaCredito(Func.ReemplazarCaracteres("Descuento"), Func.FormatearPrecio(Descuento, 2))
                End If

                'Si hay Costo Financiero, los agrego al ticket
                If CostoFinanciero > 0 Then
                    NegControlador.RecargosNotaCredito(Func.ReemplazarCaracteres("Costo Financiero"), Func.FormatearPrecio(CostoFinanciero, 2))
                End If

                'Subtotal y pago.
                If Descuento = 0 AndAlso CostoFinanciero = 0 Then
                    Dim sSubtotal As String = NegControlador.SubtotalNotaCredito()
                End If


                'Cierra Ticket.
                Dim NumeroNotaCredito As Integer = NegControlador.CerrarNotaCredito(EntControlador)

                'Si devuelve un numero de factura significa que facturo correctamente.
                If NumeroNotaCredito > 0 Then
                    NumeroComprobante.Add(NumeroNotaCredito)
                    NegControlador.CerrarPuerto()
                    Return True
                End If
            End If
        Else
            lblEstado.Text = "Error"
        End If
        NegControlador.CerrarPuerto()
        Return False
    End Function

    Private Sub ValidarMontoTopeFacturacion()

        'Si la pantalla esta en modo facturacion
        If (Not NotaCredito) Then
            Dim errorMontoTope As Boolean = False

            If (Cb_TipoFacturacion.SelectedItem = Entidades.TipoFactura.Manual And Monto > My.Settings.MontoTopeFacturacionManual) Then
                errorMontoTope = True
            ElseIf (Cb_TipoFacturacion.SelectedItem = Entidades.TipoFactura.Electronica And Monto > My.Settings.MontoTopeFacturacionElectronica) Then
                errorMontoTope = True
            ElseIf (Cb_TipoFacturacion.SelectedItem = Entidades.TipoFactura.Ticket And Monto > My.Settings.MontoTopeFaturacionTicket) Then
                errorMontoTope = True
            End If

            If (errorMontoTope) Then
                lblError.Visible = True
                btnFacturar.Enabled = False
            Else
                lblError.Visible = False
                btnFacturar.Enabled = True
            End If
        Else
            lblError.Visible = False
        End If

    End Sub

    Private Sub txt_Comprobante_Origen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Factura_Origen.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Pago.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(NegErrores.SoloCurrency(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub DesHabilitarInformacionTicket(factura As String)
        txt_Cuit.Text = IIf(Not NotaCredito, "No Requerido.", String.Empty)
        txt_Direccion.Text = IIf(Not NotaCredito, "No Requerido.", String.Empty)
        txt_Localidad.Text = IIf(Not NotaCredito, "No Requerido.", String.Empty)
        txt_Nombre.Text = IIf(Not NotaCredito, "No Requerido.", String.Empty)
        txt_Cuit.ReadOnly = Not NotaCredito
        txt_Direccion.ReadOnly = Not NotaCredito
        txt_Localidad.ReadOnly = Not NotaCredito
        txt_Nombre.ReadOnly = Not NotaCredito
        TipoFactura = factura
        Label3.Text = "DNI"
    End Sub

    Private Sub HabilitarInformacionTicket(factura As String)
        txt_Cuit.Clear()
        txt_Direccion.Clear()
        txt_Localidad.Clear()
        txt_Nombre.Clear()
        txt_Cuit.ReadOnly = False
        txt_Direccion.ReadOnly = False
        txt_Localidad.ReadOnly = False
        txt_Nombre.ReadOnly = False
        TipoFactura = factura
        Label3.Text = "CUIT (sólo numeros)"
    End Sub
End Class
