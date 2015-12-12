Public Class FrmVerNotaCredito
    Public id_Devolucion As Integer
    Dim NegNotaCredito As New Negocio.NegNotaCredito
    Dim EntNotaCredito As New Entidades.NotaCredito

    Private Sub FrmVerNotaCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Seteo de Variables.
            lbl_Cuit.Text = ""
            lbl_Nombre.Text = ""
            lbl_Direccion.Text = ""
            lbl_Localidad.Text = ""
            lbl_Total.Text = "$ 0,00"
            lbl_Fecha.Text = ""
            lbl_NumeroNota.Text = ""

            'Cargo los datos de la factura.
            EntNotaCredito = NegNotaCredito.TraerNotaCredito(id_Devolucion)
            lbl_Cuit.Text = EntNotaCredito.Cuit
            lbl_Nombre.Text = EntNotaCredito.Nombre
            lbl_Direccion.Text = EntNotaCredito.Direccion
            lbl_Localidad.Text = EntNotaCredito.Localidad
            lbl_Total.Text = "$ " & Format(CType(EntNotaCredito.Monto, Decimal), "###0.00")
            lbl_Fecha.Text = EntNotaCredito.Fecha
            lbl_NumeroNota.Text = EntNotaCredito.NumeroNotaCredito
            If EntNotaCredito.TipoFactura = "A" Then
                lbl_Condicion.Text = "Responsable Inscripto"
            Else
                lbl_Condicion.Text = "Consumidor Final"
            End If
            Me.Text = "Detalle de Nota Crédito N° " & EntNotaCredito.NumeroNotaCredito
        Catch ex As Exception
            MessageBox.Show("No se ha podido cargar el detalle de la nota de crédito.", "Detalle nota crédito", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class