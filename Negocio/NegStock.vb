Imports Entidades
Imports System.Data.SqlClient
Imports Datos
Imports Microsoft.Office.Interop
Imports System.Globalization
Imports System.Data.OleDb

Public Class NegStock
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    Public Delegate Sub UpdateProgressDelegate(ProgressStep As Integer, ProgressText As String)
    Public Event UpdateProgress As UpdateProgressDelegate

    Const NewRowsData As Integer = 500
    Const MinRowsData As Integer = 2
    'Funcion para listar todos los productos.
    Function ListadoStockSucursal(ByVal id_Sucursal As Integer) As DataSet
        Return clsDatos.ConsultarBaseLocal("execute sp_Stock_ListadoSucursal @id_Sucursal=" & id_Sucursal)
    End Function

    'Funcion que me trae el id del ultimo producto.
    Function UltimoStock() As Integer
        Dim ds As DataSet

        ds = clsDatos.ConsultarBaseLocal("Select IDENT_CURRENT('STOCK')  as id_Stock")

        If ds.Tables(0).Rows.Count = 1 And CInt(ds.Tables(0).Rows(0).Item("id_Stock")) > 0 Then
            Return ds.Tables(0).Rows(0).Item("id_Stock").ToString
        Else
            Return 1
        End If
    End Function

    'Funcion para consultar un stock determinado.
    Public Function TraerStock(ByVal id_Stock As Int64)
        Dim dsStock As New DataSet
        Dim entStock As New Entidades.Stock

        dsStock = clsDatos.ConsultarBaseLocal("execute sp_Stock_Detalle @id_Stock=" & id_Stock)

        If dsStock.Tables(0).Rows.Count <> 0 Then
            entStock = ObtenerEntidadStock(dsStock.Tables(0).Rows(0))
        End If

        Return entStock
    End Function

    'Funcion para consultar un stock determinado.
    Public Function ListadoStock(idSucursal As Integer, idProveedor As Integer)
        Dim dsStock As New DataSet
        Dim entStock As List(Of Stock) = New List(Of Stock)

        dsStock = clsDatos.ConsultarBaseLocal("execute sp_Stock_ListadoSucursalProveedor @id_Sucursal=" & idSucursal & ", @id_Proveedor=" & idProveedor)

        If dsStock.Tables(0).Rows.Count <> 0 Then
            For Each dr As DataRow In dsStock.Tables(0).Rows
                entStock.Add(ObtenerEntidadStock(dr))
            Next
        End If
        Return entStock
    End Function

    Function CalculaVentaMensual(idSucursal As Integer, fechaDesde As Date, fechaHasta As Date) As String
        'Declaro variables
        Dim respuesta As String
        Dim cmd As SqlCommand

        cmd = New SqlCommand
        cmd.Connection = clsDatos.ConectarLocal()
        respuesta = CalculaVentaMensual(idSucursal, fechaDesde, fechaHasta, cmd)
        clsDatos.DesconectarLocal()

        Return respuesta
    End Function

    Private Shared Function CalculaVentaMensual(idSucursal As Integer, fechaDesde As Date, fechaHasta As Date, ByRef cmd As SqlCommand) As String
        'Ejecuto el Stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Stock_Calcula_VentaMensual"
        With cmd.Parameters
            .AddWithValue("@id_Sucursal", idSucursal)
            .AddWithValue("@FechaDesde", fechaDesde)
            .AddWithValue("@FechaHasta", fechaHasta)
        End With

        'Respuesta del Stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    Sub ActualizarUltimoCalculoVentaMensual(idSucursal As Integer)
        'Declaro variables
        Dim cmd As SqlCommand
        Dim fecha As Date = Date.Now

        cmd = New SqlCommand
        cmd.Connection = clsDatos.ConectarLocal()
        ActualizarUltimoCalculoVentaMensual(idSucursal, fecha, cmd)
        clsDatos.DesconectarLocal()

    End Sub

    Private Shared Sub ActualizarUltimoCalculoVentaMensual(idSucursal As Integer, fecha As Date, ByRef cmd As SqlCommand)
        'Ejecuto el Stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_CalculoVentaMensual_Actualizar"
        With cmd.Parameters
            .AddWithValue("@id_Sucursal", idSucursal)
            .AddWithValue("@fecha", fecha)
        End With

        'Respuesta del Stored.
        cmd.ExecuteNonQuery()
    End Sub

    Function ObtenerUltimoCalculoVentaMensual(ByVal idSucursal As Integer) As Date?
        'Declaro variables
        Dim fecha As Date?
        Dim cmd As SqlCommand

        cmd = New SqlCommand()
        cmd.Connection = clsDatos.ConectarLocal()
        fecha = ObtenerUltimoCalculoVentaMensual(idSucursal, cmd)
        clsDatos.DesconectarLocal()

        Return fecha
    End Function

    Private Shared Function ObtenerUltimoCalculoVentaMensual(ByVal idSucursal As Integer, ByRef cmd As SqlCommand) As Date?
        'Ejecuto el Stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_CalculoVentaMensual_Obtener_Ultima"
        With cmd.Parameters
            .AddWithValue("@id_Sucursal", idSucursal)
        End With

        'Respuesta del Stored.
        Dim respuesta As New SqlParameter("@fecha", SqlDbType.Date, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()

        If (respuesta.Value Is DBNull.Value) Then

            Return Nothing
        Else
            Return respuesta.Value
        End If
    End Function

    Private Shared Function ObtenerEntidadStock(dr As DataRow) As Stock
        Dim entStock As New Entidades.Stock
        entStock.id_Stock = dr.Item("id_Stock").ToString
        entStock.id_Producto = dr.Item("id_Producto").ToString
        entStock.id_Sucursal = dr.Item("id_Sucursal").ToString
        entStock.Stock_Actual = dr.Item("Stock_Actual").ToString
        entStock.Stock_Minimo = dr.Item("Stock_Minimo").ToString
        entStock.Stock_Optimo = dr.Item("Stock_Optimo").ToString
        entStock.VentaMensual = If(dr.Item("Venta_Mensual") Is DBNull.Value, 0, dr.Item("Venta_Mensual"))
        entStock.Habilitado = dr.Item("Habilitado").ToString
        entStock.Usuario = dr.Item("Usuario").ToString
        entStock.id_Usuario = dr.Item("id_Usuario").ToString
        entStock.Motivo = dr.Item("Motivo_Mod").ToString
        entStock.Modificado = dr.Item("Modificado").ToString
        entStock.Fecha_Mod = dr.Item("Fecha_Mod").ToString
        entStock.Fecha = dr.Item("Fecha").ToString
        Return entStock
    End Function

    'Funcion para consultar un stock determinado dependiendo del producto y la sucursal.
    Public Function TraerStockProducto(ByVal id_Producto As Integer, ByVal id_Sucursal As Integer)
        Dim dsStock As New DataSet
        Dim entStock As New Entidades.Stock

        dsStock = clsDatos.ConsultarBaseLocal("execute sp_Stock_Producto_Detalle @id_Producto=" & id_Producto & ", @id_Sucursal=" & id_Sucursal)

        If dsStock.Tables(0).Rows.Count <> 0 Then
            entStock.id_Stock = dsStock.Tables(0).Rows(0).Item("id_Stock").ToString
            entStock.id_Producto = dsStock.Tables(0).Rows(0).Item("id_Producto").ToString
            entStock.id_Sucursal = dsStock.Tables(0).Rows(0).Item("id_Sucursal").ToString
            entStock.Stock_Actual = dsStock.Tables(0).Rows(0).Item("Stock_Actual").ToString
            entStock.Stock_Minimo = dsStock.Tables(0).Rows(0).Item("Stock_Minimo").ToString
            entStock.Stock_Optimo = dsStock.Tables(0).Rows(0).Item("Stock_Optimo").ToString
            entStock.VentaMensual = If(String.IsNullOrEmpty(dsStock.Tables(0).Rows(0).Item("Venta_Mensual")), 0, dsStock.Tables(0).Rows(0).Item("Venta_Mensual"))
            entStock.Habilitado = dsStock.Tables(0).Rows(0).Item("Habilitado")
            entStock.Fecha = dsStock.Tables(0).Rows(0).Item("Fecha").ToString
        End If
        Return entStock
    End Function

    'Funcion para insertar un stock.
    Function AltaStock(ByVal estock As Entidades.Stock) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        estock.id_Stock = clsDatos.ObtenerCalveUnica(estock.id_Sucursal)
        estock.FechaEdicion = DateTime.Now()

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = AltaStock(estock, cmd)
            clsDatos.DesconectarLocal()

            'muestro el mensaje
            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Function AltaStock(estock As Stock, ByRef cmd As SqlCommand) As String
        'Ejecuto el Stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Stock_Alta"
        With cmd.Parameters
            .AddWithValue("@id_Sotck", estock.id_Stock)
            .AddWithValue("@id_Producto", estock.id_Producto)
            .AddWithValue("@id_Sucursal", estock.id_Sucursal)
            .AddWithValue("@Stock_Minimo", estock.Stock_Minimo)
            .AddWithValue("@Stock_Actual", estock.Stock_Actual)
            .AddWithValue("@Stock_Optimo", estock.Stock_Optimo)
            .AddWithValue("@VentaMensual", estock.VentaMensual)
            .AddWithValue("@id_Usuario", estock.id_Usuario)
            .AddWithValue("@Motivo_Mod", estock.Motivo)
            .AddWithValue("@Modificado", estock.Modificado)
            .AddWithValue("@Fecha_Mod", estock.Fecha_Mod)
            .AddWithValue("@Habilitado", estock.Habilitado)
            .AddWithValue("@FechaEdicion", estock.FechaEdicion)
        End With

        'Respuesta del Stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value

    End Function

    'Funcion para modificar un stock.
    Function ModificacionStock(ByVal estock As Entidades.Stock) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        estock.FechaEdicion = DateTime.Now()

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = ModificarStock(estock, cmd)
            clsDatos.DesconectarLocal()

            'muestro el mensaje
            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    Private Shared Function ModificarStock(estock As Stock, ByRef cmd As SqlCommand) As String
        'Ejecuto el Stored. 
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Stock_Modificacion"
        With cmd.Parameters
            .AddWithValue("@id_Producto", estock.id_Producto)
            .AddWithValue("@id_Stock", estock.id_Stock)
            .AddWithValue("@id_Sucursal", estock.id_Sucursal)
            .AddWithValue("@Stock_Minimo", estock.Stock_Minimo)
            .AddWithValue("@Stock_Actual", estock.Stock_Actual)
            .AddWithValue("@Stock_Optimo", estock.Stock_Optimo)
            .AddWithValue("@VentaMensual", estock.VentaMensual)
            .AddWithValue("@Habilitado", estock.Habilitado)
            .AddWithValue("@id_Usuario", estock.id_Usuario)
            .AddWithValue("@Motivo_Mod", estock.Motivo)
            .AddWithValue("@Modificado", estock.Modificado)
            .AddWithValue("@Fecha_Mod", estock.Fecha_Mod)
            .AddWithValue("@FechaEdicion", estock.FechaEdicion)
        End With
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    'Funcion para eliminar un stock.
    Function EliminarStock(ByVal id_Stock As Int64) As String
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim fechaEdicion As DateTime = DateTime.Now()

        Try
            cmd.Connection = clsDatos.ConectarLocal()
            msg = EliminarStock(id_Stock, fechaEdicion, cmd)
            clsDatos.DesconectarLocal()

            Return msg
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    Private Shared Function EliminarStock(id_Stock As Int64, fechaEdicion As DateTime, ByRef cmd As SqlCommand) As String
        'Ejecuto el Stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Stock_Eliminar"
        With cmd.Parameters
            .AddWithValue("@id_Stock", id_Stock)
            .AddWithValue("@FechaEdicion", fechaEdicion)
        End With

        'Respuesta del Stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
        Return respuesta.Value
    End Function

    'Funcion que comprueba el stock para una cantidad y producto determinado.
    Function ComprobarStock(ByVal id_Producto As Integer, ByVal Cantidad As Integer, ByVal id_Sucursal As Integer) As Boolean
        Dim dsStock As New DataSet
        dsStock = clsDatos.ConsultarBaseLocal("execute sp_Stock_Disponibilidad @id_Producto=" & id_Producto & ", @Cantidad=" & Cantidad & ", @id_Sucursal=" & id_Sucursal)

        If dsStock.Tables(0).Rows(0).Item(0).ToString > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Funcion que disminuye el stock del producto.
    Function DisminuirStock(ByVal id_Producto As Integer, ByVal Cantidad As Integer, ByVal id_Sucursal As Integer)
        Dim eStock As Entidades.Stock
        Dim dsStock As New DataSet
        Dim cmd As New SqlCommand
        Dim msg As Boolean = False

        Try
            eStock = TraerStockProducto(id_Producto, id_Sucursal)
            'Si no existe el producto en la sucursal
            If eStock.id_Stock <> 0 Then

                cmd.Connection = clsDatos.ConectarLocal()
                DisminuirStock(id_Producto, Cantidad, id_Sucursal, cmd)
                clsDatos.DesconectarLocal()

            Else
                eStock.Habilitado = 1
                eStock.id_Producto = id_Producto
                eStock.id_Sucursal = id_Sucursal
                eStock.Stock_Minimo = 0
                eStock.Stock_Actual = -Cantidad
                eStock.Stock_Optimo = 0
                eStock.Motivo = ""
                eStock.Modificado = 0
                eStock.Fecha_Mod = Now
                AltaStock(eStock)
            End If
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Shared Sub DisminuirStock(id_Producto As Integer, Cantidad As Integer, id_Sucursal As Integer, ByRef cmd As SqlCommand)
        'Ejecuto el Stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Stock_Disminucion"
        With cmd.Parameters
            .AddWithValue("@id_Producto", id_Producto)
            .AddWithValue("@cantidad", Cantidad)
            .AddWithValue("@id_Sucursal", id_Sucursal)
        End With

        'Respuesta del Stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
    End Sub

    'Update Stock.
    Function AgregarStock(ByVal id_Producto As Integer, ByVal id_Sucursal As Integer, ByVal Stock As Integer)
        Dim eStock As Entidades.Stock
        Dim Estado As Boolean = False
        eStock = TraerStockProducto(id_Producto, id_Sucursal)

        'Si no exite el producto en la sucursal
        If eStock.id_Stock <> 0 Then
            Try
                'Declaro variables
                Dim cmd As New SqlCommand
                Dim msg As String = ""
                Dim NuevoStock As Integer = 0
                NuevoStock = eStock.Stock_Actual + Stock

                eStock.FechaEdicion = DateTime.Now()

                cmd.Connection = clsDatos.ConectarLocal()
                AgregarStock(eStock, cmd, NuevoStock)
                clsDatos.DesconectarLocal()

                'muestro el mensaje
                Estado = True
            Catch ex As Exception
                Estado = False
            End Try
        Else
            Try
                eStock.Habilitado = 1
                eStock.id_Producto = id_Producto
                eStock.id_Sucursal = id_Sucursal
                eStock.Stock_Minimo = 0
                eStock.Stock_Actual = Stock
                eStock.Stock_Optimo = 0
                eStock.Motivo = ""
                eStock.Modificado = 0
                eStock.Fecha_Mod = Now
                AltaStock(eStock)
                Estado = True
            Catch ex As Exception
                Estado = False
            End Try
        End If

        Return Estado

    End Function

    Private Shared Sub AgregarStock(eStock As Stock, ByRef cmd As SqlCommand, NuevoStock As Integer)
        'Ejecuto el Stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Stock_Agregar"
        With cmd.Parameters
            .AddWithValue("@id_Producto", eStock.id_Producto)
            .AddWithValue("@id_Sucursal", eStock.id_Sucursal)
            .AddWithValue("@NuevoStock", NuevoStock)
            .AddWithValue("@FechaEdicion", eStock.FechaEdicion)
        End With

        'Respuesta del Stored.
        Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)
        cmd.ExecuteNonQuery()
    End Sub

    'Funcion que comprueba si el producto posee mas stock que el minimo permitido.
    Function ComprobarStockMinimo(ByVal id_Producto As Integer, ByVal id_Sucursal As Integer) As Boolean
        Dim dsStock As New DataSet
        dsStock = clsDatos.ConsultarBaseLocal("execute sp_Stock_DisponibilidadMinima @id_Producto=" & id_Producto & ", @id_Sucursal=" & id_Sucursal)

        If dsStock.Tables(0).Rows(0).Item("Stock_Actual") >= dsStock.Tables(0).Rows(0).Item("Stock_Minimo") Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function CrearExcelStock(nombreArchivo As String, nombrePlantilla As String, dsProductos As DataSet, ByRef xlApp As Excel.Application, ByRef xlWorkBook As Excel.Workbook, ByRef xlWorkSheet As Excel.Worksheet, misValue As Object) As Boolean
        xlApp = New Excel.Application()
        xlWorkBook = xlApp.Workbooks.Add(System.IO.Path.GetFullPath(nombrePlantilla))
        xlWorkSheet = CType(xlWorkBook.Worksheets.Item(1), Excel.Worksheet)

        Dim cExcelCulture As CultureInfo = New CultureInfo(xlApp.LanguageSettings.LanguageID(Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDUI))

        xlWorkSheet.Name = "Productos"

        AddDataSetToWorkSheet(dsProductos, xlWorkSheet)

        Dim MaxRowsData = dsProductos.Tables(0).Rows.Count + NewRowsData

        AgregarEstilo(xlWorkSheet, MaxRowsData)

        '//Oculto la primera columan ya que en esta se eunetra el ID del producto y no debe ser modificado
        xlWorkSheet.Range("A1").EntireColumn.Hidden = True
        xlWorkSheet.Range("B1").EntireColumn.Hidden = True
        Return True
    End Function

    Private Sub AgregarEstilo(xlWorkSheet As Excel.Worksheet, RowCount As Integer)
        Dim Range As Excel.Range = xlWorkSheet.Range("2:3")
        Range.Copy(Type.Missing)

        Dim Range2 As Excel.Range = xlWorkSheet.Range(String.Format("2:{0}", RowCount.ToString()))
        Range2.PasteSpecial(Excel.XlPasteType.xlPasteFormats, Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, False, False)
    End Sub

    Private Sub AddDataSetToWorkSheet(dsProductos As DataSet, xlWorkSheet As Excel.Worksheet)
        Dim data(dsProductos.Tables(0).Rows.Count + 1, dsProductos.Tables(0).Columns.Count) As Object

        'Agrego el nombre de la Columna
        For i As Integer = 0 To dsProductos.Tables(0).Columns.Count - 1
            data(0, i) = dsProductos.Tables(0).Columns(i).ColumnName
        Next

        'Agrego los datos de la tabla
        For i As Integer = 0 To dsProductos.Tables(0).Rows.Count - 1
            For j As Integer = 0 To dsProductos.Tables(0).Columns.Count - 1

                'Sumo 1 porque la posicion 0 le pertenece a las columnas
                data(i + 1, j) = dsProductos.Tables(0).Rows(i).ItemArray(j)
            Next
        Next


        Dim startCell As Excel.Range = CType(xlWorkSheet.Cells(1, 1), Excel.Range)
        Dim endCell As Excel.Range = CType(xlWorkSheet.Cells(dsProductos.Tables(0).Rows.Count + 1, dsProductos.Tables(0).Columns.Count), Excel.Range)
        Dim writeRange As Excel.Range = xlWorkSheet.Range(startCell, endCell)
        writeRange.Value2 = data
        writeRange.Columns.AutoFit()
    End Sub

    Sub ExportarExcelStock(idSucursal As Integer, nombreArchivo As String, nombrePlantilla As String)
        Dim cmd As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dsStock As DataSet = New DataSet()
        Dim dsCategoria As DataSet = New DataSet()
        Dim dsSubCategoria As DataSet = New DataSet()
        Dim dsProveedor As DataSet = New DataSet()

        cmd.Connection = clsDatos.ConectarLocal()
        cmd.CommandType = CommandType.StoredProcedure

        RaiseEvent UpdateProgress(1, "Obteniendo Productos...")
        cmd.CommandText = "sp_Productos_ListadoExcel_Sucursal"
        With cmd.Parameters
            .AddWithValue("@IdSucursal", idSucursal)
        End With
        adapter = New SqlDataAdapter(cmd)
        adapter.Fill(dsStock)

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim generoArchivo As Boolean = False

        For reintentos = 1 To 10
            Try
                generoArchivo = CrearExcelStock(nombreArchivo, nombrePlantilla, dsStock, xlApp, xlWorkBook, xlWorkSheet, misValue)
                Exit For
            Catch ex As System.Runtime.InteropServices.COMException
                LogHelper.WriteLog("ERROR Metodo: ExportarExcel Reintento " + reintentos.ToString() + Environment.NewLine + ex.ToString())
                Dim result As UInt32
                If UInt32.TryParse(ex.ErrorCode, result) AndAlso result = &H80010001UI Then
                    reintentos += 1
                    System.Threading.Thread.Sleep(1000)
                End If
            Catch ex As Exception
                LogHelper.WriteLog("ERROR Metodo: ExportarExcel" + Environment.NewLine + ex.ToString())
            End Try
        Next

        If Not generoArchivo Then
            Throw New Exception("Se realizaron 10 intentos de generación del Excel sin éxito.")
        End If

        RaiseEvent UpdateProgress(5, "Guardando Excel...")
        xlApp.DisplayAlerts = False
        xlWorkBook.SaveAs(nombreArchivo, Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, False, False, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlUserResolution, True, misValue, misValue, misValue)
        xlApp.DisplayAlerts = True
        xlWorkBook.Close(0)
        xlApp.Workbooks.Close()
        xlApp.Quit()

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

    Function ImportarExcelStock(idSucursal As Integer, idUsuario As Integer, usuario As String, fileName As String) As String

        Dim cmd As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dsStockRemoto As DataSet = New DataSet()
        Dim dsStockRemotoBitacora As DataSet = New DataSet()
        Dim dsStockActual As DataSet = New DataSet()
        Dim dtStockNuevo As DataTable
        Dim stock As List(Of String) = New List(Of String)
        Dim bitacoras As List(Of String) = New List(Of String)

        cmd.Connection = clsDatos.ConectarLocal()
        cmd.CommandType = CommandType.StoredProcedure

        RaiseEvent UpdateProgress(1, "Obteniendo Productos...")
        cmd.CommandText = "sp_Stock_ListadoSucursal"
        With cmd.Parameters
            .AddWithValue("@Id_Sucursal", idSucursal)
        End With
        adapter = New SqlDataAdapter(cmd)
        adapter.Fill(dsStockActual)

        clsDatos.DesconectarLocal()

        RaiseEvent UpdateProgress(2, "Obteniendo informacion del Excel...")
        dtStockNuevo = GetDataFormExcel(fileName, "Productos").Tables(0)

        If Not (verificarColumnasExcelSucursal(dtStockNuevo)) Then
            Return "El documento Excel que se está intentando importar se encuentra corrupto o es un documento que no fue generado por el proceso de exportación. Recuerde que solo puede modificar la información del documento exportado, no así el orden y nombre de las columnas."
        End If

        RaiseEvent UpdateProgress(3, "Validando informacion del Excel...")

        Dim fecha As String = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")
        Dim motivo As String = "Actualizado desde archive excel"

        ''busco las altas, modificaciones y bajas de stock
        For Each dato In dtStockNuevo.Rows

            'si no se cargo ningun valor en StockMinimo StockActual StockOptimo VentaMensual no importo el registro
            If dato("StockMinimo") Is DBNull.Value Or dato("StockActual") Is DBNull.Value Or dato("StockOptimo") Is DBNull.Value Or dato("VentaMensual") Is DBNull.Value Then
                Continue For
            End If

            Dim stockActual As DataRow = dsStockActual.Tables(0).Rows.Cast(Of DataRow)().FirstOrDefault(Function(x) dato("Codigo") = x("Codigo"))

            'El sotck existe             
            If stockActual IsNot Nothing Then
                'Si se modifico algunos de los valores del stock
                If stockActual("Stock_Minimo") <> dato("StockMinimo") Or stockActual("Stock_Actual") <> dato("StockActual") Or stockActual("Stock_Optimo") <> dato("StockOptimo") Or stockActual("Venta_Mensual") <> dato("VentaMensual") Then

                    Dim idBitacora As String = clsDatos.ObtenerCalveUnica(idSucursal).ToString()
                    'Doy de alta la bitacora
                    Dim bitacora As String = String.Format("INSERT INTO STOCK_BITACORA ([id_Bitacora],[id_Producto],[id_Sucursal],[id_Stock],[Accion],[Stock_Minimo_Ant],[Stock_Actual_Ant],[Stock_Optimo_Ant],[Stock_Minimo],[Stock_Actual],[Stock_Optimo],[Fecha],[Motivo],[id_Usuario],[Usuario],[Habilitado],[Fecha_Edicion],[Venta_Mensual_Ant],[Venta_Mensual]) VALUES({0},{1},{2},{3},'{4}',{5},{6},{7},{8},{9},{10},'{11}','{12}',{13},'{14}',{15},'{16}',{17},{18})",
                             idBitacora, dato("id_producto"), idSucursal, stockActual("id_stock"), "Modificación", stockActual("Stock_Minimo"), stockActual("Stock_Actual"), stockActual("Stock_Optimo"), dato("StockMinimo"), dato("StockActual"), dato("StockOptimo"), fecha, motivo, idUsuario, usuario, "0", fecha, stockActual("Venta_Mensual"), dato("VentaMensual"))

                    bitacoras.Add(bitacora)

                    'Actualizo el stock
                    Dim update = String.Format("update stock set Modificado = {0}, Stock_Minimo = {1}, Stock_Actual = {2} , Stock_Optimo = {3}, Fecha_Mod = '{4}', id_Usuario = {5}, Motivo_Mod = '{6}', Fecha_Edicion = '{7}', Venta_Mensual = {8} where id_Producto = {9} and id_Sucursal = {10} and Borrado = 0;",
                                     "1", dato("StockMinimo"), dato("StockActual"), dato("StockOptimo"), DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"), idUsuario, "Actualizado desde archive excel", DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"), dato("VentaMensual"), dato("id_producto"), idSucursal.ToString())
                    stock.Add(update)
                End If

                'el stock no existe
            ElseIf Integer.Parse(dato("StockActual")) <> 0 Or Integer.Parse(dato("StockOptimo")) <> 0 Or Integer.Parse(dato("StockMinimo")) <> 0 Or Integer.Parse(dato("VentaMensual")) <> 0 Then

                Dim idStock As String = clsDatos.ObtenerCalveUnica(idSucursal).ToString()
                Dim idBitacora As String = clsDatos.ObtenerCalveUnica(idSucursal).ToString()

                'Doy de alta la bitacora
                Dim bitacora = String.Format("INSERT INTO STOCK_BITACORA ([id_Bitacora],[id_Producto],[id_Sucursal],[id_Stock],[Accion],[Stock_Minimo_Ant],[Stock_Actual_Ant],[Stock_Optimo_Ant],[Stock_Minimo],[Stock_Actual],[Stock_Optimo],[Fecha],[Motivo],[id_Usuario],[Usuario],[Habilitado],[Fecha_Edicion],[Venta_Mensual_Ant],[Venta_Mensual]) VALUES({0},{1},{2},{3},'{4}',{5},{6},{7},{8},{9},{10},'{11}','{12}',{13},'{14}',{15},'{16}',{17},{18})",
                             idBitacora, dato("id_producto"), idSucursal, idStock.ToString(), "Alta", "0", "0", "0", dato("StockMinimo"), dato("StockActual"), dato("StockOptimo"), fecha, motivo, idUsuario, usuario, "0", fecha, "0", dato("VentaMensual"))

                bitacoras.Add(bitacora)

                'Inserto el sotck
                Dim insert = String.Format("INSERT INTO dbo.STOCK (id_Stock,id_Producto,id_Sucursal,Stock_Actual,Stock_Minimo,Stock_Optimo,Habilitado,Fecha,id_Usuario,Motivo_Mod,Fecha_Mod,Modificado,Borrado,Fecha_Edicion,Venta_Mensual) VALUES({0},{1},{2},{3},{4},{5},{6},'{7}',{8},'{9}','{10}',{11},{12},'{13}',{14});",
                                           idStock, dato("id_producto"), idSucursal.ToString(), dato("StockActual"), dato("StockMinimo"), dato("StockOptimo"), "1", fecha, idUsuario, "", fecha, "0", "0", fecha, dato("VentaMensual"))
                stock.Add(insert)

            End If
        Next

        If (stock.Count > 0) Then

            Dim conexionLocal As SqlConnection = clsDatos.ConectarLocal()
            Dim transaccionLocal As SqlTransaction = conexionLocal.BeginTransaction()

            Try
                For i = 0 To stock.Count Step 200
                    Dim cantidad As Integer = If(i + 200 > stock.Count, stock.Count, i + 200)
                    RaiseEvent UpdateProgress(4, String.Format("Actualizando informacion en la base de datos {0} de {1}", cantidad.ToString(), stock.Count.ToString()))
                    Dim sql As String = stock.Skip(i).Take(200).Aggregate(Function(x, y) x + " " + y)
                    Dim sqlbitacoras As String = bitacoras.Skip(i).Take(200).Aggregate(Function(x, y) x + " " + y)

                    Dim cmdRemoto As SqlCommand = New SqlCommand(sql, conexionLocal)
                    Dim cmdBitacoraRemoto As SqlCommand = New SqlCommand(sqlbitacoras, conexionLocal)
                    cmdRemoto.Transaction = transaccionLocal
                    cmdRemoto.ExecuteNonQuery()
                    cmdBitacoraRemoto.Transaction = transaccionLocal
                    cmdBitacoraRemoto.ExecuteNonQuery()
                Next

                'Dim cmdEliminoDatosLocal As SqlCommand = New SqlCommand($"delete from STOCK where id_Sucursal = {idSucursal}", conexionLocal, transaccionLocal)
                'cmdEliminoDatosLocal.ExecuteNonQuery()

                'Dim cmdEliminoDatosBitacoraLocal As SqlCommand = New SqlCommand($"delete from STOCK_BITACORA where id_Sucursal = {idSucursal}", conexionLocal, transaccionLocal)
                'cmdEliminoDatosBitacoraLocal.ExecuteNonQuery()

                'Dim cmdDatosRemotos As SqlCommand = New SqlCommand($"select * from STOCK where id_Sucursal = {idSucursal}", conexionRemota, transaccionRemota)
                'adapter = New SqlDataAdapter(cmdDatosRemotos)
                'adapter.Fill(dsStockRemoto)

                'Dim cmdDatosRemotosBitacora As SqlCommand = New SqlCommand($"select * from STOCK_BITACORA where id_Sucursal = {idSucursal}", conexionRemota, transaccionRemota)
                'adapter = New SqlDataAdapter(cmdDatosRemotosBitacora)
                'adapter.Fill(dsStockRemotoBitacora)

                'copio el stock a la base local
                'Dim BulkCopy As New SqlBulkCopy(conexionLocal, SqlBulkCopyOptions.KeepIdentity, transaccionLocal)
                'For Each column As DataColumn In dsStockRemoto.Tables(0).Columns
                '    BulkCopy.ColumnMappings.Add(New SqlBulkCopyColumnMapping(column.ColumnName, column.ColumnName))
                'Next
                'BulkCopy.DestinationTableName = "STOCK"
                'BulkCopy.WriteToServer(dsStockRemoto.Tables(0))
                'BulkCopy.Close()

                'copio la bitacora a la base local
                'Dim BulkCopyBitacora As New SqlBulkCopy(conexionLocal, SqlBulkCopyOptions.KeepIdentity, transaccionLocal)
                'For Each column As DataColumn In dsStockRemotoBitacora.Tables(0).Columns
                '    BulkCopyBitacora.ColumnMappings.Add(New SqlBulkCopyColumnMapping(column.ColumnName, column.ColumnName))
                'Next
                'BulkCopyBitacora.DestinationTableName = "STOCK_BITACORA"
                'BulkCopyBitacora.WriteToServer(dsStockRemotoBitacora.Tables(0))
                'BulkCopyBitacora.Close()

                'transaccionRemota.Commit()
                transaccionLocal.Commit()
                'clsDatos.DesconectarRemoto()
                clsDatos.DesconectarLocal()
            Catch ex As Exception
                'transaccionRemota.Rollback()
                transaccionLocal.Rollback()
                'clsDatos.DesconectarRemoto()
                clsDatos.DesconectarLocal()
                Throw
            End Try
            Return String.Format("Se han actualizado {0} elementos.", stock.Count)
        Else
            Return "No se encontro cambios en el stock en el Excel importado."
        End If
    End Function

    Function GetDataFormExcel(fileName As String, workSheetName As String) As DataSet

        Dim connectionString As String = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; data source='{0}'; Extended Properties=""Excel 12.0;HDR=YES;IMEX=1"" ", fileName)

        Dim query As String = String.Format("SELECT * FROM [{0}$] WHERE Codigo <> ''", workSheetName)

        Dim data As DataSet = New DataSet()
        Using con = New OleDbConnection(connectionString)

            con.Open()
            Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(query, con)
            adapter.Fill(data)
        End Using

        Return data
    End Function

    Function verificarColumnasExcelSucursal(datos As DataTable) As Boolean

        'verifico que la cantidad de columnas no halla sido modificada 
        If datos.Columns.Count <> 12 Then
            Return False
        End If

        'verifico que los nombres y orden de las columnas no hallan sido modificadas 
        If datos.Columns(0).ColumnName <> "id_Stock" Or datos.Columns(1).ColumnName <> "id_producto" Or
            datos.Columns(2).ColumnName <> "Codigo" Or datos.Columns(3).ColumnName <> "Nombre" Or
            datos.Columns(4).ColumnName <> "Proveedor" Or datos.Columns(5).ColumnName <> "Categoria" Or
            datos.Columns(6).ColumnName <> "SubCategoria" Or datos.Columns(7).ColumnName <> "StockActual" Or
            datos.Columns(8).ColumnName <> "StockOptimo" Or datos.Columns(9).ColumnName <> "StockMinimo" Or
            datos.Columns(10).ColumnName <> "PlazoEntrega" Or datos.Columns(11).ColumnName <> "VentaMensual" Then
            Return False
        End If
        Return True
    End Function

End Class
