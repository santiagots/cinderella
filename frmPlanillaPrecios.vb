Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Imaging
Public Class frmPlanillaPrecios
    Dim NegProveedor As New Negocio.NegProveedores
    Dim NegProductos As New Negocio.NegProductos
    Dim NegProductosCat As New Negocio.NegProductosCategorias
    Dim NegProductosSubCat As New Negocio.NegProductosSubcategorias
    Dim Funciones As New Funciones
    Dim fuc As New Funciones
    Dim StringProveedores As String = ""
    Dim dsProductosFiltrados As New DataSet

    'Load de form.
    Private Sub frmPlanillaPrecios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Cambio el cursor a "WAIT"
            Me.Cursor = Cursors.WaitCursor

            'Cargo el combo con los proveedores.
            Dim dsProveedores As New DataSet
            dsProveedores = NegProveedor.ListadoProveedores()
            If dsProveedores.Tables(0).Rows.Count > 0 Then
                chk_Proveedores.DataSource = Nothing
                chk_Proveedores.DataSource = dsProveedores.Tables(0)
                chk_Proveedores.DisplayMember = "RazonSocial"
                chk_Proveedores.ValueMember = "id_Proveedor"
                chk_Proveedores.Refresh()
            End If

            'Default en combos.
            cb_Categoria.DataSource = Nothing
            cb_Categoria.Items.Clear()
            cb_Categoria.Items.Add("Todas las categorías.")
            cb_Categoria.SelectedItem = "Todas las categorías."
            cb_Categoria.Refresh()
            cb_Subcategoria.DataSource = Nothing
            cb_Subcategoria.Items.Clear()
            cb_Subcategoria.Items.Add("Todas las subcategorías.")
            cb_Subcategoria.SelectedItem = "Todas las subcategorías."
            cb_Subcategoria.Refresh()

            'Selecciono todos los precios por default.
            fuc.SetearCheckboxlist(chk_Precios, True)
            ContarCheckes()

            'Cambio el cursor a NORMAL.
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al cargar el formulario. Por favor, contactese con el administrador.", "Administración de Listas de Precios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Filtrar.
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If chk_Proveedores.CheckedItems.Count > 0 Then
                'Cambio el cursor a "WAIT"
                Me.Cursor = Cursors.WaitCursor

                'reseteo variables.
                StringProveedores = ""
                dsProductosFiltrados = Nothing

                'Obtengo los proveedores.
                For Each prov In chk_Proveedores.CheckedItems
                    Dim id_Proveedor As Integer = 0
                    id_Proveedor = prov.Row.ItemArray(0)
                    StringProveedores &= " id_Proveedor=" & id_Proveedor & " or"
                Next
                StringProveedores = StringProveedores.Substring(0, StringProveedores.Length - 3)

                'obtengo la categoria.
                If cb_Categoria.SelectedValue > 0 Then
                    StringProveedores &= ") and (id_Categoria=" & cb_Categoria.SelectedValue
                ElseIf cb_Categoria.SelectedValue > 0 And cb_Subcategoria.SelectedValue > 0 Then
                    StringProveedores &= ") and (id_Categoria=" & cb_Categoria.SelectedValue & ") and (id_Subcategoria=" & cb_Subcategoria.SelectedValue
                End If

                'Cargo el combo con los productos.

                dsProductosFiltrados = NegProductos.ListadoProductosPorProveedores(StringProveedores)
                If dsProductosFiltrados.Tables(0).Rows.Count > 0 Then
                    Chk_Productos.DataSource = Nothing
                    Chk_Productos.DataSource = dsProductosFiltrados.Tables(0)
                    Chk_Productos.DisplayMember = "Nombre"
                    Chk_Productos.ValueMember = "id_Producto"
                    Chk_Productos.Refresh()
                    lbl_Msg.Visible = False
                Else
                    Chk_Productos.DataSource = Nothing
                    lbl_Msg.Text = "No se encontraron productos."
                End If

                Ckb.Checked = False
                ContarCheckes()

                'Cambio el cursor a NORMAL.
                Me.Cursor = Cursors.Arrow
            Else
                MessageBox.Show("Debe seleccionar al menos un proveedor.", "Administración de Listas de Precios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("Se ha encontrado un error al filtrar los productos. Por favor, contactese con el administrador.", "Administración de Listas de Precios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Cargo el cambo con las categorias.
    Private Sub cb_Categoria_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Categoria.GotFocus
        Dim dsCategorias As New DataSet
        dsCategorias = NegProductosCat.ListadoCategorias()
        If dsCategorias.Tables(0).Rows.Count > 0 Then
            cb_Categoria.DataSource = Nothing
            cb_Categoria.DataSource = Funciones.CrearDataTable("id_Categoria", "Descripcion", dsCategorias, "Todas las categorías.")
            cb_Categoria.DisplayMember = "Descripcion"
            cb_Categoria.ValueMember = "id_Categoria"
            cb_Categoria.SelectedValue = 0
            cb_Categoria.Refresh()
            cb_Subcategoria.DataSource = Nothing            
            cb_Subcategoria.Refresh()
        End If
    End Sub

    'Cargo el combo con las subcategorias.
    Private Sub cb_Categoria_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_Categoria.SelectionChangeCommitted
        If cb_Categoria.SelectedValue <> 0 Then
            Dim dsSubcategorias As New DataSet
            dsSubcategorias = NegProductosSubCat.ListadoSubcategorias(cb_Categoria.SelectedValue)
            If dsSubcategorias.Tables(0).Rows.Count > 0 Then
                cb_Subcategoria.DataSource = Nothing
                cb_Subcategoria.DataSource = Funciones.CrearDataTable("id_Subcategoria", "Descripcion", dsSubcategorias, "Todas las subcategorías.")
                cb_Subcategoria.DisplayMember = "Descripcion"
                cb_Subcategoria.ValueMember = "id_Subcategoria"
                cb_Subcategoria.SelectedValue = 0
                cb_Subcategoria.Refresh()
            End If
        Else
            cb_Subcategoria.DataSource = Nothing
            cb_Subcategoria.Items.Clear()
            cb_Subcategoria.Items.Add("Todas las subcategorías.")
            cb_Subcategoria.SelectedItem = "Todas las subcategorías."
            cb_Subcategoria.Refresh()
        End If
    End Sub

    'limpiar formulario
    Sub Limpiar()
        'Limpiar controles.
        fuc.SetearCheckboxlist(chk_Proveedores, False)
        fuc.SetearCheckboxlist(Chk_Productos, False)
        fuc.SetearCheckboxlist(chk_Precios, True)
        chk_Proveedores.ClearSelected()
        Chk_Productos.ClearSelected()
        chk_Precios.ClearSelected()
        Chk_Productos.DataSource = Nothing
        lbl_Msg.Text = "Sin productos disponibles."
        lbl_Msg.Visible = True
        Ckb.Checked = False
        CheckEtiquetas.Checked = False
        cb_Categoria.SelectedItem = Nothing
        cb_Subcategoria.SelectedItem = Nothing
        cb_Subcategoria.DataSource = Nothing
        ContarCheckes()
        lbl_Contador2.Text = "( 0 )"
        LsProductos.DataSource = Nothing
    End Sub

    'Restablecer filtros.
    Private Sub btn_Restablecer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Restablecer.Click
        'Cambio el cursor a "WAIT".
        Me.Cursor = Cursors.WaitCursor

        Limpiar()

        'Cambio el cursor a NORMAL.
        Me.Cursor = Cursors.Arrow
    End Sub

    'Seleccionar todo!.
    Private Sub Ckb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ckb.CheckedChanged
        If Ckb.Checked Then
            fuc.SetearCheckboxlist(Chk_Productos, True)
        Else
            fuc.SetearCheckboxlist(Chk_Productos, False)
        End If
        ContarCheckes()
    End Sub

    'Arma el listado de precios.
    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        If LsProductos.Items.Count > 0 Then
            Me.Cursor = Cursors.WaitCursor
            Me.WindowState = FormWindowState.Minimized
            frmBrowser.Close()
            frmBrowser.Dispose()
            ArmarPDF()
            'If CheckEtiquetas.Checked Then
            '    frmReportePrecios.ChkProductos = Chk_Productos
            '    frmReportePrecios.ChkPrecios = chk_Precios
            '    fuc.ControlInstancia(frmReportePrecios).MdiParent = MDIContenedor
            '    fuc.ControlInstancia(frmReportePrecios).Show()
            'Else
            '    frmReportePreciosSE.ChkProductos = Chk_Productos
            '    frmReportePreciosSE.ChkPrecios = chk_Precios
            '    fuc.ControlInstancia(frmReportePreciosSE).MdiParent = MDIContenedor
            '    fuc.ControlInstancia(frmReportePreciosSE).Show()
            'End If
            Me.Cursor = Cursors.Arrow
        Else
            MessageBox.Show("Debe tener al menos un producto en la lista.", "Administración de Listas de Precios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Sub ContarCheckes()
        Dim cont As Integer = Chk_Productos.CheckedItems.Count
        lbl_Contador.Text = "Productos tildados ( " & cont & " )"
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Chk_Productos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_Productos.SelectedIndexChanged
        ContarCheckes()
    End Sub

    Sub ArmarPDF()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim EProductos As New Entidades.Productos
        Dim strPath As String
        Dim imgMemoryStream As MemoryStream = New MemoryStream()

        strPath = Application.StartupPath
        If strPath.EndsWith("\bin\Debug") Then
            strPath = strPath.Replace("\bin\Debug", "")
        End If

        If strPath.EndsWith("\bin\Release") Then
            strPath = strPath.Replace("\bin\Release", "")
        End If

        'Muestro el form de espera..
        frmCargadorDeEspera.Show()
        frmCargadorDeEspera.Text = "Generando pdf... "
        frmCargadorDeEspera.lbl_Descripcion.Text = "Iniciando... "
        frmCargadorDeEspera.BarraProgreso.Minimum = 0
        frmCargadorDeEspera.BarraProgreso.Maximum = LsProductos.Items.Count + 2
        frmCargadorDeEspera.BarraProgreso.Value = 1
        frmCargadorDeEspera.Refresh()


        dt = ds.Tables.Add("Productos")
        dt.Columns.Add("Codigo", Type.GetType("System.String"))
        dt.Columns.Add("Nombre", Type.GetType("System.String"))

        If CheckEtiquetas.CheckState Then
            dt.Columns.Add("CodigoBarra", GetType(Byte()))
        End If

        For Each item2 In chk_Precios.CheckedItems
            If item2 = "Costo" Then
                dt.Columns.Add("Costo", Type.GetType("System.Double"))
                dt.Columns("Costo").DefaultValue = 0
            ElseIf item2 = "Público Tigre" Then
                dt.Columns.Add("Precio1", Type.GetType("System.Double"))
                dt.Columns("Precio1").DefaultValue = 0
            ElseIf item2 = "Público Sarmiento" Then
                dt.Columns.Add("Precio2", Type.GetType("System.Double"))
                dt.Columns("Precio2").DefaultValue = 0
            ElseIf item2 = "Público Capital" Then
                dt.Columns.Add("Precio3", Type.GetType("System.Double"))
                dt.Columns("Precio3").DefaultValue = 0
            ElseIf item2 = "Mayorista SF" Then
                dt.Columns.Add("Precio4", Type.GetType("System.Double"))
                dt.Columns("Precio4").DefaultValue = 0
            ElseIf item2 = "Mayorista CF" Then
                dt.Columns.Add("Precio5", Type.GetType("System.Double"))
                dt.Columns("Precio5").DefaultValue = 0
            ElseIf item2 = "Mayorista CFR" Then
                dt.Columns.Add("Precio6", Type.GetType("System.Double"))
                dt.Columns("Precio6").DefaultValue = 0
            End If
        Next

        For Each item In LsProductos.Items

            'lleno la entidad productos
            EProductos = NegProductos.TraerProducto(item.row.ItemArray(0))

            If EProductos.id_Producto <> 0 Then

                'Voy seteando la barra de progreso
                frmCargadorDeEspera.lbl_Descripcion.Text = "Producto: " & EProductos.Nombre
                frmCargadorDeEspera.BarraProgreso.Value += 1
                frmCargadorDeEspera.Refresh()

                If CheckEtiquetas.CheckState Then
                    'Realizo el codigo de barras y lo asigno al picture
                    'esto lo uso para los seteos, no cambiarlos, mandar estos tal cual. 
                    Dim seteos As New CodigoBarras.Ean13Settings
                    seteos.BarCodeHeight = 80
                    seteos.BarWidth = 1
                    seteos.BottomMargin = 5
                    seteos.LeftMargin = 5
                    seteos.RightMargin = 5
                    seteos.TopMargin = 10
                    seteos.Font = New System.Drawing.Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular)

                    'aca genero el codigo
                    Dim CodigoBarras As New CodigoBarras.Ean13(EProductos.CodigoBarra, "", "", "", seteos)
                    Dim img As System.Drawing.Image = CodigoBarras.Paint()
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

                    For i = 3 To chk_Precios.CheckedItems.Count + 2
                        If chk_Precios.CheckedItems(i - 3) = "Costo" Then
                            dr(i) = EProductos.Costo
                        ElseIf chk_Precios.CheckedItems(i - 3) = "Público Tigre" Then
                            dr(i) = EProductos.Precio1
                        ElseIf chk_Precios.CheckedItems(i - 3) = "Público Sarmiento" Then
                            dr(i) = EProductos.Precio2
                        ElseIf chk_Precios.CheckedItems(i - 3) = "Público Capital" Then
                            dr(i) = EProductos.Precio3
                        ElseIf chk_Precios.CheckedItems(i - 3) = "Mayorista SF" Then
                            dr(i) = EProductos.Precio4
                        ElseIf chk_Precios.CheckedItems(i - 3) = "Mayorista CF" Then
                            dr(i) = EProductos.Precio5
                        ElseIf chk_Precios.CheckedItems(i - 3) = "Mayorista CFR" Then
                            dr(i) = EProductos.Precio6
                        End If
                    Next
                    dt.Rows.Add(dr)
                Else
                    Dim dr As DataRow = dt.NewRow()
                    dr(0) = EProductos.Codigo
                    dr(1) = EProductos.Nombre

                    For i = 2 To chk_Precios.CheckedItems.Count + 1
                        If chk_Precios.CheckedItems(i - 2) = "Costo" Then
                            dr(i) = EProductos.Costo
                        ElseIf chk_Precios.CheckedItems(i - 2) = "Público Tigre" Then
                            dr(i) = EProductos.Precio1
                        ElseIf chk_Precios.CheckedItems(i - 2) = "Público Sarmiento" Then
                            dr(i) = EProductos.Precio2
                        ElseIf chk_Precios.CheckedItems(i - 2) = "Público Capital" Then
                            dr(i) = EProductos.Precio3
                        ElseIf chk_Precios.CheckedItems(i - 2) = "Mayorista SF" Then
                            dr(i) = EProductos.Precio4
                        ElseIf chk_Precios.CheckedItems(i - 2) = "Mayorista CF" Then
                            dr(i) = EProductos.Precio5
                        ElseIf chk_Precios.CheckedItems(i - 2) = "Mayorista CFR" Then
                            dr(i) = EProductos.Precio6
                        End If
                    Next
                    dt.Rows.Add(dr)
                End If
            End If
        Next

        ExportDataToPDFTable(dt, CheckEtiquetas.CheckState)
    End Sub

    Private Sub ExportDataToPDFTable(ByVal dt As DataTable, ByVal CodigoBarra As Boolean)
        Dim doc As New Document(PageSize.A4, 5, 5, 20, 20)

        'Path donde se ubicará el pdf.
        Dim strPath As String = ""
        Dim pdfFilePath As String = ""
        strPath = Application.StartupPath
        If strPath.EndsWith("\bin\Debug") Then
            strPath = strPath.Replace("\bin\Debug", "")
        End If

        If strPath.EndsWith("\bin\Release") Then
            strPath = strPath.Replace("\bin\Release", "")
        End If

        Try
            'Voy seteando la barra de progreso
            frmCargadorDeEspera.lbl_Descripcion.Text = "Confeccionando pdf... "
            frmCargadorDeEspera.BarraProgreso.Value += 1
            frmCargadorDeEspera.Refresh()

            pdfFilePath = strPath & "\precios.pdf"

            'Create Document class object and set its size to letter and give space left, right, Top, Bottom Margin
            Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(pdfFilePath, FileMode.Create))

            'Open Document to write
            doc.Open()

            'Estilos
            FontFactory.RegisterDirectories()
            Dim fontBody As iTextSharp.text.Font = FontFactory.GetFont(BaseFont.HELVETICA, 9)
            Dim fontHead As iTextSharp.text.Font = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 10)
            Dim fontTitle As iTextSharp.text.Font = FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 25)
            Dim fontSubtitle As iTextSharp.text.Font = FontFactory.GetFont(BaseFont.HELVETICA_OBLIQUE, 12)

            'Cabecera
            Dim cabecera As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(strPath & "/Imagenes/top_reporte.jpg")
            cabecera.ScaleToFit(575.0F, 88.0F)

            'Subtitulo
            Dim paragraph2 As New Paragraph("  " & Date.Now.ToString("dd/MM/yyyy") & " - Listado de Precios", fontSubtitle)
            paragraph2.Alignment = Element.ALIGN_LEFT

            If dt IsNot Nothing Then
                'Craete instance of the pdf table and set the number of column in that table
                Dim PdfTable As New PdfPTable(dt.Columns.Count)
                Dim PdfPCell As PdfPCell = Nothing

                'Add Header of the pdf table
                PdfPCell = New PdfPCell(New Phrase(New Chunk("Código", fontHead)))
                PdfPCell.HorizontalAlignment = Element.ALIGN_LEFT
                PdfTable.AddCell(PdfPCell)

                PdfPCell = New PdfPCell(New Phrase(New Chunk("Nombre", fontHead)))
                PdfPCell.HorizontalAlignment = Element.ALIGN_LEFT
                PdfTable.AddCell(PdfPCell)

                If CodigoBarra Then
                    PdfPCell = New PdfPCell(New Phrase(New Chunk("Barra", fontHead)))
                    PdfTable.AddCell(PdfPCell)
                End If

                For Each item2 In chk_Precios.CheckedItems
                    If item2 = "Costo" Then
                        PdfPCell = New PdfPCell(New Phrase(New Chunk("Costo", fontHead)))
                    ElseIf item2 = "Público Tigre" Then
                        PdfPCell = New PdfPCell(New Phrase(New Chunk("Tigre", fontHead)))
                    ElseIf item2 = "Público Sarmiento" Then
                        PdfPCell = New PdfPCell(New Phrase(New Chunk("Sarm.", fontHead)))
                    ElseIf item2 = "Público Capital" Then
                        PdfPCell = New PdfPCell(New Phrase(New Chunk("Capital", fontHead)))
                    ElseIf item2 = "Mayorista SF" Then
                        PdfPCell = New PdfPCell(New Phrase(New Chunk("SF", fontHead)))
                    ElseIf item2 = "Mayorista CF" Then
                        PdfPCell = New PdfPCell(New Phrase(New Chunk("CF", fontHead)))
                    ElseIf item2 = "Mayorista CFR" Then
                        PdfPCell = New PdfPCell(New Phrase(New Chunk("CFR", fontHead)))
                    End If
                    PdfPCell.HorizontalAlignment = Element.ALIGN_CENTER
                    PdfTable.AddCell(PdfPCell)
                Next

                'How add the data from datatable to pdf table
                For rows As Integer = 0 To dt.Rows.Count - 1
                    For column As Integer = 0 To dt.Columns.Count - 1
                        If CodigoBarra Then
                            If column <= 1 Then
                                PdfPCell = New PdfPCell(New Phrase(New Chunk(dt.Rows(rows)(column).ToString(), fontBody)))
                                PdfPCell.MinimumHeight = 5.0F
                                PdfPCell.VerticalAlignment = Element.ALIGN_MIDDLE
                                PdfPCell.HorizontalAlignment = Element.ALIGN_LEFT
                            ElseIf column = 2 Then
                                Dim jpg As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(byteArrayToImage(dt.Rows(rows)(column)), System.Drawing.Imaging.ImageFormat.Jpeg)
                                ' jpg.ScaleToFit(114, 83)
                                jpg.Border = iTextSharp.text.Rectangle.BOX
                                jpg.BorderColor = BaseColor.BLACK
                                jpg.BorderWidth = 0.2F                            
                                PdfPCell = New PdfPCell(jpg, True)

                            Else
                                PdfPCell = New PdfPCell(New Phrase(New Chunk("$ " & Format(CType((dt.Rows(rows)(column).ToString()), Decimal), "###0.00"), fontBody)))
                                PdfPCell.MinimumHeight = 5.0F
                                PdfPCell.VerticalAlignment = Element.ALIGN_MIDDLE
                                PdfPCell.HorizontalAlignment = Element.ALIGN_CENTER
                            End If
                        Else
                            If column <= 1 Then
                                PdfPCell = New PdfPCell(New Phrase(New Chunk(dt.Rows(rows)(column).ToString(), fontBody)))
                                PdfPCell.MinimumHeight = 5.0F
                                PdfPCell.VerticalAlignment = Element.ALIGN_MIDDLE
                                PdfPCell.HorizontalAlignment = Element.ALIGN_LEFT
                            Else
                                PdfPCell = New PdfPCell(New Phrase(New Chunk("$ " & Format(CType((dt.Rows(rows)(column).ToString()), Decimal), "###0.00"), fontBody)))
                                PdfPCell.MinimumHeight = 5.0F
                                PdfPCell.VerticalAlignment = Element.ALIGN_MIDDLE
                                PdfPCell.HorizontalAlignment = Element.ALIGN_CENTER
                            End If
                        End If

                        PdfTable.AddCell(PdfPCell)

                    Next
                Next

                'Espacio entre la tabla.
                PdfTable.SpacingBefore = 15.0F

                'Sets de los anchos de columna.
                Dim columnWidths As Single() = GetTamañoColumnas(dt, CodigoBarra)
                PdfTable.SetWidths(columnWidths)
                PdfTable.TotalWidth = columnWidths.Sum()
                PdfTable.WidthPercentage = 95

                'Set de informacion del documento.
                doc.AddTitle("Cinderella - Listado de Precios")
                doc.AddSubject("Cinderella - Listado de Precios")
                doc.AddCreator("Sistema Cinderella")

                'Agrego la cabecera en el pdf.
                doc.Add(cabecera)

                'Agrego el subtitulo en el pdf.
                doc.Add(paragraph2)

                'Agrego la tabla en el pdf.
                doc.Add(PdfTable)

                'Voy seteando la barra de progreso
                frmCargadorDeEspera.Close()
                frmCargadorDeEspera.Dispose()

            End If
        Catch docEx As DocumentException
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()
            MessageBox.Show(docEx.Message.ToString, "Planilla de Precios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ioEx As IOException
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()
            MessageBox.Show(ioEx.Message.ToString, "Planilla de Precios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            frmCargadorDeEspera.Close()
            frmCargadorDeEspera.Dispose()
            MessageBox.Show(ex.Message.ToString, "Planilla de Precios", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            doc.Close()
            frmBrowser.Browser.Navigate(pdfFilePath)
            fuc.ControlInstancia(frmBrowser).MdiParent = MDIContenedor
            fuc.ControlInstancia(frmBrowser).Show()
        End Try
    End Sub

    'Convierte de tipo byte a image.
    Public Function byteArrayToImage(ByVal byteArrayIn As Byte()) As System.Drawing.Image
        Dim ms As New MemoryStream(byteArrayIn)
        Dim returnImage As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
        Return returnImage
    End Function

    'Función que arma los procentajes de ancho.
    Public Function GetTamañoColumnas(ByVal dt As DataTable, ByVal CodigoBarra As Boolean) As Single()
        Dim values As Single() = New Single(dt.Columns.Count - 1) {}
        For i As Integer = 0 To dt.Columns.Count - 1

            If Not CodigoBarra Then
                If i = 1 Then 'El nombre siempre tiene un porcentaje mayor.
                    values(i) = CSng(20)
                Else
                    values(i) = CSng(10)
                End If
            Else
                If i = 1 Then 'El nombre siempre tiene un porcentaje mayor.
                    values(i) = CSng(20)
                ElseIf i = 2 Then 'La foto tiene un porcentaje especifico.
                    If dt.Columns.Count > 6 Then
                        values(i) = CSng(20)
                    Else
                        values(i) = CSng(8)
                    End If
                Else
                    values(i) = CSng(10)
                End If
            End If

        Next
        Return values
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

    End Function

    'Funcion agregar productos tildados.
    Private Sub Btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Agregar.Click
        If Chk_Productos.CheckedItems.Count > 0 Then
            Me.Cursor = Cursors.WaitCursor

            'Creo la tabla temporal.
            Dim myTable As New DataTable()
            myTable.Columns.Add(New DataColumn("id_Producto", GetType(Integer)))
            myTable.Columns.Add(New DataColumn("Nombre", GetType(String)))
            myTable.Constraints.Add("id_Producto", myTable.Columns(0), True)

            'Agrego todos los productos tildados.
            For Each item In Chk_Productos.CheckedItems
                myTable.Rows.Add(item.row.ItemArray(1), item.row.ItemArray(0))
            Next

            'Agrego todos los productos que se encuentran en el listbox. ( sin repetidos )
            For Each item In LsProductos.Items            
                If myTable.Rows.Find(item.row.ItemArray(0)) Is Nothing Then
                    myTable.Rows.Add(item.row.ItemArray(0), item.row.ItemArray(1))
                End If
            Next

            'Reseteo Contadores
            lbl_Contador2.Text = "( " & myTable.Rows.Count & " )"
            lbl_Contador.Text = "Productos tildados ( 0 )"

            'Destildo los productos agregados.
            fuc.SetearCheckboxlist(chk_Proveedores, False)
            Chk_Productos.DataSource = Nothing
            chk_Proveedores.ClearSelected()
            lbl_Msg.Text = "Por favor, seleccione al menos un proveedor y presione 'filtrar'."
            lbl_Msg.Visible = True

            'Actualizo el listbox de los productos seleccionados.
            LsProductos.DataSource = Nothing
            LsProductos.DisplayMember = "Nombre"
            LsProductos.ValueMember = "id_Producto"
            LsProductos.DataSource = myTable
            LsProductos.Refresh()

            'reseteo variables.
            StringProveedores = ""
            dsProductosFiltrados = Nothing


            Me.Cursor = Cursors.Arrow
        Else
            MessageBox.Show("Debe seleccionar al menos un producto.", "Administración de Listas de Precios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'Textbox que busca dentro de los productos filtrados
    Private Sub txt_Busqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Busqueda.TextChanged
        'Cursor.
        Me.Cursor = Cursors.WaitCursor

        If dsProductosFiltrados IsNot Nothing Then
            'Seteo las variables.
            Dim descrip As String
            Dim dv As DataView
            descrip = Trim(txt_Busqueda.Text.ToLower)

            If descrip = "" Then
                dv = dsProductosFiltrados.Tables(0).DefaultView
            Else
                dv = dsProductosFiltrados.Tables(0).DefaultView
                dv.RowFilter = "Nombre LIKE '%" + descrip + "%' or Codigo LIKE '%" + descrip + "%'"
            End If

            'actualizo el datagrid
            If dv.Count > 0 Then
                Chk_Productos.DataSource = dv
                Chk_Productos.DisplayMember = "Nombre"
                Chk_Productos.ValueMember = "id_Producto"
                Chk_Productos.Refresh()
                lbl_Msg.Visible = False
            Else
                Chk_Productos.DataSource = Nothing
                Chk_Productos.Refresh()
                lbl_Msg.Visible = True
            End If
        End If
        'Cursor.
        Me.Cursor = Cursors.Arrow
    End Sub
End Class