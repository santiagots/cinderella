Imports Excel = Microsoft.Office.Interop.Excel
Imports Entidades
Imports System.Data.SqlClient
Imports Datos

Public Enum Fortmats
    Texto
    Moneda
    Numerico
End Enum


Public Class NegProductos

    Public Delegate Sub UpdateProgressDelegate(ProgressStep As Integer, ProgressText As String)
    Public Event UpdateProgress As UpdateProgressDelegate

    Dim objProducto As Entidades.Productos
    Dim clsDatos As New Datos.Conexion
    Dim con As New Conexion
    Dim ClsFunciones As New Funciones
    Dim HayInternet As Boolean = ClsFunciones.GotInternet

    Const MaxRowsData As Integer = 100000
    Const MinRowsData As Integer = 2

#Region "Funciones de Seleccion"
    'Funcion para consultar un producto.
    Public Function TraerProducto(ByVal id_Producto As Integer)
        Dim daProducto As New SqlDataAdapter
        Dim dsProducto As New DataSet
        Dim sqlcomando As New SqlCommand
        Dim entProducto As New Entidades.Productos
        Dim internet = False

        sqlcomando.CommandText = ("select * from PRODUCTOS where id_Producto ='" & id_Producto & "'")

        If (HayInternet) Then
            sqlcomando.Connection = con.ConectarRemoto
        Else
            sqlcomando.Connection = con.ConectarLocal
        End If

        daProducto = New SqlDataAdapter(sqlcomando)
        daProducto.Fill(dsProducto)

        If dsProducto.Tables(0).Rows.Count <> 0 Then
            entProducto.id_Producto = dsProducto.Tables(0).Rows(0).Item("id_Producto").ToString
            entProducto.id_Categoria = dsProducto.Tables(0).Rows(0).Item("id_Categoria").ToString
            entProducto.id_Subcategoria = dsProducto.Tables(0).Rows(0).Item("id_Subcategoria").ToString
            entProducto.id_Proveedor = dsProducto.Tables(0).Rows(0).Item("id_Proveedor").ToString
            entProducto.Nombre = dsProducto.Tables(0).Rows(0).Item("Nombre").ToString
            entProducto.Origen = dsProducto.Tables(0).Rows(0).Item("Origen").ToString
            entProducto.Costo = dsProducto.Tables(0).Rows(0).Item("Costo").ToString
            entProducto.Descripcion = dsProducto.Tables(0).Rows(0).Item("Descripcion").ToString
            entProducto.Tamano = dsProducto.Tables(0).Rows(0).Item("Tamano").ToString
            entProducto.Codigo = dsProducto.Tables(0).Rows(0).Item("Codigo").ToString
            entProducto.CodigoBarra = dsProducto.Tables(0).Rows(0).Item("CodigoBarra").ToString
            entProducto.Foto = dsProducto.Tables(0).Rows(0).Item("Foto").ToString
            entProducto.Habilitado = dsProducto.Tables(0).Rows(0).Item("Habilitado").ToString
            entProducto.Novedad = dsProducto.Tables(0).Rows(0).Item("Novedad").ToString
            entProducto.SubirWeb = dsProducto.Tables(0).Rows(0).Item("SubirWeb").ToString
        End If

        If (HayInternet) Then
            con.DesconectarRemoto()
        Else
            con.DesconectarLocal()
        End If

        If (HayInternet) Then
            dsProducto = clsDatos.ConsultarBaseRemoto("execute sp_ProductosPrecios_Listado @id_Producto = " & entProducto.id_Producto)
        Else
            dsProducto = clsDatos.ConsultarBaseLocal("execute sp_ProductosPrecios_Listado @id_Producto = " & entProducto.id_Producto)
        End If

        If dsProducto.Tables(0).Rows.Count <> 0 Then
            For Each dsProd In dsProducto.Tables(0).Rows
                If dsProd.item("id_Lista").ToString() = 1 Then
                    entProducto.Precio1 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 2 Then
                    entProducto.Precio2 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 3 Then
                    entProducto.Precio3 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 4 Then
                    entProducto.Precio4 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 5 Then
                    entProducto.Precio5 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 6 Then
                    entProducto.Precio6 = dsProd.item("Precio").ToString()
                End If
            Next
        End If

        Return entProducto

    End Function

    'Funcion para consultar un producto.
    Public Function TraerProductoPorCodigo(ByVal Codigo As String)
        Dim daProducto As New SqlDataAdapter
        Dim dsProducto As New DataSet
        Dim sqlcomando As New SqlCommand
        Dim entProducto As New Entidades.Productos
        Dim internet = False

        sqlcomando.CommandText = ("select * from PRODUCTOS where (Codigo ='" & Codigo & "')")

        If (HayInternet) Then
            sqlcomando.Connection = con.ConectarRemoto
        Else
            sqlcomando.Connection = con.ConectarLocal
        End If

        daProducto = New SqlDataAdapter(sqlcomando)
        daProducto.Fill(dsProducto)

        If dsProducto.Tables(0).Rows.Count <> 0 Then
            entProducto.id_Producto = dsProducto.Tables(0).Rows(0).Item("id_Producto").ToString
            entProducto.id_Categoria = dsProducto.Tables(0).Rows(0).Item("id_Categoria").ToString
            entProducto.id_Subcategoria = dsProducto.Tables(0).Rows(0).Item("id_Subcategoria").ToString
            entProducto.id_Proveedor = dsProducto.Tables(0).Rows(0).Item("id_Proveedor").ToString
            entProducto.Nombre = dsProducto.Tables(0).Rows(0).Item("Nombre").ToString
            entProducto.Origen = dsProducto.Tables(0).Rows(0).Item("Origen").ToString
            entProducto.Costo = dsProducto.Tables(0).Rows(0).Item("Costo").ToString
            entProducto.Descripcion = dsProducto.Tables(0).Rows(0).Item("Descripcion").ToString
            entProducto.Tamano = dsProducto.Tables(0).Rows(0).Item("Tamano").ToString
            entProducto.Codigo = dsProducto.Tables(0).Rows(0).Item("Codigo").ToString
            entProducto.CodigoBarra = dsProducto.Tables(0).Rows(0).Item("CodigoBarra").ToString
            entProducto.Foto = dsProducto.Tables(0).Rows(0).Item("Foto").ToString
            entProducto.Habilitado = dsProducto.Tables(0).Rows(0).Item("Habilitado").ToString
            entProducto.Novedad = dsProducto.Tables(0).Rows(0).Item("Novedad").ToString
            entProducto.SubirWeb = dsProducto.Tables(0).Rows(0).Item("SubirWeb").ToString
        End If

        If (HayInternet) Then
            con.DesconectarRemoto()
        Else
            con.DesconectarLocal()
        End If

        If (HayInternet) Then
            dsProducto = clsDatos.ConsultarBaseRemoto("execute sp_ProductosPrecios_Listado @id_Producto = " & entProducto.id_Producto)
        Else
            dsProducto = clsDatos.ConsultarBaseLocal("execute sp_ProductosPrecios_Listado @id_Producto = " & entProducto.id_Producto)
        End If

        If dsProducto.Tables(0).Rows.Count <> 0 Then
            For Each dsProd In dsProducto.Tables(0).Rows
                If dsProd.item("id_Lista").ToString() = 1 Then
                    entProducto.Precio1 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 2 Then
                    entProducto.Precio2 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 3 Then
                    entProducto.Precio3 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 4 Then
                    entProducto.Precio4 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 5 Then
                    entProducto.Precio5 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 6 Then
                    entProducto.Precio6 = dsProd.item("Precio").ToString()
                End If
            Next
        End If

        Return entProducto

    End Function

    'Funcion para consultar un usuario dependiendo del CodigoBarra.
    Public Function TraerProductoPorCodBarra(ByVal CodigoBarra As String)
        Dim daProducto As New SqlDataAdapter
        Dim dsProducto As New DataSet
        Dim sqlcomando As New SqlCommand
        Dim entProducto As New Entidades.Productos
        sqlcomando.CommandText = ("select * from PRODUCTOS where CodigoBarra ='" & CodigoBarra & "'")

        If (HayInternet) Then
            sqlcomando.Connection = con.ConectarRemoto
        Else
            sqlcomando.Connection = con.ConectarLocal
        End If

        daProducto = New SqlDataAdapter(sqlcomando)
        daProducto.Fill(dsProducto)

        If dsProducto.Tables(0).Rows.Count <> 0 Then
            entProducto.id_Producto = dsProducto.Tables(0).Rows(0).Item("id_Producto").ToString
            entProducto.id_Categoria = dsProducto.Tables(0).Rows(0).Item("id_Categoria").ToString
            entProducto.id_Subcategoria = dsProducto.Tables(0).Rows(0).Item("id_Subcategoria").ToString
            entProducto.id_Proveedor = dsProducto.Tables(0).Rows(0).Item("id_Proveedor").ToString
            entProducto.Nombre = dsProducto.Tables(0).Rows(0).Item("Nombre").ToString
            entProducto.Origen = dsProducto.Tables(0).Rows(0).Item("Origen").ToString
            entProducto.Costo = dsProducto.Tables(0).Rows(0).Item("Costo").ToString
            entProducto.Descripcion = dsProducto.Tables(0).Rows(0).Item("Descripcion").ToString
            entProducto.Tamano = dsProducto.Tables(0).Rows(0).Item("Tamano").ToString
            entProducto.Codigo = dsProducto.Tables(0).Rows(0).Item("Codigo").ToString
            entProducto.CodigoBarra = dsProducto.Tables(0).Rows(0).Item("CodigoBarra").ToString
            entProducto.Foto = dsProducto.Tables(0).Rows(0).Item("Foto").ToString
            entProducto.Habilitado = dsProducto.Tables(0).Rows(0).Item("Habilitado").ToString
            entProducto.Novedad = dsProducto.Tables(0).Rows(0).Item("Novedad").ToString
            entProducto.SubirWeb = dsProducto.Tables(0).Rows(0).Item("SubirWeb").ToString
        End If

        If (HayInternet) Then
            con.DesconectarRemoto()
        Else
            con.DesconectarLocal()
        End If

        If (HayInternet) Then
            dsProducto = clsDatos.ConsultarBaseRemoto("execute sp_ProductosPrecios_Listado @id_Producto = " & entProducto.id_Producto)
        Else
            dsProducto = clsDatos.ConsultarBaseLocal("execute sp_ProductosPrecios_Listado @id_Producto = " & entProducto.id_Producto)
        End If

        If dsProducto.Tables(0).Rows.Count <> 0 Then
            For Each dsProd In dsProducto.Tables(0).Rows
                If dsProd.item("id_Lista").ToString() = 1 Then
                    entProducto.Precio1 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 2 Then
                    entProducto.Precio2 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 3 Then
                    entProducto.Precio3 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 4 Then
                    entProducto.Precio4 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 5 Then
                    entProducto.Precio5 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 6 Then
                    entProducto.Precio6 = dsProd.item("Precio").ToString()
                End If
            Next
        End If
        Return entProducto
    End Function

    'Funcion para consultar un id_Producto dependiendo del Codigo.
    Public Function TraerID(ByVal Codigo As String)
        Dim daProducto As New SqlDataAdapter
        Dim dsProducto As New DataSet
        Dim sqlcomando As New SqlCommand
        sqlcomando.CommandText = ("select id_Producto from PRODUCTOS where Codigo ='" & Codigo & "'")

        If (HayInternet) Then
            sqlcomando.Connection = con.ConectarRemoto
        Else
            sqlcomando.Connection = con.ConectarLocal
        End If

        daProducto = New SqlDataAdapter(sqlcomando)
        daProducto.Fill(dsProducto)

        If (HayInternet) Then
            con.DesconectarRemoto()
        Else
            con.DesconectarLocal()
        End If

        If dsProducto.Tables(0).Rows.Count <> 0 Then
            Return dsProducto.Tables(0).Rows(0).Item("id_Producto").ToString
        Else
            Return 0
        End If
    End Function

    'Funcion para consultar un Codigo dependiendo del id_Producto.
    Public Function TraerCODIGO(ByVal id_Producto As String)
        Dim daProducto As New SqlDataAdapter
        Dim dsProducto As New DataSet
        Dim sqlcomando As New SqlCommand
        sqlcomando.CommandText = ("select Codigo from PRODUCTOS where id_Producto ='" & id_Producto & "'")

        If (HayInternet) Then
            sqlcomando.Connection = con.ConectarRemoto
        Else
            sqlcomando.Connection = con.ConectarLocal
        End If

        daProducto = New SqlDataAdapter(sqlcomando)
        daProducto.Fill(dsProducto)

        If (HayInternet) Then
            con.DesconectarRemoto()
        Else
            con.DesconectarLocal()
        End If

        If dsProducto.Tables(0).Rows.Count <> 0 Then
            Return dsProducto.Tables(0).Rows(0).Item("Codigo").ToString
        Else
            Return 0
        End If
    End Function

    Public Function TraerPrecios(ByVal eproductos As Entidades.Productos)
        Dim dsProducto As New DataSet

        If (HayInternet) Then
            dsProducto = clsDatos.ConsultarBaseRemoto("execute sp_ProductosPrecios_Listado @id_Producto = " & eproductos.id_Producto)
        Else
            dsProducto = clsDatos.ConsultarBaseLocal("execute sp_ProductosPrecios_Listado @id_Producto = " & eproductos.id_Producto)
        End If

        If dsProducto.Tables(0).Rows.Count <> 0 Then
            For Each dsProd In dsProducto.Tables(0).Rows
                If dsProd.item("id_Lista").ToString() = 1 Then
                    eproductos.Precio1 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 2 Then
                    eproductos.Precio2 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 3 Then
                    eproductos.Precio3 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 4 Then
                    eproductos.Precio4 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 5 Then
                    eproductos.Precio5 = dsProd.item("Precio").ToString()
                ElseIf dsProd.item("id_Lista").ToString() = 6 Then
                    eproductos.Precio6 = dsProd.item("Precio").ToString()
                End If
            Next
        End If

        Return eproductos
    End Function

    'Funcion que trae el precio del producto dependiendo del codigo ( barra y producto ) y el precio seteado en el programa 
    Function TraerPrecio(ByVal Codigo As String, ByVal id_Lista As String)
        Dim Precio As String = ""
        Dim dsProducto As New DataSet

        If (HayInternet) Then
            dsProducto = clsDatos.ConsultarBaseRemoto("execute sp_ProductosPrecios_Consultar @Codigo = " & Codigo & ", @id_Lista=" & id_Lista)
        Else
            dsProducto = clsDatos.ConsultarBaseLocal("execute sp_ProductosPrecios_Consultar @Codigo = " & Codigo & ", @id_Lista=" & id_Lista)
        End If

        If dsProducto.Tables(0).Rows.Count <> 0 Then
            Precio = dsProducto.Tables(0).Rows(0).Item(0).ToString
        End If

        Return Precio
    End Function
