Imports Excel = Microsoft.Office.Interop.Excel
Imports Entidades
Imports System.Data.SqlClient
Imports Datos
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Text
Imports System.Data.OleDb
Imports System.IO
Imports System.Linq

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

    Const MaxRowsData As Integer = 9999
    Const MinRowsData As Integer = 2

#Region "Funciones de Seleccion"
    'Funcion para consultar un producto.
    Public Function TraerProducto(ByVal id_Producto As Integer)
        Dim daProducto As New SqlDataAdapter
        Dim dsProducto As New DataSet
        Dim sqlcomando As New SqlCommand
        Dim entProducto As New Entidades.Productos
        Dim internet = False
        Dim HayInternet As Boolean = Funciones.HayInternet

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
        Dim HayInternet As Boolean = Funciones.HayInternet

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
        Dim HayInternet As Boolean = Funciones.HayInternet

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
        Dim HayInternet As Boolean = Funciones.HayInternet

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
        Dim HayInternet As Boolean = Funciones.HayInternet

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
        Dim HayInternet As Boolean = Funciones.HayInternet

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
        Dim HayInternet As Boolean = Funciones.HayInternet

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
            Dim CodigoBarra As String = ArmarCodigoBarras(id_Producto)

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

    Private Function ArmarCodigoBarras(id_Producto As String) As String
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
        Return CodigoBarra
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
            Dim CodigoBarra As String = ArmarCodigoBarras(id_Producto)

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

        If (Funciones.HayInternet) Then
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

        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Productos_Listado")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Productos_Listado")
        End If
    End Function

    'Funcion para listar todos los productos.
    Function ListadoProductosBuscadores() As DataSet
        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Productos_ListadoBuscadores")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Productos_ListadoBuscadores")
        End If
    End Function

    'Funcion para listar todos los productos dependiendo de un proveedor.
    Function ListadoProductosPorProveedor(ByVal id_Proveedor As Integer) As DataSet
        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Productos_ListadoPorProveedor @id_Proveedor=" & id_Proveedor)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Productos_ListadoPorProveedor @id_Proveedor=" & id_Proveedor)
        End If
    End Function

    'Funcion para listar todos los productos dependiendo de un proveedor.
    Function ListadoProductosPorProveedores(ByVal where As String) As DataSet
        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("SELECT Nombre + ' ('+ Codigo + ')' as Nombre,id_Producto,Codigo from Productos where (Habilitado=1) and (" & where & ") order by Nombre ASC")
        Else
            Return clsDatos.ConsultarBaseLocal("SELECT Nombre + ' ('+ Codigo + ')' as Nombre,id_Producto,Codigo from Productos where (Habilitado=1) and (" & where & ") order by Nombre ASC")
        End If
    End Function

    'Funcion para listar todos los productos dependiendo de un producto.
    Function ListadoProductosPrecios(ByVal id_Producto As Integer) As DataSet
        If (Funciones.HayInternet) Then
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
            xlWorkBook = xlApp.Workbooks.Add(System.IO.Path.GetFullPath(nombrePlantilla))
            xlWorkSheet = CType(xlWorkBook.Worksheets.Item(1), Excel.Worksheet)

            xlWorkSheet.Name = "Productos"

            RaiseEvent UpdateProgress(5, "Cargando datos en Excel...")
            AddDataSetToWorkSheet(dsProductos, xlWorkSheet)

            '//Oculto la primera columan ya que en esta se eunetra el ID del producto y no debe ser modificado
            xlWorkSheet.Range("A1").EntireColumn.Hidden = True

            RaiseEvent UpdateProgress(6, "Armando validaciones en Excel...")

            '//Agrego la validacion de combos para el cargado de la categoria
            AgregarValidacionPorCombo(xlWorkBook, xlWorkSheet, dsCategoria.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.ItemArray(1).ToString()).ToArray(), "Categorias", "D")

            '//Agrego la validacion de combos anidados para el cargado de la SubCategoria
            AgregarValidacionPorComboAnidados(xlWorkBook, xlWorkSheet, dsSubCategoria, "SubCategorias", "E", "D2")

            '//Agrego la validacion de combos para el cargado de los porveedores
            AgregarValidacionPorCombo(xlWorkBook, xlWorkSheet, dsProveedor.Tables(0).Rows.Cast(Of DataRow).Select(Function(x) x.ItemArray(1).ToString()).ToArray(), "Porveedores", "F")

            '//Agrego la validacion de combos para el cargado de Habilitado
            AgregarValidacionPorCombo(xlWorkBook, xlWorkSheet, New String() {"Si", "No"}, "Habilitado", "R")

            RaiseEvent UpdateProgress(7, "Guardando Excel...")
            xlApp.DisplayAlerts = False
            xlWorkBook.SaveAs(nombreArchivo, Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, False, False, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlUserResolution, True, misValue, misValue, misValue)
            xlApp.DisplayAlerts = True
            xlWorkBook.Close(0)
            xlApp.Workbooks.Close()
            xlApp.Quit()
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Administración de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return ex.Message

        Finally
            KillExcel()
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

    Private Sub KillExcel()

        Dim proc As System.Diagnostics.Process
        For Each proc In System.Diagnostics.Process.GetProcessesByName("EXCEL")
            If proc.MainWindowTitle.ToString = "" Then
                proc.Kill()
            End If
        Next

    End Sub
