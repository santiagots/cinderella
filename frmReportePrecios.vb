Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class frmReportePrecios
    Dim NegProductos As New Negocio.NegProductos
    Dim EProductos As New Entidades.Productos
    Public ChkProductos As New CheckedListBox
    Public ChkPrecios As New CheckedListBox

    Private Sub frmReportePrecios_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frmPlanillaPrecios.WindowState = FormWindowState.Minimized Then
            frmPlanillaPrecios.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub frmReportePrecios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'For de productos.
            If ChkProductos.CheckedItems.Count > 0 Then

                Me.Cursor = Cursors.WaitCursor

                'Muestro el form de espera..
                frmCargadorDeEspera.Show()
                frmCargadorDeEspera.Text = "Generando reporte... "
                frmCargadorDeEspera.lbl_Descripcion.Text = "Iniciando... "
                frmCargadorDeEspera.BarraProgreso.Minimum = 0
                frmCargadorDeEspera.BarraProgreso.Maximum = ChkProductos.CheckedItems.Count + 2
                frmCargadorDeEspera.BarraProgreso.Value = 1
                frmCargadorDeEspera.Refresh()

                Dim strPath As String
                Dim imgMemoryStream As MemoryStream = New MemoryStream()
                strPath = Application.StartupPath
                If strPath.EndsWith("\bin\Debug") Then
                    strPath = strPath.Replace("\bin\Debug", "")
                End If

                If strPath.EndsWith("\bin\Release") Then
                    strPath = strPath.Replace("\bin\Release", "")
                End If

                Dim ds As New DataSet
                Dim dt As New DataTable

                dt = ds.Tables.Add("Productos")
                dt.Columns.Add("Codigo", Type.GetType("System.String"))
                dt.Columns.Add("Nombre", Type.GetType("System.String"))
                dt.Columns.Add("CodigoBarra", GetType(Byte()))
                dt.Columns.Add("Costo", Type.GetType("System.Double"))
                dt.Columns.Add("Precio1", Type.GetType("System.Double"))
                dt.Columns.Add("Precio2", Type.GetType("System.Double"))
                dt.Columns.Add("Precio3", Type.GetType("System.Double"))
                dt.Columns.Add("Precio4", Type.GetType("System.Double"))
                dt.Columns.Add("Precio5", Type.GetType("System.Double"))
                dt.Columns.Add("Precio6", Type.GetType("System.Double"))

                dt.Columns("Costo").DefaultValue = 0
                dt.Columns("Precio1").DefaultValue = 0
                dt.Columns("Precio2").DefaultValue = 0
                dt.Columns("Precio3").DefaultValue = 0
                dt.Columns("Precio4").DefaultValue = 0
                dt.Columns("Precio5").DefaultValue = 0
                dt.Columns("Precio6").DefaultValue = 0

                For Each item In ChkProductos.CheckedItems
                    'lleno la entidad productos
                    EProductos = NegProductos.TraerProducto(item.row.ItemArray(1))
                    If EProductos.id_Producto <> 0 Then

                        'Voy seteando la barra de progreso
                        frmCargadorDeEspera.lbl_Descripcion.Text = "Producto: " & EProductos.Nombre
                        frmCargadorDeEspera.BarraProgreso.Value += 1
                        frmCargadorDeEspera.Refresh()

                        'Realizo el codigo de barras y lo asigno al picture
                        'esto lo uso para los seteos, no cambiarlos, mandar estos tal cual. 
                        Dim seteos As New CodigoBarras.Ean13Settings
                        seteos.BarCodeHeight = 80
                        seteos.BarWidth = 1
                        seteos.BottomMargin = 5
                        seteos.LeftMargin = 5
                        seteos.RightMargin = 5
                        seteos.TopMargin = 10
                        seteos.Font = New Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular)

                        'aca genero el codigo
                        Dim CodigoBarras As New CodigoBarras.Ean13(EProductos.CodigoBarra, "", "", "", seteos)
                        Dim img As Image = CodigoBarras.Paint()
                        Dim bmp As New Bitmap(img.Width, img.Height)
                        Dim gfx As Graphics = Graphics.FromImage(bmp)
                        gfx.Clear(Color.White)
                        gfx.DrawImageUnscaled(img, New Point(0, 0))
                        gfx.Dispose()

                        ' Encoder parameter for image quality
                        Dim qualityParam As New EncoderParameter(Encoder.Quality, 100)
                        ' Jpeg image codec
                        Dim jpegCodec As ImageCodecInfo = GetEncoderInfo("image/jpeg")

                        Dim encoderParams As New EncoderParameters(1)
                        encoderParams.Param(0) = qualityParam

                        bmp.Save(strPath + "\Imagenes\etiquetas\Etiqueta_Imprimir.jpg", jpegCodec, encoderParams)
                        bmp.Dispose()

                        'Imagen de Etiqueta a Imprimir.
                        Dim fs As FileStream = New FileStream(strPath + "\Imagenes\etiquetas\Etiqueta_Imprimir.jpg", System.IO.FileMode.Open, System.IO.FileAccess.Read)
                        Dim pImage As Byte() = New Byte(fs.Length - 1) {}
                        fs.Read(pImage, 0, Convert.ToInt32(fs.Length))
                        fs.Close()

                        Dim dr As DataRow = dt.NewRow()
                        dr(0) = EProductos.Codigo
                        dr(1) = EProductos.Nombre
                        dr(2) = pImage

                        For Each item2 In ChkPrecios.CheckedItems
                            If item2 = "Costo" Then
                                dr(3) = EProductos.Costo
                            ElseIf item2 = "Público Tigre" Then
                                dr(4) = EProductos.Precio1
                            ElseIf item2 = "Público Sarmiento" Then
                                dr(5) = EProductos.Precio2
                            ElseIf item2 = "Público Capital" Then
                                dr(6) = EProductos.Precio3
                            ElseIf item2 = "Mayorista SF" Then
                                dr(7) = EProductos.Precio4
                            ElseIf item2 = "Mayorista CF" Then
                                dr(8) = EProductos.Precio5
                            ElseIf item2 = "Mayorista CFR" Then
                                dr(9) = EProductos.Precio6
                            End If
                        Next
                        dt.Rows.Add(dr)
                    End If
                Next

                'Voy seteando la barra de progreso
                frmCargadorDeEspera.lbl_Descripcion.Text = "Finalizando... "
                frmCargadorDeEspera.BarraProgreso.Value += 1
                frmCargadorDeEspera.Refresh()

                Me.Cursor = Cursors.Arrow
                Dim rpt As New ReportePrecios
                rpt.SetDataSource(ds.Tables("Productos"))

                CrViewer.ReportSource = rpt
                CrViewer.Refresh()

                'Voy seteando la barra de progreso
                frmCargadorDeEspera.Close()
                frmCargadorDeEspera.Dispose()
            Else
                MessageBox.Show("No hay productos cargados para realizar el reporte", "Administración de Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()
            MessageBox.Show(ex.Message.ToString, "Administración de Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Shared Function GetEncoderInfo(ByVal mimeType As String) As ImageCodecInfo
        Dim j As Integer
        Dim encoders() As ImageCodecInfo
        encoders = ImageCodecInfo.GetImageEncoders()

        j = 0
        While j < encoders.Length
            If encoders(j).MimeType = mimeType Then
                Return encoders(j)
            End If
            j += 1
        End While
        Return Nothing

    End Function

End Class