#End Region

#Region "Funciones ABM"

    'Funcion para insertar un producto.
    Function AltaProducto(ByVal eproductos As Entidades.Productos) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim id_Producto As Integer
        Dim id_Material As Integer
        Dim id_Aroma As Integer
        Dim id_Color As Integer
        Dim nombre_nuevo As String = ""
        If eproductos.Foto <> "" Then
            Dim ext As String = IO.Path.GetExtension(IO.Path.GetFileName(eproductos.Foto))
            nombre_nuevo = eproductos.Codigo & ext
        End If

        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Productos_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Categoria", eproductos.id_Categoria)
                .AddWithValue("@id_Subcategoria", eproductos.id_Subcategoria)
                .AddWithValue("@id_Proveedor", eproductos.id_Proveedor)
                .AddWithValue("@Nombre", eproductos.Nombre)
                .AddWithValue("@Origen", eproductos.Origen)
                .AddWithValue("@Costo", eproductos.Costo)
                .AddWithValue("@Descripcion", eproductos.Descripcion)
                .AddWithValue("@Tamano", eproductos.Tamano)
                .AddWithValue("@Codigo", eproductos.Codigo)
                .AddWithValue("@Foto", nombre_nuevo)
                .AddWithValue("@Habilitado", eproductos.Habilitado)
                .AddWithValue("@Novedad", eproductos.Novedad)
                .AddWithValue("@SubirWeb", eproductos.SubirWeb)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()
            'desconecto la bdd
            clsDatos.DesconectarRemoto()

            'Consulto cual fue el ultimo id ingresado.
            id_Producto = UltimoProducto()

            'Actualizo el codigo de barras
            Dim CodigoBarra As String = ""
            Dim CodigoProducto As String = ""

            If Len(CStr(id_Producto)) < 5 Then

                For i = 1 To 5 - Len(CStr(id_Producto))
                    CodigoProducto &= "0"
                Next
                CodigoProducto = CodigoProducto & id_Producto
            Else
                CodigoProducto = id_Producto
            End If

            CodigoBarra = "7791234" & CodigoProducto

            Dim funcionescodigo As New CodigoBarras.funciones
            Dim DigitoVerificador As Integer
            DigitoVerificador = funcionescodigo.CalcularVerificador(CodigoBarra)

            CodigoBarra = CodigoBarra & DigitoVerificador

            'Actualizo el codigo de barras
            Dim cmd12 As New SqlCommand
            cmd12.Connection = clsDatos.ConectarRemoto()
            cmd12.CommandType = CommandType.StoredProcedure
            cmd12.CommandText = "sp_Productos_ModificacionCodigoBarra"
            With cmd12.Parameters
                .AddWithValue("@id_Producto", id_Producto)
                .AddWithValue("@CodigoBarra", CodigoBarra)
            End With

            Dim respuesta12 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta12.Direction = ParameterDirection.Output
            cmd12.Parameters.Add(respuesta12)
            cmd12.ExecuteNonQuery()
            'desconecto la bdd
            clsDatos.DesconectarRemoto()

            'inserto los materiales para el producto
            For Each iten In eproductos.Materiales.CheckedItems
                'conecto la bdd
                Dim cmd2 As New SqlCommand
                cmd2.Connection = clsDatos.ConectarRemoto()
                id_Material = DirectCast(iten.Row, System.Data.DataRow).ItemArray(0)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.CommandText = "sp_ProductosMateriales_Alta"
                With cmd2.Parameters
                    .AddWithValue("@id_Producto", id_Producto)
                    .AddWithValue("@id_Material", id_Material)
                End With
                Dim respuesta2 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                respuesta2.Direction = ParameterDirection.Output
                cmd2.Parameters.Add(respuesta2)
                cmd2.ExecuteNonQuery()
                'desconecto la bdd
                clsDatos.DesconectarRemoto()
            Next

            'inserto los aromas para el producto
            For Each iten In eproductos.Aromas.CheckedItems
                'conecto la bdd
                Dim cmd2 As New SqlCommand
                cmd2.Connection = clsDatos.ConectarRemoto()
                id_Aroma = DirectCast(iten.Row, System.Data.DataRow).ItemArray(0)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.CommandText = "sp_ProductosAromas_Alta"
                With cmd2.Parameters
                    .AddWithValue("@id_Producto", id_Producto)
                    .AddWithValue("@id_Aroma", id_Aroma)
                End With
                Dim respuesta2 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                respuesta2.Direction = ParameterDirection.Output
                cmd2.Parameters.Add(respuesta2)
                cmd2.ExecuteNonQuery()
                'desconecto la bdd
                clsDatos.DesconectarRemoto()
            Next

            'inserto los colores para el producto
            For Each iten In eproductos.Colores.CheckedItems
                'conecto la bdd
                Dim cmd2 As New SqlCommand
                cmd2.Connection = clsDatos.ConectarRemoto()
                id_Color = DirectCast(iten.Row, System.Data.DataRow).ItemArray(0)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.CommandText = "sp_ProductosColores_Alta"
                With cmd2.Parameters
                    .AddWithValue("@id_Producto", id_Producto)
                    .AddWithValue("@id_Color", id_Color)
                End With
                Dim respuesta2 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                respuesta2.Direction = ParameterDirection.Output
                cmd2.Parameters.Add(respuesta2)
                cmd2.ExecuteNonQuery()
                'desconecto la bdd
                clsDatos.DesconectarRemoto()
            Next

            'inserto los precios
            For i = 1 To 6
                'conecto la bdd
                Dim cmd2 As New SqlCommand
                cmd2.Connection = clsDatos.ConectarRemoto()
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.CommandText = "sp_ProductosPrecios_Alta"
                With cmd2.Parameters
                    .AddWithValue("@id_Producto", id_Producto)
                    .AddWithValue("@id_Lista", i)
                    If i = 1 Then
                        .AddWithValue("@Precio", eproductos.Precio1)
                    ElseIf i = 2 Then
                        .AddWithValue("@Precio", eproductos.Precio2)
                    ElseIf i = 3 Then
                        .AddWithValue("@Precio", eproductos.Precio3)
                    ElseIf i = 4 Then
                        .AddWithValue("@Precio", eproductos.Precio4)
                    ElseIf i = 5 Then
                        .AddWithValue("@Precio", eproductos.Precio5)
                    ElseIf i = 6 Then
                        .AddWithValue("@Precio", eproductos.Precio6)
                    End If
                    .AddWithValue("@Habilitado", "1")
                End With
                Dim respuesta2 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                respuesta2.Direction = ParameterDirection.Output
                cmd2.Parameters.Add(respuesta2)
                cmd2.ExecuteNonQuery()
                'desconecto la bdd
                clsDatos.DesconectarRemoto()
            Next

            'Subo la foto al ftp
            If nombre_nuevo <> "" Then
                Dim ftpclie As New NegConexionFtp("ftp://www.cinderelladecoracion.com/", "admin@cinderelladecoracion.com", "UyGQYiEc")
                ftpclie.subirFichero(eproductos.Foto, "ftp://www.cinderelladecoracion.com/www/software_cinderella/imagenes/" & nombre_nuevo, "ftp://www.cinderelladecoracion.com/")
            End If

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para insertar un producto - en seccion alta masiva de productos.
    Function AltaProductoMasivo(ByVal eproductos As Entidades.Productos) As Integer
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim id_Producto As Integer

        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Productos_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Categoria", eproductos.id_Categoria)
                .AddWithValue("@id_Subcategoria", eproductos.id_Subcategoria)
                .AddWithValue("@id_Proveedor", eproductos.id_Proveedor)
                .AddWithValue("@Nombre", eproductos.Nombre)
                .AddWithValue("@Origen", eproductos.Origen)
                .AddWithValue("@Costo", eproductos.Costo)
                .AddWithValue("@Descripcion", eproductos.Descripcion)
                .AddWithValue("@Tamano", eproductos.Tamano)
                .AddWithValue("@Codigo", eproductos.Codigo)
                .AddWithValue("@Foto", "")
                .AddWithValue("@Habilitado", eproductos.Habilitado)
                .AddWithValue("@Novedad", eproductos.Novedad)
                .AddWithValue("@SubirWeb", eproductos.SubirWeb)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()
            'desconecto la bdd
            clsDatos.DesconectarRemoto()

            'Consulto cual fue el ultimo id ingresado.
            id_Producto = UltimoProducto()

            'Actualizo el codigo de barras
            Dim CodigoBarra As String = ""
            Dim CodigoProducto As String = ""

            If Len(CStr(id_Producto)) < 5 Then

                For i = 1 To 5 - Len(CStr(id_Producto))
                    CodigoProducto &= "0"
                Next
                CodigoProducto = CodigoProducto & id_Producto
            Else
                CodigoProducto = id_Producto
            End If

            CodigoBarra = "7791234" & CodigoProducto

            Dim funcionescodigo As New CodigoBarras.funciones
            Dim DigitoVerificador As Integer
            DigitoVerificador = funcionescodigo.CalcularVerificador(CodigoBarra)

            CodigoBarra = CodigoBarra & DigitoVerificador

            'Actualizo el codigo de barras
            Dim cmd12 As New SqlCommand
            cmd12.Connection = clsDatos.ConectarRemoto()
            cmd12.CommandType = CommandType.StoredProcedure
            cmd12.CommandText = "sp_Productos_ModificacionCodigoBarra"
            With cmd12.Parameters
                .AddWithValue("@id_Producto", id_Producto)
                .AddWithValue("@CodigoBarra", CodigoBarra)
            End With

            Dim respuesta12 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta12.Direction = ParameterDirection.Output
            cmd12.Parameters.Add(respuesta12)
            cmd12.ExecuteNonQuery()
            'desconecto la bdd
            clsDatos.DesconectarRemoto()


            'inserto los materiales para el producto
            If eproductos.id_Material <> 0 Then
                'conecto la bdd
                Dim cmd4 As New SqlCommand
                cmd4.Connection = clsDatos.ConectarRemoto()
                cmd4.CommandType = CommandType.StoredProcedure
                cmd4.CommandText = "sp_ProductosMateriales_Alta"
                With cmd4.Parameters
                    .AddWithValue("@id_Producto", id_Producto)
                    .AddWithValue("@id_Material", eproductos.id_Material)
                End With
                Dim respuesta4 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                respuesta4.Direction = ParameterDirection.Output
                cmd4.Parameters.Add(respuesta4)
                cmd4.ExecuteNonQuery()
                'desconecto la bdd
                clsDatos.DesconectarRemoto()
            End If

            'inserto los aromas para el producto
            If eproductos.id_Aroma <> 0 Then
                'conecto la bdd
                Dim cmd5 As New SqlCommand
                cmd5.Connection = clsDatos.ConectarRemoto()
                cmd5.CommandType = CommandType.StoredProcedure
                cmd5.CommandText = "sp_ProductosAromas_Alta"
                With cmd5.Parameters
                    .AddWithValue("@id_Producto", id_Producto)
                    .AddWithValue("@id_Aroma", eproductos.id_Aroma)
                End With
                Dim respuesta5 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                respuesta5.Direction = ParameterDirection.Output
                cmd5.Parameters.Add(respuesta5)
                cmd5.ExecuteNonQuery()
                'desconecto la bdd
                clsDatos.DesconectarRemoto()
            End If

            'inserto los colores para el producto
            If eproductos.id_Color <> 0 Then
                'conecto la bdd
                Dim cmd6 As New SqlCommand
                cmd6.Connection = clsDatos.ConectarRemoto()
                cmd6.CommandType = CommandType.StoredProcedure
                cmd6.CommandText = "sp_ProductosColores_Alta"
                With cmd6.Parameters
                    .AddWithValue("@id_Producto", id_Producto)
                    .AddWithValue("@id_Color", eproductos.id_Color)
                End With
                Dim respuesta6 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                respuesta6.Direction = ParameterDirection.Output
                cmd6.Parameters.Add(respuesta6)
                cmd6.ExecuteNonQuery()
                'desconecto la bdd
                clsDatos.DesconectarRemoto()
            End If

            'inserto los precios
            For i = 1 To 6
                'conecto la bdd
                Dim cmd2 As New SqlCommand
                cmd2.Connection = clsDatos.ConectarRemoto()
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.CommandText = "sp_ProductosPrecios_Alta"
                With cmd2.Parameters
                    .AddWithValue("@id_Producto", id_Producto)
                    .AddWithValue("@id_Lista", i)
                    If i = 1 Then
                        .AddWithValue("@Precio", eproductos.Precio1)
                    ElseIf i = 2 Then
                        .AddWithValue("@Precio", eproductos.Precio2)
                    ElseIf i = 3 Then
                        .AddWithValue("@Precio", eproductos.Precio3)
                    ElseIf i = 4 Then
                        .AddWithValue("@Precio", eproductos.Precio4)
                    ElseIf i = 5 Then
                        .AddWithValue("@Precio", eproductos.Precio5)
                    ElseIf i = 6 Then
                        .AddWithValue("@Precio", eproductos.Precio6)
                    End If
                    .AddWithValue("@Habilitado", "1")
                End With
                Dim respuesta2 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                respuesta2.Direction = ParameterDirection.Output
                cmd2.Parameters.Add(respuesta2)
                cmd2.ExecuteNonQuery()
                'desconecto la bdd
                clsDatos.DesconectarRemoto()
            Next

            'muestro el mensaje
            Return id_Producto
        Catch ex As Exception
            Return 0
        End Try
    End Function

    'Funcion para modificar un producto.
    Function ModificacionProducto(ByVal eproductos As Entidades.Productos) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""
        Dim id_Material As Integer
        Dim id_Aroma As Integer
        Dim id_Color As Integer
        Dim nombre_nuevo As String = ""

        'Traigo el producto para utilizar su codigo asi se obtiene la foto a eliminar.
        objProducto = TraerProducto(eproductos.id_Producto)

        Try
            If eproductos.Foto <> "" Then
                Dim ext As String = IO.Path.GetExtension(IO.Path.GetFileName(eproductos.Foto))
                nombre_nuevo = eproductos.Codigo & ext

                'Me conecto al ftp
                Dim ftpclie As New NegConexionFtp("ftp://www.cinderelladecoracion.com/", "admin@cinderelladecoracion.com", "UyGQYiEc")

                ftpclie.eliminarFichero("ftp://www.cinderelladecoracion.com/www/software_cinderella/imagenes/" & objProducto.Foto)

                'Subo la foto al ftp
                If nombre_nuevo <> "" Then
                    ftpclie.subirFichero(eproductos.Foto, "ftp://www.cinderelladecoracion.com/www/software_cinderella/imagenes/" & nombre_nuevo, "ftp://www.cinderelladecoracion.com/")
                End If
            Else
                nombre_nuevo = objProducto.Foto
            End If

            'Si se desea eliminar la Foto
            If eproductos.EliminarFoto Then
                Dim ftpclie As New NegConexionFtp("ftp://www.cinderelladecoracion.com/", "admin@cinderelladecoracion.com", "UyGQYiEc")
                ftpclie.eliminarFichero("ftp://www.cinderelladecoracion.com/www/software_cinderella/imagenes/" & objProducto.Foto)
            End If
        Catch ex As Exception

        End Try

        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Productos_Modificacion"
            With cmd.Parameters
                .AddWithValue("@id_Producto", eproductos.id_Producto)
                .AddWithValue("@id_Categoria", eproductos.id_Categoria)
                .AddWithValue("@id_Subcategoria", eproductos.id_Subcategoria)
                .AddWithValue("@id_Proveedor", eproductos.id_Proveedor)
                .AddWithValue("@Nombre", eproductos.Nombre)
                .AddWithValue("@Origen", eproductos.Origen)
                .AddWithValue("@Costo", eproductos.Costo)
                .AddWithValue("@Descripcion", eproductos.Descripcion)
                .AddWithValue("@Tamano", eproductos.Tamano)
                .AddWithValue("@Codigo", eproductos.Codigo)
                .AddWithValue("@Foto", nombre_nuevo)
                .AddWithValue("@Habilitado", eproductos.Habilitado)
                .AddWithValue("@Novedad", eproductos.Novedad)
                .AddWithValue("@SubirWeb", eproductos.SubirWeb)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()
            'desconecto la bdd
            clsDatos.DesconectarRemoto()


            'ELIMINO TODOS LOS MATERIALES DEL PRODUCTO
            'conecto la bdd
            Dim cmd3 As New SqlCommand
            cmd3.Connection = clsDatos.ConectarRemoto()
            cmd3.CommandType = CommandType.StoredProcedure
            cmd3.CommandText = "sp_ProductosMateriales_Eliminar"
            With cmd3.Parameters
                .AddWithValue("@id_Producto", eproductos.id_Producto)
            End With
            Dim respuesta3 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta3.Direction = ParameterDirection.Output
            cmd3.Parameters.Add(respuesta3)
            cmd3.ExecuteNonQuery()
            'desconecto la bdd
            clsDatos.DesconectarRemoto()

            'ELIMINO TODOS LOS AROMAS DEL PRODUCTO
            'conecto la bdd
            Dim cmd4 As New SqlCommand
            cmd4.Connection = clsDatos.ConectarRemoto()
            cmd4.CommandType = CommandType.StoredProcedure
            cmd4.CommandText = "sp_ProductosAromas_Eliminar"
            With cmd4.Parameters
                .AddWithValue("@id_Producto", eproductos.id_Producto)
            End With
            Dim respuesta4 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta4.Direction = ParameterDirection.Output
            cmd4.Parameters.Add(respuesta4)
            cmd4.ExecuteNonQuery()
            'desconecto la bdd
            clsDatos.DesconectarRemoto()

            'ELIMINO TODOS LOS COLORES DEL PRODUCTO
            'conecto la bdd
            Dim cmd5 As New SqlCommand
            cmd5.Connection = clsDatos.ConectarRemoto()
            cmd5.CommandType = CommandType.StoredProcedure
            cmd5.CommandText = "sp_ProductosColores_Eliminar"
            With cmd5.Parameters
                .AddWithValue("@id_Producto", eproductos.id_Producto)
            End With
            Dim respuesta5 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta5.Direction = ParameterDirection.Output
            cmd5.Parameters.Add(respuesta5)
            cmd5.ExecuteNonQuery()
            'desconecto la bdd
            clsDatos.DesconectarRemoto()

            'ELIMINO TODOS LOS PRECIOS DEL PRODUCTO
            'conecto la bdd
            Dim cmd6 As New SqlCommand
            cmd6.Connection = clsDatos.ConectarRemoto()
            cmd6.CommandType = CommandType.StoredProcedure
            cmd6.CommandText = "sp_ProductosPrecios_Eliminar"
            With cmd6.Parameters
                .AddWithValue("@id_Producto", eproductos.id_Producto)
            End With
            Dim respuesta6 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta6.Direction = ParameterDirection.Output
            cmd6.Parameters.Add(respuesta6)
            cmd6.ExecuteNonQuery()
            'desconecto la bdd
            clsDatos.DesconectarRemoto()

            'inserto los materiales para el producto
            For Each iten In eproductos.Materiales.CheckedItems
                'conecto la bdd
                Dim cmd2 As New SqlCommand
                cmd2.Connection = clsDatos.ConectarRemoto()
                id_Material = DirectCast(iten.Row, System.Data.DataRow).ItemArray(0)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.CommandText = "sp_ProductosMateriales_Alta"
                With cmd2.Parameters
                    .AddWithValue("@id_Producto", eproductos.id_Producto)
                    .AddWithValue("@id_Material", id_Material)
                End With
                Dim respuesta2 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                respuesta2.Direction = ParameterDirection.Output
                cmd2.Parameters.Add(respuesta2)
                cmd2.ExecuteNonQuery()
                'desconecto la bdd
                clsDatos.DesconectarRemoto()
            Next

            'inserto los aromas para el producto
            For Each iten In eproductos.Aromas.CheckedItems
                'conecto la bdd
                Dim cmd2 As New SqlCommand
                cmd2.Connection = clsDatos.ConectarRemoto()
                id_Aroma = DirectCast(iten.Row, System.Data.DataRow).ItemArray(0)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.CommandText = "sp_ProductosAromas_Alta"
                With cmd2.Parameters
                    .AddWithValue("@id_Producto", eproductos.id_Producto)
                    .AddWithValue("@id_Aroma", id_Aroma)
                End With
                Dim respuesta2 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                respuesta2.Direction = ParameterDirection.Output
                cmd2.Parameters.Add(respuesta2)
                cmd2.ExecuteNonQuery()
                'desconecto la bdd
                clsDatos.DesconectarRemoto()
            Next

            'inserto los colores para el producto
            For Each iten In eproductos.Colores.CheckedItems
                'conecto la bdd
                Dim cmd2 As New SqlCommand
                cmd2.Connection = clsDatos.ConectarRemoto()
                id_Color = DirectCast(iten.Row, System.Data.DataRow).ItemArray(0)
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.CommandText = "sp_ProductosColores_Alta"
                With cmd2.Parameters
                    .AddWithValue("@id_Producto", eproductos.id_Producto)
                    .AddWithValue("@id_Color", id_Color)
                End With
                Dim respuesta2 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                respuesta2.Direction = ParameterDirection.Output
                cmd2.Parameters.Add(respuesta2)
                cmd2.ExecuteNonQuery()
                'desconecto la bdd
                clsDatos.DesconectarRemoto()
            Next

            'inserto los precios
            For i = 1 To 6
                'conecto la bdd
                Dim cmd2 As New SqlCommand
                cmd2.Connection = clsDatos.ConectarRemoto()
                cmd2.CommandType = CommandType.StoredProcedure
                cmd2.CommandText = "sp_ProductosPrecios_Alta"
                With cmd2.Parameters
                    .AddWithValue("@id_Producto", eproductos.id_Producto)
                    .AddWithValue("@id_Lista", i)
                    If i = 1 Then
                        .AddWithValue("@Precio", eproductos.Precio1)
                    ElseIf i = 2 Then
                        .AddWithValue("@Precio", eproductos.Precio2)
                    ElseIf i = 3 Then
                        .AddWithValue("@Precio", eproductos.Precio3)
                    ElseIf i = 4 Then
                        .AddWithValue("@Precio", eproductos.Precio4)
                    ElseIf i = 5 Then
                        .AddWithValue("@Precio", eproductos.Precio5)
                    ElseIf i = 6 Then
                        .AddWithValue("@Precio", eproductos.Precio6)
                    End If
                    .AddWithValue("@Habilitado", "1")
                End With
                Dim respuesta2 As New SqlParameter("@msg", SqlDbType.VarChar, 255)
                respuesta2.Direction = ParameterDirection.Output
                cmd2.Parameters.Add(respuesta2)
                cmd2.ExecuteNonQuery()
                'desconecto la bdd
                clsDatos.DesconectarRemoto()
            Next

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para modificar un precio.
    Function ModificacionPrecio(ByVal id_Producto As Integer, ByVal id_Lista As Integer, ByVal Precio As Double) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_ProductosPrecios_Modificacion"
            With cmd.Parameters
                .AddWithValue("@id_Producto", id_Producto)
                .AddWithValue("@id_Lista", id_Lista)
                .AddWithValue("@Precio", Precio)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'desconecto la bdd
            clsDatos.DesconectarRemoto()

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para modificar un costo.
    Function ModificacionCosto(ByVal id_Producto As Integer, ByVal Costo As Double) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Productos_ModificacionCosto"
            With cmd.Parameters
                .AddWithValue("@id_Producto", id_Producto)
                .AddWithValue("@Costo", Costo)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'desconecto la bdd
            clsDatos.DesconectarRemoto()

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para eliminar un producto.
    Function EliminarProducto(ByVal id_Producto As Integer) As String
        Dim cmd As New SqlCommand

        'Traigo el producto para utilizar su codigo asi se obtiene la foto a eliminar.
        objProducto = TraerProducto(id_Producto)

        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Productos_Eliminar"
            With cmd.Parameters
                .AddWithValue("@id_Producto", id_Producto)
            End With
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)

            cmd.ExecuteNonQuery()
            clsDatos.DesconectarRemoto()

            'elimino la foto del ftp
            If objProducto.Foto <> "" Then
                Dim ftpclie As New NegConexionFtp("ftp://www.cinderelladecoracion.com/", "admin@cinderelladecoracion.com", "UyGQYiEc")
                ftpclie.eliminarFichero("ftp://www.cinderelladecoracion.com/www/software_cinderella/imagenes/" & objProducto.Foto)
            End If
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion que me trae el id del ultimo producto.
    Function UltimoProducto() As Integer
        Dim ds As DataSet
        If (HayInternet) Then
            ds = clsDatos.ConsultarBaseRemoto("Select IDENT_CURRENT('PRODUCTOS') as id_Producto")
        Else
            ds = clsDatos.ConsultarBaseLocal("Select IDENT_CURRENT('PRODUCTOS')  as id_Producto")
        End If

        If ds.Tables(0).Rows.Count = 1 And CInt(ds.Tables(0).Rows(0).Item("id_Producto")) > 0 Then
            Return ds.Tables(0).Rows(0).Item("id_Producto").ToString
        Else
            Return 1
        End If
    End Function

