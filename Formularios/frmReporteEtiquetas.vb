Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports Entidades
Imports System.ComponentModel
Imports Datos
Imports Common.Core.Helper

Public Class frmReporteEtiquetas
    Public MostrarPrecios As Boolean
    Public Etiquetas As BindingList(Of Etiqueta)
    Dim NegProductos As New Negocio.NegProductos

    Private Sub frmReporteEtiquetas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim strPath As String
            Dim Precio As String = ""
            Dim imgMemoryStream As MemoryStream = New MemoryStream()
            strPath = Application.StartupPath
            If strPath.EndsWith("\bin\Debug") Then
                strPath = strPath.Replace("\bin\Debug", "")
            End If

            If strPath.EndsWith("\bin\Release") Then
                strPath = strPath.Replace("\bin\Release", "")
            End If

            'Se arma el dataset
            Dim DataTable1 As New DataTable()
            DataTable1.TableName = "DataTable1"
            Dim DataColumn1 As New DataColumn("pImage", GetType(Byte()))
            DataTable1.Columns.Add(DataColumn1)

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

            For Each etiqueta As Etiqueta In Etiquetas
                'lleno la entidad productos
                Dim EProductos As Productos = NegProductos.TraerProducto(NegProductos.TraerID(etiqueta.Codigo))
                If EProductos.id_Producto <> 0 Then
                    'Mostrar Precios
                    If MostrarPrecios Then
                        'Depende de la lista de precios asignada, le asigno un determinado precio al producto.
                        Select Case My.Settings("ListaPrecio")
                            Case "1"
                                Precio = "$" & EProductos.Precio1
                            Case "2"
                                Precio = "$" & EProductos.Precio2
                            Case "3"
                                Precio = "$" & EProductos.Precio3
                            Case "4"
                                Precio = "$" & EProductos.Precio4
                            Case "5"
                                Precio = "$" & EProductos.Precio5
                            Case "6"
                                Precio = "$" & EProductos.Precio6
                            Case Else
                                Precio = ""
                        End Select
                    Else
                        Precio = ""
                    End If

                    Dim pImage As Byte() = ObtenerImagenCodigoBarra(strPath, EProductos, Precio, seteos)

                    'Completo con etiquetas
                    For i As Integer = 0 To etiqueta.Cantiadad - 1
                        Dim dr As DataRow = DataTable1.NewRow()
                        dr(0) = pImage
                        DataTable1.Rows.Add(dr)
                    Next
                End If
            Next

            Dim rpt As New ReportDocument
            strPath = strPath + "\Reportes\CrystalReport2.rpt"

            'Cargo el reporte en el ReportDocument y le asigno el datasource.
            rpt.Load(strPath)
            rpt.SetDataSource(DataTable1)

            'Opciones de Impresion.
            'Tipo de Hoja.
            rpt.PrintOptions.PaperSize = PaperSize.PaperLetter

            'Margenes.
            Dim margenes As New CrystalDecisions.Shared.PageMargins
            margenes.bottomMargin = 0
            margenes.leftMargin = 0
            margenes.rightMargin = 0
            margenes.topMargin = 0
            rpt.PrintOptions.ApplyPageMargins(margenes)

            'Cargo el reporte y en el control.
            CrViewer.ReportSource = rpt
            CrViewer.Refresh()
        Catch ex As Exception
            Log.Error(ex)
            MessageBox.Show(ex.Message.ToString, "Administración de Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ObtenerImagenCodigoBarra(strPath As String, EProductos As Productos, Precio As String, seteos As Ean13Settings) As Byte()
        'aca genero el codigo
        Dim CodigoBarras As New CodigoBarras.Ean13(EProductos.CodigoBarra, EProductos.Nombre, EProductos.Codigo, Precio, seteos)
        Dim img As Image = CodigoBarras.Paint()
        Dim bmp As New Bitmap(img.Width, img.Height)
        Dim gfx As Graphics = Graphics.FromImage(bmp)
        gfx.Clear(Color.White)
        gfx.DrawImageUnscaled(img, New Point(0, 0))
        gfx.Dispose()

        ' Saves an image as a jpeg image, with the given quality
        ' Gets:
        ' path - Path to which the image would be saved.
        ' quality - An integer from 0 to 100, with 100 being the
        ' highest quality

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

        Return pImage
    End Function

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

    End Function 'GetEncoderInfo
End Class