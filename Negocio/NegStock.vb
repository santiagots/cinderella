Imports Entidades
Imports System.Data.SqlClient
Imports Datos

Public Class NegStock
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones


    'Funcion para listar todos los productos.
    Function ListadoStockSucursal(ByVal id_Sucursal As Integer) As DataSet
        If Funciones.HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Stock_ListadoSucursal @id_Sucursal=" & id_Sucursal)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Stock_ListadoSucursal @id_Sucursal=" & id_Sucursal)
        End If
    End Function

    'Funcion que me trae el id del ultimo producto.
    Function UltimoStock() As Integer
        Dim ds As DataSet
        If (Funciones.HayInternet) Then
            ds = clsDatos.ConsultarBaseRemoto("Select IDENT_CURRENT('STOCK') as id_Stock")
        Else
            ds = clsDatos.ConsultarBaseLocal("Select IDENT_CURRENT('STOCK')  as id_Stock")
        End If

        If ds.Tables(0).Rows.Count = 1 And CInt(ds.Tables(0).Rows(0).Item("id_Stock")) > 0 Then
            Return ds.Tables(0).Rows(0).Item("id_Stock").ToString
        Else
            Return 1
        End If
    End Function

    'Funcion para consultar un stock determinado.
    Public Function TraerStock(ByVal id_Stock As Integer)
        Dim dsStock As New DataSet
        Dim entStock As New Entidades.Stock

        If Funciones.HayInternet Then
            dsStock = clsDatos.ConsultarBaseRemoto("execute sp_Stock_Detalle @id_Stock=" & id_Stock)
        Else
            dsStock = clsDatos.ConsultarBaseLocal("execute sp_Stock_Detalle @id_Stock=" & id_Stock)
        End If

        If dsStock.Tables(0).Rows.Count <> 0 Then
            entStock.id_Stock = dsStock.Tables(0).Rows(0).Item("id_Stock").ToString
            entStock.id_Producto = dsStock.Tables(0).Rows(0).Item("id_Producto").ToString
            entStock.id_Sucursal = dsStock.Tables(0).Rows(0).Item("id_Sucursal").ToString
            entStock.Stock_Actual = dsStock.Tables(0).Rows(0).Item("Stock_Actual").ToString
            entStock.Stock_Minimo = dsStock.Tables(0).Rows(0).Item("Stock_Minimo").ToString
            entStock.Stock_Optimo = dsStock.Tables(0).Rows(0).Item("Stock_Optimo").ToString
            entStock.Habilitado = dsStock.Tables(0).Rows(0).Item("Habilitado").ToString
            entStock.Usuario = dsStock.Tables(0).Rows(0).Item("Usuario").ToString
            entStock.id_Usuario = dsStock.Tables(0).Rows(0).Item("id_Usuario").ToString
            entStock.Motivo = dsStock.Tables(0).Rows(0).Item("Motivo_Mod").ToString
            entStock.Modificado = dsStock.Tables(0).Rows(0).Item("Modificado").ToString
            entStock.Fecha_Mod = dsStock.Tables(0).Rows(0).Item("Fecha_Mod").ToString
            entStock.Fecha = dsStock.Tables(0).Rows(0).Item("Fecha").ToString
        End If
        Return entStock
    End Function

    'Funcion para consultar un stock determinado dependiendo del producto y la sucursal.
    Public Function TraerStockProducto(ByVal id_Producto As Integer, ByVal id_Sucursal As Integer)
        Dim dsStock As New DataSet
        Dim entStock As New Entidades.Stock

        If Funciones.HayInternet Then
            dsStock = clsDatos.ConsultarBaseRemoto("execute sp_Stock_Producto_Detalle @id_Producto=" & id_Producto & ", @id_Sucursal=" & id_Sucursal)
        Else
            dsStock = clsDatos.ConsultarBaseLocal("execute sp_Stock_Producto_Detalle @id_Producto=" & id_Producto & ", @id_Sucursal=" & id_Sucursal)
        End If

        If dsStock.Tables(0).Rows.Count <> 0 Then
            entStock.id_Stock = dsStock.Tables(0).Rows(0).Item("id_Stock").ToString
            entStock.id_Producto = dsStock.Tables(0).Rows(0).Item("id_Producto").ToString
            entStock.id_Sucursal = dsStock.Tables(0).Rows(0).Item("id_Sucursal").ToString
            entStock.Stock_Actual = dsStock.Tables(0).Rows(0).Item("Stock_Actual").ToString
            entStock.Stock_Minimo = dsStock.Tables(0).Rows(0).Item("Stock_Minimo").ToString
            entStock.Stock_Optimo = dsStock.Tables(0).Rows(0).Item("Stock_Optimo").ToString
            entStock.Habilitado = dsStock.Tables(0).Rows(0).Item("Habilitado").ToString
            entStock.Fecha = dsStock.Tables(0).Rows(0).Item("Fecha").ToString
        End If
        Return entStock
    End Function

    'Funcion para insertar un stock.
    Function AltaStock(ByVal estock As Entidades.Stock) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim HayInternet As Boolean = Funciones.HayInternet

        Try
            'Conecto la bdd.
            If HayInternet Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            'Ejecuto el Stored.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Stock_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Producto", estock.id_Producto)
                .AddWithValue("@id_Sucursal", estock.id_Sucursal)
                .AddWithValue("@Stock_Minimo", estock.Stock_Minimo)
                .AddWithValue("@Stock_Actual", estock.Stock_Actual)
                .AddWithValue("@Stock_Optimo", estock.Stock_Optimo)
                .AddWithValue("@id_Usuario", estock.id_Usuario)
                .AddWithValue("@Motivo_Mod", estock.Motivo)
                .AddWithValue("@Modificado", estock.Modificado)
                .AddWithValue("@Fecha_Mod", estock.Fecha_Mod)
                .AddWithValue("@Habilitado", estock.Habilitado)
            End With

            'Respuesta del Stored.
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto la bdd.
            If HayInternet Then
                clsDatos.DesconectarRemoto()
            Else
                clsDatos.DesconectarLocal()
            End If

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para modificar un stock.
    Function ModificacionStock(ByVal estock As Entidades.Stock) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim HayInternet As Boolean = Funciones.HayInternet

        Try
            'Conecto la bdd.
            If HayInternet Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

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
                .AddWithValue("@Habilitado", estock.Habilitado)
                .AddWithValue("@id_Usuario", estock.id_Usuario)
                .AddWithValue("@Motivo_Mod", estock.Motivo)
                .AddWithValue("@Modificado", estock.Modificado)
                .AddWithValue("@Fecha_Mod", estock.Fecha_Mod)
            End With

            'Respuesta del Stored.
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto la bdd.
            If HayInternet Then
                clsDatos.DesconectarRemoto()
            Else
                clsDatos.DesconectarLocal()
            End If

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    'Funcion para eliminar un stock.
    Function EliminarStock(ByVal id_Stock As Integer) As String
        Dim cmd As New SqlCommand
        Dim HayInternet As Boolean = Funciones.HayInternet

        Try
            'Conecto la bdd.
            If HayInternet Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            'Ejecuto el Stored.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Stock_Eliminar"
            With cmd.Parameters
                .AddWithValue("@id_Stock", id_Stock)
            End With

            'Respuesta del Stored.
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'Desconecto la bdd.
            If HayInternet Then
                clsDatos.DesconectarRemoto()
            Else
                clsDatos.DesconectarLocal()
            End If

            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    'Funcion que comprueba el stock para una cantidad y producto determinado.
    Function ComprobarStock(ByVal id_Producto As Integer, ByVal Cantidad As Integer, ByVal id_Sucursal As Integer) As Boolean
        Dim dsStock As New DataSet
        If Funciones.HayInternet Then
            dsStock = clsDatos.ConsultarBaseRemoto("execute sp_Stock_Disponibilidad @id_Producto=" & id_Producto & ", @Cantidad=" & Cantidad & ", @id_Sucursal=" & id_Sucursal)
        Else
            dsStock = clsDatos.ConsultarBaseLocal("execute sp_Stock_Disponibilidad @id_Producto=" & id_Producto & ", @Cantidad=" & Cantidad & ", @id_Sucursal=" & id_Sucursal)
        End If

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
        Dim HayInternet As Boolean = Funciones.HayInternet


        Try
            eStock = TraerStockProducto(id_Producto, id_Sucursal)
            'Si no existe el producto en la sucursal
            If eStock.id_Stock <> 0 Then

                'Conecto la bdd
                If HayInternet Then
                    cmd.Connection = clsDatos.ConectarRemoto()
                Else
                    cmd.Connection = clsDatos.ConectarLocal()
                End If

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

                'Desconecto la bdd
                If HayInternet Then
                    clsDatos.DesconectarRemoto()
                Else
                    clsDatos.DesconectarLocal()
                End If
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

    'Update Stock.
    Function AgregarStock(ByVal id_Producto As Integer, ByVal id_Sucursal As Integer, ByVal Stock As Integer)
        Dim eStock As Entidades.Stock
        Dim Estado As Boolean = False
        eStock = TraerStockProducto(id_Producto, id_Sucursal)
        Dim HayInternet As Boolean = Funciones.HayInternet


        'Si no exite el producto en la sucursal
        If eStock.id_Stock <> 0 Then
            Try
                'Declaro variables
                Dim cmd As New SqlCommand
                Dim msg As String = ""
                Dim NuevoStock As Integer = 0
                NuevoStock = eStock.Stock_Actual + Stock

                'Conecto la bdd.
                If HayInternet Then
                    cmd.Connection = clsDatos.ConectarRemoto()
                Else
                    cmd.Connection = clsDatos.ConectarLocal()
                End If

                'Ejecuto el Stored.
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "sp_Stock_Agregar"
                With cmd.Parameters
                    .AddWithValue("@id_Producto", eStock.id_Producto)
                    .AddWithValue("@id_Sucursal", eStock.id_Sucursal)
                    .AddWithValue("@NuevoStock", NuevoStock)
                End With

                'Respuesta del Stored.
                Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                respuesta.Direction = ParameterDirection.Output
                cmd.Parameters.Add(respuesta)
                cmd.ExecuteNonQuery()

                'Desconecto la bdd.
                If HayInternet Then
                    clsDatos.DesconectarRemoto()
                Else
                    clsDatos.DesconectarLocal()
                End If

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

    'Funcion que comprueba si el producto posee mas stock que el minimo permitido.
    Function ComprobarStockMinimo(ByVal id_Producto As Integer, ByVal id_Sucursal As Integer) As Boolean
        Dim dsStock As New DataSet
        If Funciones.HayInternet Then
            dsStock = clsDatos.ConsultarBaseRemoto("execute sp_Stock_DisponibilidadMinima @id_Producto=" & id_Producto & ", @id_Sucursal=" & id_Sucursal)
        Else
            dsStock = clsDatos.ConsultarBaseLocal("execute sp_Stock_DisponibilidadMinima @id_Producto=" & id_Producto & ", @id_Sucursal=" & id_Sucursal)
        End If

        If dsStock.Tables(0).Rows(0).Item("Stock_Actual") >= dsStock.Tables(0).Rows(0).Item("Stock_Minimo") Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