#End Region


#Region "Funciones Importar Excel"
    Function ImportarExcel(fileName As String, ByRef DatosConError As DataTable) As String

        Dim dsCategoria As DataSet = New DataSet()
        Dim dsProveedor As DataSet = New DataSet()
        Dim dsSubCategoria As DataSet = New DataSet()
        Dim dsProductos As DataSet = New DataSet()
        Dim dsBackUp As DataSet = New DataSet()
        Dim sourceData As DataTable

        Dim encripta As New ClsEncriptacion()
        Using conn As SqlConnection = New SqlConnection()

            conn.ConnectionString = encripta.DesencriptarMD5(ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.ConexionRemoto").ToString())
            conn.Open()

            RaiseEvent UpdateProgress(1, "Armando BackUp de seguridad...")

            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM PRECIOS", conn)
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
            adapter.Fill(dsBackUp, "PRECIOS")

            cmd = New SqlCommand("SELECT * FROM  STOCK", conn)
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(dsBackUp, "STOCK")

            cmd = New SqlCommand("SELECT * FROM PRODUCTOS", conn)
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(dsBackUp, "PRODUCTOS")

            'Guardo la informacion de la tabla antes de ser actualizada
            dsBackUp.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "\ProductosBKP.xml")

            cmd = New SqlCommand("SELECT id_Categoria as Id, Descripcion FROM PRODUCTOS_CATEGORIAS", conn)
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(dsCategoria)

            cmd = New SqlCommand("SELECT id_Subcategoria as Id, Descripcion FROM PRODUCTOS_SUBCATEGORIAS", conn)
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(dsSubCategoria)

            cmd = New SqlCommand("SELECT id_Proveedor as Id, RazonSocial FROM PROVEEDORES", conn)
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(dsProveedor)


            cmd = New SqlCommand("sp_Productos_ListadoExcel", conn)
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(dsProductos)
        End Using

        RaiseEvent UpdateProgress(2, "Obteniendo informacion del Excel...")
        sourceData = GetDataFormExcel(fileName, "Productos").Tables(0)

        If Not (verificarColumnasExcel(sourceData)) Then
            Return "El documento Excel que se está intentando importar se encuentra corrupto o es un documento que no fue generado por el proceso de exportación. Recuerde que solo puede modificar la información del documento exportado, no así el orden y nombre de las columnas."
        End If

        DatosConError = dsProductos.Tables(0).Clone()
        DatosConError.Columns.Add("Descripcion_Error")

        RaiseEvent UpdateProgress(3, "Validando informacion del Excel...")
        'Obtengo las filas eliminadas 
        Dim DatosEliminados = obtenerFilasEliminadas(dsProductos.Tables(0), sourceData)

        'Eliminos las filar que tiene un mismo codigo y lo inserto como error
        sourceData = ElmininarFilasComMismoValor(sourceData, DatosConError, "Codigo")

        'Obtengo las filas en las que se modifico alguno de sus valores y que tengan un ID al momento de ser exportado el excel
        Dim DatosActualizados = obtenerFilasModificadas(dsProductos, sourceData)

        'Busco los productos que en el excel no tiene ID (productos que pueden o no estar en la base)
        Dim DatosNuevos As List(Of DataRow) = sourceData.AsEnumerable().Where(Function(x) x(0).ToString() = String.Empty).ToList().ToList()

        'Verifico que estos productos nuevos no se encuentren en la base de datos
        DatosNuevos = DatosNuevos.Where(Function(x) dsProductos.Tables(0).Select(String.Format("Codigo = '{0}'", x.ItemArray(1))).Length = 0).ToList()

        'De las filas modificadas verifico que esten bien cargadas
        DatosActualizados = ValidarDatosVacios(DatosActualizados, DatosConError)

        'De las filas nuevas verifico que esten bien cargadas
        DatosNuevos = ValidarDatosVacios(DatosNuevos, DatosConError)

        RaiseEvent UpdateProgress(4, "Actualizando informacion en la base de datos...")
        Dim productos As StringBuilder = New StringBuilder()

        Dim idProductoMaximo As Integer = dsProductos.Tables(0).Rows.Cast(Of DataRow).Max(Function(x) x.ItemArray(0)) + 1

        'Armo sentiencias Delete
        productos.Append(ObtenerSQLPorProducto(DatosEliminados, dsCategoria, dsSubCategoria, dsProveedor, "Delete", idProductoMaximo))
        'Armo sentiencias Update
        productos.Append(ObtenerSQLPorProducto(DatosActualizados, dsCategoria, dsSubCategoria, dsProveedor, "Update", idProductoMaximo))
        'Armo sentiencias Insert
        productos.Append(ObtenerSQLPorProducto(DatosNuevos, dsCategoria, dsSubCategoria, dsProveedor, "Insert", idProductoMaximo))

        If (productos.Length > 0) Then
            Using conn As SqlConnection = New SqlConnection()

                conn.ConnectionString = encripta.DesencriptarMD5(ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.ConexionRemoto").ToString())
                conn.Open()
                Using tran As SqlTransaction = conn.BeginTransaction()

                    Try
                        Dim cmd As SqlCommand = New SqlCommand(productos.ToString(), conn)
                        cmd.Transaction = tran
                        cmd.ExecuteNonQuery()
                        tran.Commit()
                    Catch ex As Exception
                        tran.Rollback()
                        Throw
                    End Try
                End Using
            End Using
            If (DatosConError.Rows.Count = 0) Then
                Return String.Format("Se han cargado {0} nuevos productos, se han actualizaron {1} productos y se han eliminado {2} productos.", DatosNuevos.Count, DatosActualizados.Count, DatosEliminados.Count)
            Else
                Return String.Format("Se han cargado {0} nuevos productos, se han actualizaron {1} productos, se han eliminado {2} productos y se encontrar {3} productos con errores para ser importados.", DatosNuevos.Count, DatosActualizados.Count, DatosEliminados.Count, DatosConError.Rows.Count)
            End If

        Else
            If (DatosConError.Rows.Count = 0) Then
                Return "No se encontraron nuevos productos o productos modificados en el Excel importado."
            Else
                Return String.Format("Se encontrar {0} productos con errores para ser importados.", DatosConError.Rows.Count)
            End If
        End If
    End Function

    Function ObtenerSQLPorProducto(Datos As List(Of DataRow), dsCategoria As DataSet, dsSubCategoria As DataSet, dsProveedor As DataSet, comando As String, idProductoMaximo As Integer) As StringBuilder
        Dim i As Integer = 0
        Dim sql As StringBuilder = New StringBuilder()
        Dim codigoBarras As String

        Do While (i < Datos.Count)
            'Obtengo el codigo de la Categoria ingresada
            Dim categoriaDescripcion As String = Datos(i)("Categoria").ToString()
            Dim categoria As DataRow = dsCategoria.Tables(0).Rows.Cast(Of DataRow)().Where(Function(r) r.ItemArray(1).ToString() = categoriaDescripcion).FirstOrDefault()

            'Obtengo el codigo de la SubCategoria ingresada
            Dim subCategoriaDescripcion As String = Datos(i)("SubCategoria").ToString()
            Dim subCategoria As DataRow = dsSubCategoria.Tables(0).Rows.Cast(Of DataRow)().Where(Function(r) r.ItemArray(1).ToString() = subCategoriaDescripcion).FirstOrDefault()

            'Obtengo el codigo de la Proveedor ingresada
            Dim ProveedorDescripcion As String = Datos(i)("Proveedor").ToString()
            Dim Proveedor As DataRow = dsProveedor.Tables(0).Rows.Cast(Of DataRow)().Where(Function(r) r.ItemArray(1).ToString() = ProveedorDescripcion).FirstOrDefault()

            'Obtengo el codigo de Habilitacion
            Dim habilitado As Integer = If(Datos(i)(17).ToString() = "Si", 1, 0)

            If (comando = "Insert") Then
                If (String.IsNullOrEmpty(Datos(i)("CodigoBarra").ToString())) Then
                    codigoBarras = ArmarCodigoBarras(idProductoMaximo + i)
                Else
                    codigoBarras = Datos(i)("CodigoBarra")
                End If

                ArmarInsert(sql, Datos(i), categoria, subCategoria, Proveedor, codigoBarras, habilitado)

            ElseIf (comando = "Update") Then
                If (String.IsNullOrEmpty(Datos(i)("CodigoBarra").ToString())) Then
                    codigoBarras = ArmarCodigoBarras(Datos(i)("id_producto").ToString())
                Else
                    codigoBarras = Datos(i)("CodigoBarra")
                End If
                ArmarUpdate(sql, Datos(i), categoria, subCategoria, Proveedor, codigoBarras, habilitado)
            ElseIf (comando = "Delete") Then
                ArmarDelete(sql, Datos(i))
            End If
            i = (i + 1)
        Loop
        Return sql
    End Function

    Sub ArmarInsert(ByRef Productos As StringBuilder, DatosAGuardar As DataRow, categoria As DataRow, subCategoria As DataRow, Proveedor As DataRow, CodigoBarras As String, habilitado As Integer)
        Productos.AppendFormat("INSERT INTO [dbo].[PRODUCTOS] ([id_Categoria],[id_Subcategoria],[id_Proveedor],[Nombre],[Descripcion],[Costo],[Origen],[Tamano],[Codigo],[CodigoBarra],[Fecha],[Habilitado],[Novedad],[SubirWeb]) VALUES ({0},{1},{2},'{3}','{4}',{5},'{6}','{7}','{8}','{9}','{10}',{11},{12},{13})", categoria.ItemArray(0), subCategoria.ItemArray(0), Proveedor.ItemArray(0), DatosAGuardar(2), DatosAGuardar(16), Decimal.Parse(DatosAGuardar(8).ToString()).ToString(System.Globalization.CultureInfo.InvariantCulture), DatosAGuardar(6), DatosAGuardar(7), DatosAGuardar(1), CodigoBarras, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), habilitado, 0, 0)
        Productos.AppendFormat("INSERT INTO [dbo].[PRECIOS] ([id_Producto] ,[id_Lista] ,[Precio] ,[Habilitado]) VALUES ((SELECT IDENT_CURRENT('[dbo].[PRODUCTOS]')),{0},{1},{2})", "1", Decimal.Parse(DatosAGuardar(10).ToString()).ToString(System.Globalization.CultureInfo.InvariantCulture), "1")
        Productos.AppendFormat("INSERT INTO [dbo].[PRECIOS] ([id_Producto] ,[id_Lista] ,[Precio] ,[Habilitado]) VALUES ((SELECT IDENT_CURRENT('[dbo].[PRODUCTOS]')),{0},{1},{2})", "2", Decimal.Parse(DatosAGuardar(11).ToString()).ToString(System.Globalization.CultureInfo.InvariantCulture), "1")
        Productos.AppendFormat("INSERT INTO [dbo].[PRECIOS] ([id_Producto] ,[id_Lista] ,[Precio] ,[Habilitado]) VALUES ((SELECT IDENT_CURRENT('[dbo].[PRODUCTOS]')),{0},{1},{2})", "3", Decimal.Parse(DatosAGuardar(12).ToString()).ToString(System.Globalization.CultureInfo.InvariantCulture), "1")
        Productos.AppendFormat("INSERT INTO [dbo].[PRECIOS] ([id_Producto] ,[id_Lista] ,[Precio] ,[Habilitado]) VALUES ((SELECT IDENT_CURRENT('[dbo].[PRODUCTOS]')),{0},{1},{2})", "4", Decimal.Parse(DatosAGuardar(13).ToString()).ToString(System.Globalization.CultureInfo.InvariantCulture), "1")
        Productos.AppendFormat("INSERT INTO [dbo].[PRECIOS] ([id_Producto] ,[id_Lista] ,[Precio] ,[Habilitado]) VALUES ((SELECT IDENT_CURRENT('[dbo].[PRODUCTOS]')),{0},{1},{2})", "5", Decimal.Parse(DatosAGuardar(14).ToString()).ToString(System.Globalization.CultureInfo.InvariantCulture), "1")
        Productos.AppendFormat("INSERT INTO [dbo].[PRECIOS] ([id_Producto] ,[id_Lista] ,[Precio] ,[Habilitado]) VALUES ((SELECT IDENT_CURRENT('[dbo].[PRODUCTOS]')),{0},{1},{2})", "6", Decimal.Parse(DatosAGuardar(15).ToString()).ToString(System.Globalization.CultureInfo.InvariantCulture), "1")
    End Sub

    Sub ArmarDelete(ByRef Productos As StringBuilder, DatosAGuardar As DataRow)
        Productos.AppendFormat("DELETE FROM [dbo].[STOCK] WHERE [id_Producto] = {0}", DatosAGuardar(0))
        Productos.AppendFormat("DELETE FROM [dbo].[PRECIOS] WHERE [id_Producto] = {0}", DatosAGuardar(0))
        Productos.AppendFormat("DELETE FROM [dbo].[PRODUCTOS] WHERE id_producto = {0}", DatosAGuardar(0))
    End Sub

    Sub ArmarUpdate(ByRef Productos As StringBuilder, DatosAGuardar As DataRow, categoria As DataRow, subCategoria As DataRow, Proveedor As DataRow, CodigoBarras As String, habilitado As Integer)
        Productos.AppendFormat("UPDATE [dbo].[PRODUCTOS]   SET [id_Categoria] = {0} ,[id_Subcategoria] = {1} ,[id_Proveedor] = {2} ,[Nombre] = '{3}' ,[Descripcion] = '{4}' ,[Costo] = {5} ,[Origen] = '{6}' ,[Tamano] = '{7}' ,[Codigo] = '{8}' ,[CodigoBarra] = '{9}' ,[Habilitado] = {10} ,[Novedad] = {11} ,[SubirWeb] = {12} WHERE id_producto = {13}", categoria.ItemArray(0), subCategoria.ItemArray(0), Proveedor.ItemArray(0), DatosAGuardar(2), DatosAGuardar(16), Decimal.Parse(DatosAGuardar(8).ToString()).ToString(System.Globalization.CultureInfo.InvariantCulture), DatosAGuardar(6), DatosAGuardar(7), DatosAGuardar(1), CodigoBarras, habilitado, 0, 0, DatosAGuardar(0))
        Productos.AppendFormat("UPDATE [dbo].[PRECIOS] SET [Precio] = {0} WHERE [id_Producto] = {1} AND [id_Lista] = {2}", Decimal.Parse(DatosAGuardar(10).ToString()).ToString(System.Globalization.CultureInfo.InvariantCulture), DatosAGuardar(0), "1")
        Productos.AppendFormat("UPDATE [dbo].[PRECIOS] SET [Precio] = {0} WHERE [id_Producto] = {1} AND [id_Lista] = {2}", Decimal.Parse(DatosAGuardar(11).ToString()).ToString(System.Globalization.CultureInfo.InvariantCulture), DatosAGuardar(0), "2")
        Productos.AppendFormat("UPDATE [dbo].[PRECIOS] SET [Precio] = {0} WHERE [id_Producto] = {1} AND [id_Lista] = {2}", Decimal.Parse(DatosAGuardar(12).ToString()).ToString(System.Globalization.CultureInfo.InvariantCulture), DatosAGuardar(0), "3")
        Productos.AppendFormat("UPDATE [dbo].[PRECIOS] SET [Precio] = {0} WHERE [id_Producto] = {1} AND [id_Lista] = {2}", Decimal.Parse(DatosAGuardar(13).ToString()).ToString(System.Globalization.CultureInfo.InvariantCulture), DatosAGuardar(0), "4")
        Productos.AppendFormat("UPDATE [dbo].[PRECIOS] SET [Precio] = {0} WHERE [id_Producto] = {1} AND [id_Lista] = {2}", Decimal.Parse(DatosAGuardar(14).ToString()).ToString(System.Globalization.CultureInfo.InvariantCulture), DatosAGuardar(0), "5")
        Productos.AppendFormat("UPDATE [dbo].[PRECIOS] SET [Precio] = {0} WHERE [id_Producto] = {1} AND [id_Lista] = {2}", Decimal.Parse(DatosAGuardar(15).ToString()).ToString(System.Globalization.CultureInfo.InvariantCulture), DatosAGuardar(0), "6")
    End Sub

    Function verificarColumnasExcel(datos As DataTable) As Boolean

        'verifico que la cantidad de columnas no halla sido modificada 
        If datos.Columns.Count <> 18 Then
            Return False
        End If

        'verifico que los nombres y orden de las columnas no hallan sido modificadas 
        If datos.Columns(0).ColumnName <> "id_producto" Or datos.Columns(1).ColumnName <> "Codigo" Or
            datos.Columns(2).ColumnName <> "Nombre" Or datos.Columns(3).ColumnName <> "Categoria" Or
            datos.Columns(4).ColumnName <> "SubCategoria" Or datos.Columns(5).ColumnName <> "Proveedor" Or
            datos.Columns(6).ColumnName <> "Origen" Or datos.Columns(7).ColumnName <> "Tamaño" Or
            datos.Columns(8).ColumnName <> "Costo" Or datos.Columns(9).ColumnName <> "CodigoBarra" Or
            datos.Columns(10).ColumnName <> "Efectivo_Tigre" Or datos.Columns(11).ColumnName <> "Tarjeta_Tigre" Or
            datos.Columns(12).ColumnName <> "Efectivo_Capital" Or datos.Columns(13).ColumnName <> "Tarjeta_Capital" Or
            datos.Columns(14).ColumnName <> "Mayor_SF" Or datos.Columns(15).ColumnName <> "Mayor_CF" Or
            datos.Columns(16).ColumnName <> "Descripcion" Or datos.Columns(17).ColumnName <> "Habilitado" Then
            Return False
        End If
        Return True
    End Function

    Function obtenerFilasEliminadas(base As DataTable, importados As DataTable) As List(Of DataRow)
        Dim hTable As Hashtable = New Hashtable()
        Dim deleteList As List(Of DataRow) = New List(Of DataRow)

        'Agrego las valores a un HashTable para determinar si el valor de la columan se encuentra duplicado
        For Each drow As DataRow In importados.Rows
            If drow("id_producto").ToString() <> "" Then
                If Not hTable.Contains(Integer.Parse(drow("id_producto").ToString())) Then
                    hTable.Add(Integer.Parse(drow("id_producto").ToString()), String.Empty)
                End If
            End If
        Next

        For Each drow As DataRow In base.Rows
            If Not hTable.Contains(Integer.Parse(drow("id_producto").ToString())) Then
                deleteList.Add(drow)
            End If
        Next

        Return deleteList
    End Function

    Function ElmininarFilasComMismoValor(dTable As DataTable, ByRef errors As DataTable, colName As String) As DataTable
        Dim hTable As Hashtable = New Hashtable()
        Dim duplicateList As ArrayList = New ArrayList()

        'Agrego las valores a un HashTable para determinar si el valor de la columan se encuentra duplicado
        For Each drow As DataRow In dTable.Rows

            If hTable.Contains(drow(colName)) Then
                duplicateList.Add(drow)
            Else
                hTable.Add(drow(colName), String.Empty)
            End If
        Next

        'Elimino el valor duplicado de la lista 
        For Each dRow As DataRow In duplicateList
            errors.ImportRow(dRow)
            errors.Rows.Item(errors.Rows.Count - 1)("Descripcion_Error") = "Producto con Código duplicado"
            dTable.Rows.Remove(dRow)
        Next

        Return dTable
    End Function

    Function obtenerFilasModificadas(dsProductos As DataSet, sourceData As DataTable) As List(Of DataRow)
        Return (From product In dsProductos.Tables(0).AsEnumerable()
                                 Join d In sourceData.AsEnumerable() On product(0).ToString() Equals d(0).ToString()
                                 Where (product(1).ToString() <> d(1).ToString() Or
                                       product(2).ToString() <> d(2).ToString() Or
                                       product(3).ToString() <> d(3).ToString() Or
                                       product(4).ToString() <> d(4).ToString() Or
                                       product(5).ToString() <> d(5).ToString() Or
                                       product(6).ToString() <> d(6).ToString() Or
                                       product(7).ToString() <> d(7).ToString() Or
                                       Decimal.Parse(If(product(8).ToString() = "", "0", product(8).ToString())) <> Decimal.Parse(If(d(8).ToString() = "", "0", d(8).ToString())) Or
                                       product(9).ToString() <> d(9).ToString() Or
                                       Decimal.Parse(If(product(10).ToString() = "", "0", product(10).ToString())) <> Decimal.Parse(If(d(10).ToString() = "", "0", d(10).ToString())) Or
                                       Decimal.Parse(If(product(11).ToString() = "", "0", product(11).ToString())) <> Decimal.Parse(If(d(11).ToString() = "", "0", d(11).ToString())) Or
                                       Decimal.Parse(If(product(12).ToString() = "", "0", product(12).ToString())) <> Decimal.Parse(If(d(12).ToString() = "", "0", d(12).ToString())) Or
                                       Decimal.Parse(If(product(13).ToString() = "", "0", product(13).ToString())) <> Decimal.Parse(If(d(13).ToString() = "", "0", d(13).ToString())) Or
                                       Decimal.Parse(If(product(14).ToString() = "", "0", product(14).ToString())) <> Decimal.Parse(If(d(14).ToString() = "", "0", d(14).ToString())) Or
                                       Decimal.Parse(If(product(15).ToString() = "", "0", product(15).ToString())) <> Decimal.Parse(If(d(15).ToString() = "", "0", d(15).ToString())) Or
                                       product(16).ToString() <> d(16).ToString() Or
                                       product(17).ToString() <> d(17).ToString())
                                Select d).ToList()
    End Function

    Function ValidarDatosVacios(datos As List(Of DataRow), ByRef DatosConError As DataTable) As List(Of DataRow)

        Dim DatosAGuardar As List(Of DataRow) = New List(Of DataRow)
        Dim dummy As Decimal

        For Each row As DataRow In datos

            If (row(1).ToString() <> String.Empty And
                row(2).ToString() <> String.Empty And
               row(3).ToString() <> String.Empty And
               row(4).ToString() <> String.Empty And
               row(5).ToString() <> String.Empty And
               Decimal.TryParse(row(8).ToString(), dummy) And
               Decimal.TryParse(row(10).ToString(), dummy) And
               Decimal.TryParse(row(11).ToString(), dummy) And
               Decimal.TryParse(row(12).ToString(), dummy) And
               Decimal.TryParse(row(13).ToString(), dummy) And
               Decimal.TryParse(row(14).ToString(), dummy) And
               Decimal.TryParse(row(15).ToString(), dummy) And
               row(17).ToString() <> String.Empty) Then

                DatosAGuardar.Add(row)
            Else
                DatosConError.ImportRow(row)
                DatosConError.Rows.Item(DatosConError.Rows.Count - 1)("Descripcion_Error") = "Campo obligatorio vacío"
            End If

        Next
        Return DatosAGuardar
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