#End Region

#Region "Funciones Listados"
    'Funcion para listar todos los productos.
    Function ListadoProductos() As DataSet
        If (HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Productos_Listado")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Productos_Listado")
        End If
    End Function

    'Funcion para listar todos los productos.
    Function ListadoProductosBuscadores() As DataSet
        If (HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Productos_ListadoBuscadores")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Productos_ListadoBuscadores")
        End If
    End Function

    'Funcion para listar todos los productos dependiendo de un proveedor.
    Function ListadoProductosPorProveedor(ByVal id_Proveedor As Integer) As DataSet
        If (HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Productos_ListadoPorProveedor @id_Proveedor=" & id_Proveedor)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Productos_ListadoPorProveedor @id_Proveedor=" & id_Proveedor)
        End If
    End Function

    'Funcion para listar todos los productos dependiendo de un proveedor.
    Function ListadoProductosPorProveedores(ByVal where As String) As DataSet
        If (HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("SELECT Nombre + ' ('+ Codigo + ')' as Nombre,id_Producto,Codigo from Productos where (Habilitado=1) and (" & where & ") order by Nombre ASC")
        Else
            Return clsDatos.ConsultarBaseLocal("SELECT Nombre + ' ('+ Codigo + ')' as Nombre,id_Producto,Codigo from Productos where (Habilitado=1) and (" & where & ") order by Nombre ASC")
        End If
    End Function

    'Funcion para listar todos los productos dependiendo de un producto.
    Function ListadoProductosPrecios(ByVal id_Producto As Integer) As DataSet
        If (HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Productos_ListadoPrecios @id_Producto=" & id_Producto)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Productos_ListadoPrecios @id_Producto=" & id_Producto)
        End If
    End Function

#End Region

#Region "Funciones Exportar Excel"
    Function ExportarExcel(nombreArchivo As String, nombrePlantilla As String) As Integer
        Dim cmd As New SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim dsProductos As DataSet = New DataSet()
        Dim dsCategoria As DataSet = New DataSet()
        Dim dsSubCategoria As DataSet = New DataSet()
        Dim dsProveedor As DataSet = New DataSet()
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure

            RaiseEvent UpdateProgress(1, "Obteniendo Productos...")
            cmd.CommandText = "sp_Productos_ListadoExcel"
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(dsProductos)

            RaiseEvent UpdateProgress(2, "Obteniendo Categorias...")
            cmd.CommandText = "sp_ProductosCategorias_Listado"
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(dsCategoria)

            RaiseEvent UpdateProgress(3, "Obteniendo Subcategorias...")
            cmd.CommandText = "sp_ProductosSubcategorias_ListadoCompletoExcel"
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(dsSubCategoria)

            RaiseEvent UpdateProgress(4, "Obteniendo Proveedores...")
            cmd.CommandText = "sp_Proveedores_Listado"
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(dsProveedor)

            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value

            xlApp = New Excel.Application()
            xlApp.DisplayAlerts = False
            xlWorkBook = xlApp.Workbooks.Open(System.IO.Path.GetFullPath(nombrePlantilla))
            xlWorkSheet = CType(xlWorkBook.Worksheets.Item(1), Excel.Worksheet)

            xlWorkSheet.Name = "Productos"

            RaiseEvent UpdateProgress(5, "Cargando datos en Excel...")
            AddDataSetToWorkSheet(dsProductos, xlWorkSheet)

            '//Oculto la primera columan ya que en esta se eunetra el ID del producto y no debe ser modificado
            xlWorkSheet.Range("A1").EntireColumn.Hidden = True

            RaiseEvent UpdateProgress(6, "Armando validaciones en Excel...")
            '//Seteo el formato de la columnas y validacion
            '//Codigo
            SetColumnFormat(xlWorkSheet, "B", Fortmats.Texto)
            AgregaValidacion(xlWorkBook, xlWorkSheet, Excel.XlDVType.xlValidateTextLength, Excel.XlFormatConditionOperator.xlBetween, "B", "1;255", "El código ingresado no debe estar vacío y debe ser menor a los 255 caracteres.")
            '//Nombre
            SetColumnFormat(xlWorkSheet, "C", Fortmats.Texto)
            AgregaValidacion(xlWorkBook, xlWorkSheet, Excel.XlDVType.xlValidateTextLength, Excel.XlFormatConditionOperator.xlBetween, "C", "1;255", "El Nombre ingresado no debe estar vacío y debe ser menor a los 255 caracteres.")
            '//Origen
            SetColumnFormat(xlWorkSheet, "G", Fortmats.Texto)
            AgregaValidacion(xlWorkBook, xlWorkSheet, Excel.XlDVType.xlValidateTextLength, Excel.XlFormatConditionOperator.xlBetween, "G", "1;255", "El origen ingresado no debe estar vacío y debe ser menor a los 255 caracteres.")
            '//Tamaño
            SetColumnFormat(xlWorkSheet, "H", Fortmats.Texto)
            '//Costo
            SetColumnFormat(xlWorkSheet, "I", Fortmats.Moneda)
            AgregaValidacion(xlWorkBook, xlWorkSheet, Excel.XlDVType.xlValidateCustom, Excel.XlFormatConditionOperator.xlBetween, "I", "=NOT(ISBLANK($I2))", "El monto ingresado no debe estar vacío.")
            '//Codigo Barra
            SetColumnFormat(xlWorkSheet, "J", Fortmats.Numerico)
            AgregaValidacion(xlWorkBook, xlWorkSheet, Excel.XlDVType.xlValidateWholeNumber, Excel.XlFormatConditionOperator.xlBetween, "J", "1000000000000;9999999999999", "El código barras ingresado no debe estar vacío y debe tener 13 dígitos.")
            '//Precio Tigre
            SetColumnFormat(xlWorkSheet, "K", Fortmats.Moneda)
            AgregaValidacion(xlWorkBook, xlWorkSheet, Excel.XlDVType.xlValidateCustom, Excel.XlFormatConditionOperator.xlBetween, "K", "=NOT(ISBLANK($K2))", "El monto ingresado no debe estar vacío.")
            '//Precio Sarmiento
            SetColumnFormat(xlWorkSheet, "L", Fortmats.Moneda)
            AgregaValidacion(xlWorkBook, xlWorkSheet, Excel.XlDVType.xlValidateCustom, Excel.XlFormatConditionOperator.xlBetween, "L", "=NOT(ISBLANK($L2))", "El monto ingresado no debe estar vacío.")
            '//Precio Capital
            SetColumnFormat(xlWorkSheet, "M", Fortmats.Moneda)
            AgregaValidacion(xlWorkBook, xlWorkSheet, Excel.XlDVType.xlValidateCustom, Excel.XlFormatConditionOperator.xlBetween, "M", "=NOT(ISBLANK($M2))", "El monto ingresado no debe estar vacío.")
            '// Precio Mayorista SF
            SetColumnFormat(xlWorkSheet, "N", Fortmats.Moneda)
            AgregaValidacion(xlWorkBook, xlWorkSheet, Excel.XlDVType.xlValidateCustom, Excel.XlFormatConditionOperator.xlBetween, "N", "=NOT(ISBLANK($N2))", "El monto ingresado no debe estar vacío.")
            '//Precio Mayorista CF
            SetColumnFormat(xlWorkSheet, "O", Fortmats.Moneda)
            AgregaValidacion(xlWorkBook, xlWorkSheet, Excel.XlDVType.xlValidateCustom, Excel.XlFormatConditionOperator.xlBetween, "O", "=NOT(ISBLANK($O2))", "El monto ingresado no debe estar vacío.")
            '//Precio Mayorista CFR
            SetColumnFormat(xlWorkSheet, "P", Fortmats.Moneda)
            AgregaValidacion(xlWorkBook, xlWorkSheet, Excel.XlDVType.xlValidateCustom, Excel.XlFormatConditionOperator.xlBetween, "P", "=NOT(ISBLANK($P2))", "El monto ingresado no debe estar vacío.")

            '//Agrego la validacion de combos para el cargado de la categoria
            AgregarValidacionPorCombo(xlWorkBook, xlWorkSheet, dsCategoria.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.ItemArray(1).ToString()).ToArray(), "Categorias", "D")

            '//Agrego la validacion de combos anidados para el cargado de la SubCategoria
            AgregarValidacionPorComboAnidados(xlWorkBook, xlWorkSheet, dsSubCategoria, "SubCategorias", "E", "D2")

            '//Agrego la validacion de combos para el cargado de los porveedores
            AgregarValidacionPorCombo(xlWorkBook, xlWorkSheet, dsProveedor.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.ItemArray(1).ToString()).ToArray(), "Porveedores", "F")

            '//Agrego la validacion de combos para el cargado de Habilitado
            AgregarValidacionPorCombo(xlWorkBook, xlWorkSheet, New String() {"Si", "No"}, "Habilitado", "R")

            RaiseEvent UpdateProgress(7, "Guardando Excel...")
            xlWorkBook.SaveAs(nombreArchivo, Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, False, False, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlUserResolution, True, misValue, misValue, misValue)
            xlWorkBook.Close(True, misValue, misValue)
            xlApp.Quit()

            releaseObject(xlWorkSheet)
            releaseObject(xlWorkBook)
            releaseObject(xlApp)

            'MessageBox.Show("Excel file created , you can find the file c:\\csharp.net-informations.xls");
        Catch ex As Exception
            Return ex.Message
        End Try
        Return 1
    End Function

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

    Private Sub AgregarValidacionPorCombo(xlWorkBook As Excel.Workbook, xlWorkSheet As Excel.Worksheet, options As String(), Name As String, Column As String)

        Dim sheetValidation = xlWorkBook.Sheets.Add()
        sheetValidation.Name = Name
        sheetValidation.Visible = False

        'agergo los elementos del combo a la nueva hoja
        For i As Integer = 0 To options.Length - 1
            Dim Cell = String.Format("A{0}", (i + 1))
            sheetValidation.Range(Cell).Value = options(i)
        Next

        xlWorkBook.Names.Add(Name.Replace(" ", "_"), sheetValidation.Range(String.Format("{0}1:{0}{1}", IntToLetters(1), options.Length)))

        Dim validatingCellsRange As Excel.Range = xlWorkSheet.Range(Column + MinRowsData.ToString(), Column + MaxRowsData.ToString())
        Dim lookupValues = String.Format("={0}", Name)

        validatingCellsRange.Validation.Delete()
        validatingCellsRange.Validation.Add(Excel.XlDVType.xlValidateList, Excel.XlDVAlertStyle.xlValidAlertStop, Excel.XlFormatConditionOperator.xlBetween, lookupValues)
        validatingCellsRange.Validation.InCellDropdown = True
    End Sub

    Private Sub AgregarValidacionPorComboAnidados(xlWorkBook As Excel.Workbook, xlWorkSheet As Excel.Worksheet, dsSubCategoria As DataSet, Name As String, Column As String, Relacionado As String)

        Dim sheetValidation = xlWorkBook.Sheets.Add()
        sheetValidation.Name = Name
        sheetValidation.Visible = False

        Dim categorias = dsSubCategoria.Tables(0).Rows.Cast(Of DataRow).Select(Function(r) r.ItemArray(0).ToString()).Distinct().ToArray()

        For i As Integer = 0 To categorias.Length - 1

            Dim subCategorias As String() = dsSubCategoria.Tables(0).Rows.Cast(Of DataRow).Where(Function(r) r.ItemArray(0).ToString() = categorias(i)).Select(Function(y) y.ItemArray(1).ToString()).ToArray()
            Dim j As Integer = 0

            For Each subcategoria As String In subCategorias
                j = j + 1
                Dim Cell As String = String.Format("{0}{1}", IntToLetters(i + 1), j)
                sheetValidation.Range(Cell).Value = subcategoria

            Next
            xlWorkBook.Names.Add(categorias(i).Replace(" ", "_"), sheetValidation.Range(String.Format("{0}1:{0}{1}", IntToLetters(i + 1), j)))
        Next

        Dim validatingCellsRange As Excel.Range = xlWorkSheet.Range(Column + MinRowsData.ToString(), Column + MaxRowsData.ToString())

        Dim lookupValues = String.Format(String.Format("=indirect(SUBSTITUTE(${0};"" "";""_""))", Relacionado))

        validatingCellsRange.Validation.Delete()
        validatingCellsRange.Validation.Add(Excel.XlDVType.xlValidateList,
                Excel.XlDVAlertStyle.xlValidAlertStop,
                Excel.XlFormatConditionOperator.xlBetween, lookupValues)
        validatingCellsRange.Validation.InCellDropdown = True
    End Sub


    Private Sub AgregaValidacion(xlWorkBook As Excel.Workbook, xlWorkSheet As Excel.Worksheet, ValidationType As Excel.XlDVType, ConditionOperator As Excel.XlFormatConditionOperator, Column As String, lookupValues As String, ErrorMenssage As String)
        Dim validatingCellsRange As Excel.Range = xlWorkSheet.Range(Column + MinRowsData.ToString(), Column + MaxRowsData.ToString())

        If ValidationType = Excel.XlDVType.xlValidateCustom Then
            validatingCellsRange.Validation.Add(ValidationType, Excel.XlDVAlertStyle.xlValidAlertStop, Type.Missing, lookupValues)
        ElseIf ConditionOperator = Excel.XlFormatConditionOperator.xlBetween Then
            Dim cantidad As String() = lookupValues.Split(New Char() {";"})
            validatingCellsRange.Validation.Add(ValidationType, Excel.XlDVAlertStyle.xlValidAlertStop, ConditionOperator, cantidad(0), cantidad(1))
        Else
            validatingCellsRange.Validation.Add(ValidationType, Excel.XlDVAlertStyle.xlValidAlertStop, ConditionOperator, lookupValues)
        End If


        validatingCellsRange.Validation.IgnoreBlank = False
        validatingCellsRange.Validation.ErrorTitle = "Valore ingresado incorrecto"
        validatingCellsRange.Validation.ErrorMessage = ErrorMenssage
    End Sub

    Private Sub SetColumnFormat(sheet As Excel.Worksheet, column As String, format As Fortmats)

        Dim Range As Excel.Range = sheet.Range(column + MinRowsData.ToString(), column + MaxRowsData.ToString())

        Select Case format
            Case Fortmats.Moneda : Range.NumberFormat = "$#,##0.00;$-#,##0.00"
            Case Fortmats.Texto : Range.NumberFormat = "@"
            Case Fortmats.Numerico : Range.NumberFormat = "0"
        End Select

    End Sub

    Private Function IntToLetters(value As Integer) As String
        Dim result As String = String.Empty

        While value > 0
            value = value - 1
            result = Chr(65 + value Mod 26) + result
            value /= 26
        End While

        Return result
    End Function

    Private Sub releaseObject(obj As Object)
        Try

            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing

        Catch ex As Exception

            obj = Nothing

        Finally

            GC.Collect()
        End Try
    End Sub
#End Region

End Class
