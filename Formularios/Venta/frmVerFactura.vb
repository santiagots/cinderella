Imports System.Threading.Tasks
Imports Common.Core.Exceptions
Imports Common.Core.Helper
Imports SistemaCinderella.Formularios.Venta

Public Class frmVerFactura

    Private frmVerFacturaViewModel As frmVerFacturaViewModel

    Sub New(idFactura As Long)

        ' This call is required by the designer.
        InitializeComponent()

        frmVerFacturaViewModel = New frmVerFacturaViewModel(idFactura)

    End Sub

    Private Sub frmVerFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarAsync(Async Function() As Task
                          FrmVerFacturaViewModelBindingSource.DataSource = frmVerFacturaViewModel
                          Await frmVerFacturaViewModel.CargarFacturaAsync()
                      End Function)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub Ejecutar(accion As Action)
        Try
            accion()
        Catch ex As NegocioException
            Log.Error(ex)
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub EjecutarAsync(accion As Func(Of Task))
        Try
            Await accion()
        Catch ex As NegocioException
            Log.Error(ex)
            MessageBox.Show(ex.Message, "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show("Error al realizar la accion. Por favor, intente mas tarde o consulte con el administrador.", "Registro de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Public id_Venta As Int64
    'Public id_Factura As Int64
    'Dim NegFacturacion As New Negocio.NegFacturacion
    'Dim entFacturacion As New Entidades.Facturacion

    'Private Sub frmVerFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Try
    '        'Seteo de Variables.
    '        lbl_Cuit.Text = ""
    '        lbl_Nombre.Text = ""
    '        lbl_Direccion.Text = ""
    '        lbl_Localidad.Text = ""
    '        lbl_Total.Text = "$ 0,00"
    '        lbl_Fecha.Text = ""
    '        lbl_NumeroFactura.Text = ""

    '        'Cargo los datos de la factura.
    '        If (id_Factura > 0) Then
    '            entFacturacion = NegFacturacion.TraerFacturacionPorId(id_Factura)
    '        Else
    '            entFacturacion = NegFacturacion.TraerFacturacionPorIdVenta(id_Venta)
    '        End If
    '        lbl_Cuit.Text = entFacturacion.Cuit
    '        lbl_Nombre.Text = entFacturacion.Nombre
    '        lbl_Direccion.Text = entFacturacion.Direccion
    '        lbl_Localidad.Text = entFacturacion.Localidad
    '        lbl_Total.Text = "$ " & Format(CType(entFacturacion.Monto, Decimal), "###0.00")
    '        lbl_Fecha.Text = entFacturacion.Fecha
    '        lbl_NumeroFactura.Text = entFacturacion.NumeroFactura.PadLeft(10, "0")
    '        If entFacturacion.TipoFactura = "A" Then
    '            lbl_Condicion.Text = "Responsable Inscripto"
    '        Else
    '            lbl_Condicion.Text = "Consumidor Final"
    '        End If
    '        Me.Text = "Ver Detalle de Factura Nº " & entFacturacion.NumeroFactura
    '    Catch ex As Exception
    '        MessageBox.Show("No se ha podido cargar el detalle de la factura.", "Detalle de la Factura", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Me.Close()
    '    End Try
    'End Sub
End Class