#End Region

    Sub Restaurar()

        Dim dsBackUp As DataSet = New DataSet()
        Dim encripta As New ClsEncriptacion()
        Dim paso As Integer = 1

        RaiseEvent UpdateProgress(paso, "Obteniendo información del BackUp...")
        paso += 1
        dsBackUp.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "\ProductosBKP.xml", XmlReadMode.Auto)


        For Each row As DataRow In dsBackUp.Tables(0).Rows
            row("Precio") = row("Precio").ToString().Replace(".", ",")
        Next

        Using conn As SqlConnection = New SqlConnection()

            conn.ConnectionString = encripta.DesencriptarMD5(ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.ConexionRemoto").ToString())
            conn.Open()
            Using tran As SqlTransaction = conn.BeginTransaction()

                Try
                    Using bulkCopy As SqlBulkCopy = New SqlBulkCopy(conn, SqlBulkCopyOptions.KeepIdentity, tran)

                        For Each table As DataTable In dsBackUp.Tables

                            Dim cmd As SqlCommand = New SqlCommand(String.Format("DELETE  FROM {0}", table.TableName), conn, tran)
                            cmd.ExecuteNonQuery()

                        Next

                        For Each table As DataTable In dsBackUp.Tables

                            RaiseEvent UpdateProgress(paso, "Guardando información en base de datos...")
                            paso += 1
                            bulkCopy.DestinationTableName = table.TableName
                            bulkCopy.WriteToServer(table)

                        Next
                    End Using
                    tran.Commit()
                Catch ex As Exception
                    tran.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Sub
End Class
