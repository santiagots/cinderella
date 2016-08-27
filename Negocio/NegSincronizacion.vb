Imports Entidades
Imports System.Data.SqlClient
Imports Datos
Public Class NegSincronizacion
    Dim objUsuario As Entidades.Usuario
    Dim clsDatos As New Datos.Conexion
    Dim con As New Conexion
    Dim negFunciones As New Negocio.Funciones
    Private CadenaConexion As String
    Dim miconexion As SqlConnection
    Dim miconexionRemoto As SqlConnection
    Dim encripta As New ClsEncriptacion


    Public Function ProbarConectarLocal()
        Dim estado As Boolean
        estado = False
        Try
            CadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.Conexion").ToString
            miconexion = New SqlConnection
            miconexion.ConnectionString = CadenaConexion
            miconexion.Open()
            estado = True
            miconexion.Dispose()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error conectando con la base de datos local." & ex.Message)
        End Try
        Return estado
    End Function

    Public Function ProbarConectarRemoto()
        Dim estado As Boolean
        estado = False
        Try
            CadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.ConexionRemoto").ToString
            miconexionRemoto = New SqlConnection
            miconexionRemoto.ConnectionString = encripta.DesencriptarMD5(CadenaConexion)
            miconexionRemoto.Open()
            estado = True
            miconexionRemoto.Dispose()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error conectando con la base de datos remota." & ex.Message)
        End Try
        Return estado
    End Function

    Public Function Sincronizar(ByVal Tabla As String) As Integer
        Dim estado As Integer = 0

        Try
            'conexion remota
            CadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.ConexionRemoto").ToString
            miconexionRemoto = New SqlConnection
            miconexionRemoto.ConnectionString = encripta.DesencriptarMD5(CadenaConexion)
            miconexionRemoto.Open()

            'conexion local
            CadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.Conexion").ToString
            miconexion = New SqlConnection
            miconexion.ConnectionString = CadenaConexion
            miconexion.Open()

            Dim transaccion As SqlTransaction
            transaccion = miconexion.BeginTransaction()

            ' obtengo los datos a copiar.
            Dim commandSourceData As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM " + Tabla, miconexionRemoto)
            Dim ds As DataSet = New DataSet()
            commandSourceData.Fill(ds)

            If (ds.Tables(0).Rows.Count > 0) Then
                'elimino los datos locales: "la gente esta muy loca jonhy"
                Dim commandEliminoData As SqlCommand = New SqlCommand("DELETE  FROM " + Tabla, miconexion, transaccion)
                commandEliminoData.ExecuteNonQuery()

                'copio los datos a base local
                Dim BulkCopy As New SqlBulkCopy(miconexion, SqlBulkCopyOptions.KeepIdentity, transaccion)
                BulkCopy.DestinationTableName = Tabla

                Try
                    BulkCopy.WriteToServer(ds.Tables(0))
                    transaccion.Commit()
                    BulkCopy.Close()
                    estado = 1
                Catch ex As Exception
                    transaccion.Rollback()
                    BulkCopy.Close()
                End Try
            Else
                estado = 2
                ' reader.Close()
            End If

        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Se produjo un error sincronizando los datos de " & Tabla & ": " & ex.Message, "Actualizacion fallida")
            miconexion.Dispose()
            miconexionRemoto.Dispose()

        Finally
            miconexion.Dispose()
            miconexionRemoto.Dispose()
        End Try

        Return estado
    End Function

    Public Sub DeshabilitarConstraint()
        Dim cmd As New SqlCommand
        cmd.Connection = clsDatos.ConectarLocal()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "EXEC sp_MSforeachtable @command1=""ALTER TABLE ? NOCHECK CONSTRAINT ALL"""
        cmd.ExecuteNonQuery()
        clsDatos.DesconectarLocal()
    End Sub

    Public Sub HabilitarConstraint()
        Dim cmd As New SqlCommand
        cmd.Connection = clsDatos.ConectarLocal()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "EXEC sp_MSforeachtable @command1=""ALTER TABLE ? CHECK CONSTRAINT ALL"""
        cmd.ExecuteNonQuery()
        clsDatos.DesconectarLocal()
    End Sub

    Public Sub RegistrarVentasARemota(ByVal idSucursal As Integer)

        Using conn As SqlConnection = clsDatos.ConectarRemoto()
            Using tran As SqlTransaction = conn.BeginTransaction()
                Try
                    'recupero todas las ventas locales de la sucursal
                    Dim ventasLocales As DataTable = ObtenerVentasLocal(idSucursal)
                    'recupero todas las ventas remotas de la sucursal
                    Dim ventasRemotas As DataTable = ObtenerVentasRemota(idSucursal)
                    'obtengo todas las ventas que solamente se encuentran de forma local
                    Dim ventasSoloLocales As DataRow() = ventasLocales.Rows.Cast(Of DataRow).Where(Function(x) Not ventasRemotas.Rows.Cast(Of DataRow).Any(Function(y) x.Item("id_Venta") = y.Item("id_Venta"))).ToArray()

                    Dim cmd As SqlCommand = New SqlCommand()
                    cmd.Connection = conn
                    cmd.Transaction = tran

                    For Each ventaLocal In ventasSoloLocales
                        'inserto la venta local en la base remota
                        Dim idVentaremota As Integer = InsertaVentaRemota(ventaLocal, cmd)

                        'Obtengo el detalle de las ventas que estan solo local
                        Dim detalleVentasLocales As DataTable = ObtenerDetalleVentasLocal(ventaLocal.Item("id_Venta"))

                        'inserto el detalle de las ventas local en la base remota
                        For Each detalleVentasLocal In detalleVentasLocales.Rows.Cast(Of DataRow)
                            detalleVentasLocal("id_venta") = idVentaremota
                            InsertaDetalleVentasRemota(detalleVentasLocal, cmd)
                            ActualizarStock(idSucursal, detalleVentasLocal("id_Producto"), detalleVentasLocal("Cantidad") * -1, cmd)
                        Next

                        'Obtengo las comisiones de las ventas que estan solo local
                        Dim comisionesLocales As DataTable = ObtenerComisionesLocal(ventaLocal.Item("id_Venta"))

                        'inserto las comisiones local en al en la base remota
                        For Each comisionesLocal In comisionesLocales.Rows.Cast(Of DataRow)
                            comisionesLocal("id_venta") = idVentaremota
                            InsertaComisionesRemota(comisionesLocal, cmd)
                        Next

                        If (ventaLocal("Facturado") = 1) Then
                            'Obtengo las facturas de las ventas que estan solo local
                            Dim facturasLocales As DataTable = ObtenerFacturaLocal(ventaLocal.Item("id_Venta"))

                            'inserto las facturas local en al en la base remota
                            For Each facturaLocal In facturasLocales.Rows.Cast(Of DataRow)
                                facturaLocal("id_venta") = idVentaremota
                                InsertaFacturaRemota(facturaLocal, cmd)
                            Next
                        End If
                    Next

                    tran.Commit()
                Catch ex As Exception
                    tran.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Sub


    Public Sub RegistrarDevolucionesARemota(ByVal idSucursal As Integer)

        Using conn As SqlConnection = clsDatos.ConectarRemoto()
            Using tran As SqlTransaction = conn.BeginTransaction()
                Try
                    'recupero todas las ventas locales de la sucursal
                    Dim devolucionLocales As DataTable = ObtenerDevolucionesLocal(idSucursal)
                    'recupero todas las ventas remotas de la sucursal
                    Dim devolucionRemotas As DataTable = ObtenerDevolucionesRemota(idSucursal)
                    'obtengo todas las ventas que solamente se encuentran de forma local
                    Dim devolucionSoloLocales As DataRow() = devolucionLocales.Rows.Cast(Of DataRow).Where(Function(x) Not devolucionRemotas.Rows.Cast(Of DataRow).Any(Function(y) x.Item("id_Devolucion") = y.Item("id_Devolucion"))).ToArray()

                    Dim cmd As SqlCommand = New SqlCommand()
                    cmd.Connection = conn
                    cmd.Transaction = tran

                    For Each devolucionLocal In devolucionSoloLocales
                        'inserto la venta local en la base remota
                        Dim idDevolucionRemota As Integer = InsertaDevolucionRemota(devolucionLocal, cmd)

                        'Obtengo el detalle de las ventas que estan solo local
                        Dim detalleDevolucionesLocales As DataTable = ObtenerDetalleDevolucionesLocal(devolucionLocal.Item("id_Devolucion"))

                        'inserto el detalle de las ventas local en la base remota
                        For Each detalleDevolucionLocal In detalleDevolucionesLocales.Rows.Cast(Of DataRow)
                            detalleDevolucionLocal("id_Devolucion") = idDevolucionRemota
                            InsertaDetalleDevolucionesRemota(detalleDevolucionLocal, cmd)
                            ActualizarStock(idSucursal, detalleDevolucionLocal("id_Producto"), detalleDevolucionLocal("Cantidad"), cmd)
                        Next

                        If (devolucionLocal("NotaCredito") = 1) Then
                            'Obtengo las facturas de las ventas que estan solo local
                            Dim notaCreditoLocales As DataTable = ObtenerNotaCreditoLocal(devolucionLocal.Item("id_Devolucion"))

                            'inserto las facturas local en al en la base remota
                            For Each notaCreditoLocal In notaCreditoLocales.Rows.Cast(Of DataRow)
                                notaCreditoLocal("id_Devolucion") = idDevolucionRemota
                                InsertaNotaCreditoRemota(notaCreditoLocal, cmd)
                            Next
                        End If
                    Next

                    tran.Commit()
                Catch ex As Exception
                    tran.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Sub

    Public Sub RegistrarChequesARemota(ByVal idSucursal As Integer)

        Using conn As SqlConnection = clsDatos.ConectarRemoto()
            Using tran As SqlTransaction = conn.BeginTransaction()
                Try
                    Dim chequesLocales As DataTable = ObtenerChequesLocal(idSucursal)
                    Dim chequesRemotas As DataTable = ObtenerChequesRemota(idSucursal)

                    Dim chequesSoloLocales As DataRow() = chequesLocales.Rows.Cast(Of DataRow).Where(Function(x) Not chequesRemotas.Rows.Cast(Of DataRow).Any(Function(y) x.Item("id_Cheque") = y.Item("id_Cheque"))).ToArray()

                    Dim cmd As SqlCommand = New SqlCommand()
                    cmd.Connection = conn
                    cmd.Transaction = tran

                    For Each chequesLocale In chequesSoloLocales
                        'inserto la venta local en la base remota
                        InsertaChequesRemota(chequesLocale, cmd)
                    Next
                    tran.Commit()
                Catch ex As Exception
                    tran.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Sub

    Private Function ObtenerVentasLocal(ByVal IdSucursal As Integer) As DataTable
        Return CType(clsDatos.ConsultarBaseLocal(String.Format("select * from ventas where id_Sucursal = {0}", IdSucursal)), DataSet).Tables(0)
    End Function

    Private Function ObtenerDevolucionesLocal(ByVal IdSucursal As Integer) As DataTable
        Return CType(clsDatos.ConsultarBaseLocal(String.Format("select * from devoluciones where id_Sucursal = {0}", IdSucursal)), DataSet).Tables(0)
    End Function

    Private Function InsertaVentaRemota(ByVal venta As DataRow, ByVal cmd As SqlCommand) As Integer
        Dim fecha As String = CType(venta("Fecha"), DateTime).ToString("yyyy-MM-dd HH:mm:ss")
        Dim fechaAnulado As String = If(venta("FechaAnulado") Is DBNull.Value, Nothing, CType(venta("FechaAnulado"), DateTime).ToString("yyyy-MM-dd HH:mm:ss"))
        Dim subTotal As String = CType(venta("Subtotal"), Double).ToString(System.Globalization.CultureInfo.InvariantCulture)
        Dim precioTotal As String = CType(venta("Precio_Total"), Double).ToString(System.Globalization.CultureInfo.InvariantCulture)
        Dim descuento As String = CType(venta("Descuento"), Double).ToString(System.Globalization.CultureInfo.InvariantCulture)
        Dim diferenciaPagoCheque As String = CType(venta("Diferencia_Pago_Cheque"), Double).ToString(System.Globalization.CultureInfo.InvariantCulture)

        Dim insert As String = String.Format("INSERT INTO [dbo].[VENTAS] ([id_Sucursal] ,[id_TipoPago] ,[id_Encargado] ,[id_Empleado] ,[id_TipoVenta] ,[id_Cliente] ,[Cantidad_Total] ,[Subtotal] ,[Precio_Total] ,[Descuento] ,[Fecha] ,[Habilitado] ,[Anulado] ,[Facturado] ,[DescripcionAnulado] ,[FechaAnulado] ,[Diferencia_Pago_Cheque] ,[Numero]) VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},'{10}',{11},{12},{13},'{14}','{15}',{16},'{17}')", venta("id_Sucursal"), venta("id_TipoPago"), venta("id_Encargado"), venta("id_Empleado"), venta("id_TipoVenta"), venta("id_Cliente"), venta("Cantidad_Total"), subTotal, precioTotal, descuento, fecha, venta("Habilitado"), venta("Anulado"), venta("Facturado"), venta("DescripcionAnulado"), venta("FechaAnulado"), diferenciaPagoCheque, venta("Numero"))

        cmd.CommandText = insert
        cmd.ExecuteNonQuery()

        Dim ds As DataSet = clsDatos.ConsultarBaseRemoto("Select IDENT_CURRENT('VENTAS') as id_Venta")

        If ds.Tables(0).Rows.Count = 1 And CInt(ds.Tables(0).Rows(0).Item("id_Venta")) > 0 Then
            Return ds.Tables(0).Rows(0).Item("id_Venta").ToString
        Else
            Return 1
        End If
    End Function

    Private Function InsertaDevolucionRemota(ByVal devolucion As DataRow, ByVal cmd As SqlCommand) As Integer
        Dim fecha As String = CType(devolucion("Fecha"), DateTime).ToString("yyyy-MM-dd HH:mm:ss")
        Dim fechaAnulado As String = If(devolucion("FechaAnulado") Is DBNull.Value, Nothing, CType(devolucion("FechaAnulado"), DateTime).ToString("yyyy-MM-dd HH:mm:ss"))
        Dim subTotal As String = CType(devolucion("Subtotal"), Double).ToString(System.Globalization.CultureInfo.InvariantCulture)
        Dim precioTotal As String = CType(devolucion("Precio_Total"), Double).ToString(System.Globalization.CultureInfo.InvariantCulture)
        Dim descuento As String = CType(devolucion("Descuento"), Double).ToString(System.Globalization.CultureInfo.InvariantCulture)

        Dim insert As String = String.Format("INSERT INTO [dbo].[DEVOLUCIONES]([id_Sucursal],[id_TipoPago],[id_Encargado],[id_Empleado],[id_TipoDevolucion],[id_Cliente],[Cantidad_Total],[Subtotal],[Precio_Total],[Descuento],[Fecha],[Habilitado],[NotaCredito],[Anulado],[FechaAnulado],[DescripcionAnulado])VALUES({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},'{10}',{11},{12},{13},'{14}','{15}')", devolucion("id_Sucursal"), devolucion("id_TipoPago"), devolucion("id_Encargado"), devolucion("id_Empleado"), devolucion("id_TipoDevolucion"), devolucion("id_Cliente"), devolucion("Cantidad_Total"), subTotal, precioTotal, descuento, fecha, devolucion("Habilitado"), devolucion("NotaCredito"), devolucion("Anulado"), fechaAnulado, devolucion("DescripcionAnulado"))

        cmd.CommandText = insert
        cmd.ExecuteNonQuery()

        Dim ds As DataSet = clsDatos.ConsultarBaseRemoto("Select IDENT_CURRENT('DEVOLUCIONES') as id_Devolucion")

        If ds.Tables(0).Rows.Count = 1 And CInt(ds.Tables(0).Rows(0).Item("id_Devolucion")) > 0 Then
            Return ds.Tables(0).Rows(0).Item("id_Devolucion").ToString
        Else
            Return 1
        End If
    End Function

    Private Function ObtenerVentasRemota(ByVal IdSucursal As Integer) As DataTable
        Return CType(clsDatos.ConsultarBaseRemoto(String.Format("select * from ventas where id_Sucursal = {0}", IdSucursal)), DataSet).Tables(0)
    End Function

    Private Function ObtenerDevolucionesRemota(ByVal IdSucursal As Integer) As DataTable
        Return CType(clsDatos.ConsultarBaseRemoto(String.Format("select * from devoluciones where id_Sucursal = {0}", IdSucursal)), DataSet).Tables(0)
    End Function

    Private Function ObtenerDetalleDevolucionesLocal(ByVal idDevolucion As Integer) As DataTable
        Return CType(clsDatos.ConsultarBaseLocal(String.Format("select * from devoluciones_detalle where id_Devolucion = {0}", idDevolucion)), DataSet).Tables(0)
    End Function

    Private Function ObtenerDetalleVentasLocal(ByVal idVentas As Integer) As DataTable
        Return CType(clsDatos.ConsultarBaseLocal(String.Format("select * from ventas_detalle where id_Venta = {0}", idVentas)), DataSet).Tables(0)
    End Function

    Private Sub InsertaDetalleVentasRemota(ByVal detalleVenta As DataRow, ByVal cmd As SqlCommand)

        Dim precio As String = CType(detalleVenta("Precio"), Double).ToString(System.Globalization.CultureInfo.InvariantCulture)

        Dim insert As String = String.Format("INSERT INTO [dbo].[VENTAS_DETALLE] ([id_Venta] ,[id_Producto] ,[Cantidad] ,[Precio]) VALUES ({0} ,{1} ,{2} ,{3})", detalleVenta("id_Venta"), detalleVenta("id_Producto"), detalleVenta("Cantidad"), precio)

        cmd.CommandText = insert
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub InsertaDetalleDevolucionesRemota(ByVal detalleDevolucion As DataRow, ByVal cmd As SqlCommand)

        Dim precio As String = CType(detalleDevolucion("Precio"), Double).ToString(System.Globalization.CultureInfo.InvariantCulture)

        Dim insert As String = String.Format("INSERT INTO [dbo].[DEVOLUCIONES_DETALLE] ([id_Devolucion] ,[id_Producto] ,[Cantidad] ,[Precio]) VALUES ({0} ,{1} ,{2} ,{3})", detalleDevolucion("id_Devolucion"), detalleDevolucion("id_Producto"), detalleDevolucion("Cantidad"), precio)

        cmd.CommandText = insert
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub ActualizarStock(ByVal idSucursal As Integer, ByVal idProducto As Integer, ByVal cantidad As Integer, ByVal cmd As SqlCommand)

        Dim insert As String = String.Format("UPDATE [dbo].[STOCK] SET [Stock_Actual] = [Stock_Actual] + ({0}) where [id_Sucursal] = {1} and [id_Producto] = {2}", cantidad, idSucursal, idProducto)

        cmd.CommandText = insert
        cmd.ExecuteNonQuery()
    End Sub

    Private Function ObtenerComisionesLocal(ByVal idVentas As Integer) As DataTable
        Return CType(clsDatos.ConsultarBaseLocal(String.Format("select * from comisiones where id_Venta  = {0}", idVentas)), DataSet).Tables(0)
    End Function

    Private Sub InsertaComisionesRemota(ByVal comision As DataRow, ByVal cmd As SqlCommand)

        Dim fecha As String = CType(comision("Fecha"), DateTime).ToString("yyyy-MM-dd HH:mm:ss")
        Dim comisionMonto As String = CType(comision("Comision"), Double).ToString(System.Globalization.CultureInfo.InvariantCulture)
        Dim monto As String = CType(comision("Monto"), Double).ToString(System.Globalization.CultureInfo.InvariantCulture)

        Dim insert As String = String.Format("INSERT INTO [dbo].[COMISIONES] ([id_Empleado] ,[id_Venta] ,[id_Sucursal] ,[Comision] ,[Monto] ,[Fecha]) VALUES ({0},{1},{2},{3},{4},'{5}')", comision("id_Empleado"), comision("id_Venta"), comision("id_Sucursal"), comisionMonto, monto, fecha)

        cmd.CommandText = insert
        cmd.ExecuteNonQuery()
    End Sub

    Private Function ObtenerChequesLocal(ByVal IdSucursal As Integer) As DataTable
        Return CType(clsDatos.ConsultarBaseLocal(String.Format("select * from cheque where SucursalId = {0}", IdSucursal)), DataSet).Tables(0)
    End Function

    Private Function ObtenerChequesRemota(ByVal IdSucursal As Integer) As DataTable
        Return CType(clsDatos.ConsultarBaseRemoto(String.Format("select * from cheque where SucursalId = {0}", IdSucursal)), DataSet).Tables(0)
    End Function

    Private Sub InsertaChequesRemota(ByVal cheques As DataRow, ByVal cmd As SqlCommand)

        Dim fechaIngreso As String = If(cheques("FechaIngreso") Is DBNull.Value, Nothing, CType(cheques("FechaIngreso"), DateTime).ToString("yyyy-MM-dd HH:mm:ss"))
        Dim fechaDesposito As String = If(cheques("FechaDesposito") Is DBNull.Value, Nothing, CType(cheques("FechaDesposito"), DateTime).ToString("yyyy-MM-dd HH:mm:ss"))
        Dim fechaVencimiento As String = If(cheques("FechaVencimiento") Is DBNull.Value, Nothing, CType(cheques("FechaVencimiento"), DateTime).ToString("yyyy-MM-dd HH:mm:ss"))
        Dim fechaSalida As String = If(cheques("FechaSalida") Is DBNull.Value, Nothing, CType(cheques("FechaSalida"), DateTime).ToString("yyyy-MM-dd HH:mm:ss"))
        Dim importe As String = CType(cheques("Importe"), Double).ToString(System.Globalization.CultureInfo.InvariantCulture)
        Dim marcaFacturado As Integer = If(CType(cheques("MarcaFacturado"), Boolean), 1, 0)

        Dim insert As String = String.Format("INSERT INTO [dbo].[CHEQUE]([SucursalId],[NumeroOrden],[NumeroCheque],[MarcaFacturado],[Importe],[BancoEmisorId],[ClienteId],[ClienteNombre],[LibradorId],[LibradorNombre],[FechaIngreso],[FechaDesposito],[FechaVencimiento],[FechaSalida],[DetalleSalida],[Estado],[DestinoSalida])     VALUES({0},{1},{2},{3},{4},{5},{6},'{7}',{8},'{9}','{10}','{11}','{12}','{13}','{14}',{15},{16})", cheques("SucursalId"), cheques("NumeroOrden"), cheques("NumeroCheque"), marcaFacturado, importe, cheques("BancoEmisorId"), cheques("ClienteId"), cheques("ClienteNombre"), cheques("LibradorId"), cheques("LibradorNombre"), fechaIngreso, fechaDesposito, fechaVencimiento, fechaSalida, cheques("DetalleSalida"), cheques("Estado"), cheques("DestinoSalida"))

        cmd.CommandText = insert
        cmd.ExecuteNonQuery()
    End Sub

    Private Function ObtenerFacturaLocal(ByVal idVenta As Integer) As DataTable
        Return CType(clsDatos.ConsultarBaseLocal(String.Format("select * from facturacion where id_Venta = {0}", idVenta)), DataSet).Tables(0)
    End Function

    Private Function ObtenerNotaCreditoLocal(ByVal idDevolucion As Integer) As DataTable
        Return CType(clsDatos.ConsultarBaseLocal(String.Format("select * from notacredito where id_Devolucion = {0}", idDevolucion)), DataSet).Tables(0)
    End Function

    Private Sub InsertaFacturaRemota(ByVal factura As DataRow, ByVal cmd As SqlCommand)

        Dim fecha As String = CType(factura("Fecha"), DateTime).ToString("yyyy-MM-dd HH:mm:ss")
        Dim monto As String = CType(factura("Monto"), Double).ToString(System.Globalization.CultureInfo.InvariantCulture)

        Dim insert As String = String.Format("INSERT INTO [dbo].[FACTURACION]([id_Venta],[NumeroFactura],[Monto],[Fecha],[Nombre],[Cuit],[Direccion],[Localidad],[TipoFactura],[TipoRecibo],[PuntoVenta],[Id_Sucursal])VALUES({0},{1},{2},'{3}','{4}','{5}','{6}','{7}','{8}',{9},{10},{11})", factura("id_Venta"), factura("NumeroFactura"), monto, fecha, factura("Nombre"), factura("Cuit"), factura("Direccion"), factura("Localidad"), factura("TipoFactura"), factura("TipoRecibo"), factura("PuntoVenta"), factura("Id_Sucursal"))

        cmd.CommandText = insert
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub InsertaNotaCreditoRemota(ByVal factura As DataRow, ByVal cmd As SqlCommand)

        Dim fecha As String = CType(factura("Fecha"), DateTime).ToString("yyyy-MM-dd HH:mm:ss")
        Dim monto As String = CType(factura("Monto"), Double).ToString(System.Globalization.CultureInfo.InvariantCulture)

        Dim insert As String = String.Format("INSERT INTO [dbo].[NOTACREDITO]([id_Devolucion],[NumeroNotaCredito],[Monto],[Fecha],[Nombre],[Cuit],[Direccion],[Localidad],[TipoFactura],[TipoRecibo],[PuntoVenta],[Id_Sucursal])VALUES({0},{1},{2},'{3}','{4}','{5}','{6}','{7}','{8}',{9},{10},{11})", factura("id_Devolucion"), factura("NumeroNotaCredito"), monto, fecha, factura("Nombre"), factura("Cuit"), factura("Direccion"), factura("Localidad"), factura("TipoFactura"), factura("TipoRecibo"), factura("PuntoVenta"), factura("Id_Sucursal"))

        cmd.CommandText = insert
        cmd.ExecuteNonQuery()
    End Sub
End Class
