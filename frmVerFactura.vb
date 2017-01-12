Public Class frmVerFactura
    Public id_Venta As Integer
    Public id_Factura As Integer
    Dim NegFacturacion As New Negocio.NegFacturacion
    Dim entFacturacion As New Entidades.Facturacion

    Private Sub frmVerFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Seteo de Variables.
            lbl_Cuit.Text = ""
            lbl_Nombre.Text = ""
            lbl_Direccion.Text = ""
            lbl_Localidad.Text = ""
            lbl_Total.Text = "$ 0,00"
            lbl_Fecha.Text = ""
            lbl_NumeroFactura.Text = ""

            'Cargo los datos de la factura.
            If (id_Factura > 0) Then
                entFacturacion = NegFacturacion.TraerFacturacionPorId(id_Factura)
            Else
                entFacturacion = NegFacturacion.TraerFacturacionPorIdVenta(id_Venta)
            End If
            lbl_Cuit.Text = entFacturacion.Cuit
            lbl_Nombre.Text = entFacturacion.Nombre
            lbl_Direccion.Text = entFacturacion.Direccion
            lbl_Localidad.Text = entFacturacion.Localidad
            lbl_Total.Text = "$ " & Format(CType(entFacturacion.Monto, Decimal), "###0.00")
            lbl_Fecha.Text = entFacturacion.Fecha
            lbl_NumeroFactura.Text = entFacturacion.NumeroFactura.PadLeft(10, "0")
            If entFacturacion.TipoFactura = "A" Then
                lbl_Condicion.Text = "Responsable Inscripto"
            Else
                lbl_Condicion.Text = "Consumidor Final"
            End If
            Me.Text = "Ver Detalle de Factura Nº " & entFacturacion.NumeroFactura
        Catch ex As Exception
            MessageBox.Show("No se ha podido cargar el detalle de la factura.", "Detalle de la Factura", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class