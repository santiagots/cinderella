Public Class frmFacturar
    Dim NegCondicionesIva As New Negocio.NegCondicionesIva
    Dim NegFacturacion As New Negocio.NegFacturacion
    Dim NegVentas As New Negocio.NegVentas
    Dim NegNotaCredito As New Negocio.NegNotaCredito
    Dim NegDevolucion As New Negocio.NegDevolucion
    Dim NegErrores As New Negocio.NegManejadorErrores
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
    Public MontoSinDescuento As Double
    Private IdSucursal As Integer = My.Settings("Sucursal")
    Private PuntoVentaFacturacionTicket As Integer = My.Settings("PuntoVentaFacturacionTicket")
    Private PuntoVentaFacturacionManual As Integer = My.Settings("PuntoVentaFacturacionManual")
    Private PuntoVentaFacturacionElectronica As Integer = My.Settings("PuntoVentaFacturacionElectronica")
    Private ControladoraFiscal As Boolean = My.Settings("ControladorStatus") = "SI" 'Variable de configuración que indica si la sucursal puede facturar o no.

    'Cambia de categoria de IVA.
    Private Sub Cb_IVA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_IVA.SelectedIndexChanged
        If Cb_IVA.SelectedItem = "Consumidor Final" Then
            txt_Cuit.Text = IIf(Not NotaCredito, "No Requerido.", String.Empty)
            txt_Direccion.Text = IIf(Not NotaCredito, "No Requerido.", String.Empty)
            txt_Localidad.Text = IIf(Not NotaCredito, "No Requerido.", String.Empty)
            txt_Nombre.Text = IIf(Not NotaCredito, "No Requerido.", String.Empty)
            txt_Cuit.ReadOnly = Not NotaCredito
            txt_Direccion.ReadOnly = Not NotaCredito
            txt_Localidad.ReadOnly = Not NotaCredito
            txt_Nombre.ReadOnly = Not NotaCredito
            TipoFactura = "B"
            Label3.Text = "DNI"
        Else
            txt_Cuit.Clear()
            txt_Direccion.Clear()
            txt_Localidad.Clear()
            txt_Nombre.Clear()
            txt_Cuit.ReadOnly = False
            txt_Direccion.ReadOnly = False
            txt_Localidad.ReadOnly = False
            txt_Nombre.ReadOnly = False
            TipoFactura = "A"
            Label3.Text = "CUIT (sólo numeros)"
        End If

        txt_NumeroFacturaManual.Text = Integer.Parse(NegFacturacion.ObtenerUltimoNumeroFactura(Entidades.TipoFactura.Manual, PuntoVentaFacturacionManual, IdSucursal, TipoFactura)) + 1
        FacturasList.Items.Clear()

    End Sub

    'Load del Formulario
    Private Sub frmFacturar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_Fecha.Text = Now.Date.ToString("d MMM yyyy")
        lbl_Total.Text = "$ " & Format(CType(Monto, Decimal), "###0.00") & ".-"
        lbl_Descuento.Text = "$ " & Format(CType(Descuento, Decimal), "###0.00") & ".-"
        lbl_Subtotal.Text = "$ " & Format(CType(MontoSinDescuento, Decimal), "###0.00") & ".-"
        lbl_TipoPago.Text = TipoPago

        'Default de Botonera.
        Cb_IVA.SelectedIndex = 1

        For Each tipo As Entidades.TipoFactura In [Enum].GetValues(GetType(Entidades.TipoFactura))
            If (tipo = Entidades.TipoFactura.Ticket) Then
                If (ControladoraFiscal) Then
                    Cb_TipoFacturacion.Items.Add(tipo)
                End If
            Else
                Cb_TipoFacturacion.Items.Add(tipo)
            End If
        Next

        Cb_TipoFacturacion.SelectedIndex = 0

        btnFacturar.Enabled = Not NotaCredito
        btnNotaCredito.Enabled = NotaCredito

        If (NotaCredito) Then
            Me.Text = "Nota de Crédito"
            txt_Pago.Text = "No Requerido."
            txt_Pago.ReadOnly = True
        Else
            txt_Pago.Text = CType(Monto, Decimal)
            txt_Comprobante_Origen.Text = "No Requerido."
            txt_Comprobante_Origen.ReadOnly = True
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

        If (Cb_IVA.SelectedItem = "Responsable Inscripto" And Not NegErrores.ValidarCuit(Trim(txt_Cuit.Text))) Then
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
                    Facturo = FacturacionTicket(NumeroFactura)
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
                    EntFacturacion.Monto = Monto
                    EntFacturacion.NumeroFactura = numero
                    EntFacturacion.CondicionIva = Cb_IVA.SelectedItem
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

    Private Function FacturacionTicket(ByRef Numero As IList(Of Integer)) As Boolean
        'Valores de la entidad "Controlador" fijos.
        EntControlador.DE1 = ""
        EntControlador.DE2 = ""
        EntControlador.DE3 = ""
        EntControlador.DE4 = ""
        EntControlador.TIVA = "2100"
        EntControlador.IIF = "0"
        EntControlador.IIP = "0"
        EntControlador.COLAR1 = "Gracias por su compra."
        EntControlador.COLAR2 = ""
        EntControlador.COLAR3 = ""
        EntControlador.LREMITO1 = "."
        EntControlador.LREMITO2 = ""

        'Acepto.
        If Cb_IVA.SelectedItem = "Consumidor Final" Then
            EntControlador.NCOMP1 = ""
            EntControlador.NCOMP2 = ""
            EntControlador.NCUIT = ""
            EntControlador.DCOMP1 = ""
            EntControlador.DCOMP2 = ""
            EntControlador.DCOMP3 = ""
            EntControlador.RI = "F"
        Else
            EntControlador.NCOMP1 = txt_Nombre.Text.Trim
            EntControlador.NCOMP2 = ""
            EntControlador.CUIT = "T"
            EntControlador.NCUIT = txt_Cuit.Text.Trim
            EntControlador.DCOMP1 = txt_Direccion.Text.Trim
            EntControlador.DCOMP2 = txt_Localidad.Text.Trim
            EntControlador.DCOMP3 = ""
            EntControlador.RI = "I"
        End If

        Dim NegControlador As New Negocio.NegControladorFiscal(My.Settings("ConexionControladora").ToString())

        'Abro el pruesto de la controladora
        If NegControlador.AbrirPuerto() Then

            If NegControlador.AbrirTicket(EntControlador) Then
                lblEstado.Text = "Imprimiendo"
                Me.Refresh()
                Dim dsVentas As DataSet = New DataSet()
                'Agrego items al ticket
                dsVentas = NegVentas.TraerVentaDetalle(id_Venta)
                If dsVentas.Tables(0).Rows.Count > 0 Then
                    For Each prod In dsVentas.Tables(0).Rows
                        'Seteo la entidad para cada Item.
                        EntControlador.DPPAL = Func.ReemplazarCaracteres(prod.Item("Nombre").ToString)
                        EntControlador.CANTIDAD = Func.FormatearCantidad(prod.Item("Cantidad"))
                        EntControlador.PUNITARIO = Func.FormatearPrecio(prod.Item("Precio"))
                        NegControlador.AgregarItemTicket(EntControlador)
                    Next
                End If

                'Si hay descuentos, los agrego al ticket
                If Descuento < 0 Then
                    NegControlador.DescuentosTicket(Func.ReemplazarCaracteres("Descuento"), (Func.FormatearPrecio(Descuento, 2) * -1))
                Else
                    'Subtotal y pago.
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

        If txt_Cuit.Text = "" Or txt_Direccion.Text = "" Or txt_Localidad.Text = "" Or txt_Nombre.Text = "" Or txt_Comprobante_Origen.Text = "" Or txt_Pago.Text = "" Then
            'Si algún campo está vacio, muestro Mensaje.
            MessageBox.Show("Todos los campos son requeridos.", "Facturación de Venta", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        If (Cb_IVA.SelectedItem = "Responsable Inscripto" And Not NegErrores.ValidarCuit(Trim(txt_Cuit.Text))) Then
            MessageBox.Show("El CUIL ingresado es incorrecto.", "Facturación de Venta", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        End If

        If MessageBox.Show("¿Ésta seguro que los datos ingresados son correctos?. No podrá modificarlos más adelante.", "Nota de crédito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Select Case Cb_TipoFacturacion.SelectedItem
                Case Entidades.TipoFactura.Ticket
                    GeneracionNotaCredito = GenerarNotaCredito(NumeroComprobante)
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
                    EntNotaCredito.Monto = Monto
                    EntNotaCredito.NumeroNotaCredito = numero
                    EntNotaCredito.Nombre = Trim(txt_Nombre.Text)
                    EntNotaCredito.Cuit = Trim(txt_Cuit.Text)
                    EntNotaCredito.Direccion = Trim(txt_Direccion.Text)
                    EntNotaCredito.Localidad = Trim(txt_Localidad.Text)
                    EntNotaCredito.TipoFactura = TipoFactura
                    EntNotaCredito.PuntoVenta = PuntoVenta
                    EntNotaCredito.id_Sucursal = IdSucursal
                    EntNotaCredito.TipoRecibo = Cb_TipoFacturacion.SelectedItem

                    'Inserto la nueva NotaCredito.
                    NegNotaCredito.NuevaNotaCredito(EntNotaCredito)
                Next

                'Actualizo la venta como DEVOLUCION.
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

    Private Function GenerarNotaCredito(NumeroComprobante As IList(Of Integer)) As Boolean
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
        EntControlador.COMPROBANTEORIGEN = txt_Comprobante_Origen.Text

        'Acepto.
        If Cb_IVA.SelectedItem = "Consumidor Final" Then
            EntControlador.NCOMP1 = txt_Nombre.Text.Trim
            EntControlador.NCOMP2 = ""
            EntControlador.CUIT = "D"
            EntControlador.NCUIT = txt_Cuit.Text.Trim
            EntControlador.DCOMP1 = txt_Direccion.Text.Trim
            EntControlador.DCOMP2 = txt_Localidad.Text.Trim
            EntControlador.DCOMP3 = ""
            EntControlador.RI = "F"
        Else
            EntControlador.NCOMP1 = txt_Nombre.Text.Trim
            EntControlador.NCOMP2 = ""
            EntControlador.CUIT = "T"
            EntControlador.NCUIT = txt_Cuit.Text.Trim
            EntControlador.DCOMP1 = txt_Direccion.Text.Trim
            EntControlador.DCOMP2 = txt_Localidad.Text.Trim
            EntControlador.DCOMP3 = ""
            EntControlador.RI = "I"
        End If

        Dim NegControlador As New Negocio.NegControladorFiscal(My.Settings("ConexionControladora").ToString())

        'Abro el pruesto de la controladora
        If NegControlador.AbrirPuerto() Then

            If NegControlador.AbrirNotaCredito(EntControlador) Then
                lblEstado.Text = "Imprimiendo"
                Me.Refresh()
                'Agrego items al ticket
                dsDevoluciones = NegDevolucion.TraerDevolucionDetalle(id_Devolucion)
                If dsDevoluciones.Tables(0).Rows.Count > 0 Then
                    For Each prod In dsDevoluciones.Tables(0).Rows
                        'Seteo la entidad para cada Item.
                        EntControlador.DPPAL = Func.ReemplazarCaracteres(prod.Item("Nombre").ToString)
                        EntControlador.CANTIDAD = Func.FormatearCantidad(prod.Item("Cantidad"))
                        EntControlador.PUNITARIO = Func.FormatearPrecio(prod.Item("Precio"))
                        NegControlador.AgregarItemNotaCredito(EntControlador)
                    Next
                End If

                'Si hay descuentos, los agrego al ticket
                If Descuento < 0 Then
                    NegControlador.DescuentosNotaCredito(Func.ReemplazarCaracteres("Descuento"), (Func.FormatearPrecio(Descuento, 2) * -1))
                Else
                    'Subtotal y pago.
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

    Private Sub txt_Comprobante_Origen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Comprobante_Origen.KeyPress
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
End Class
