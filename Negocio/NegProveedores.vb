Imports Entidades
Imports System.Data.SqlClient
Imports Datos
Public Class NegProveedores
    Dim objProveedores As Entidades.Proveedores
    Dim clsDatos As New Datos.Conexion
    Dim con As New Conexion
    Dim negFunciones As New Negocio.Funciones

    'Funcion que trae solo los proveedores habilitados.
    Function ListadoProveedores() As DataSet

        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Proveedores_Listado")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Proveedores_Listado")
        End If

    End Function

    Function ListadoProveedoresConStock(id_Sucursal As Integer) As DataSet

        If (Funciones.HayInternet) Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Proveedores_ListadoConStock @id_Sucursal=" & id_Sucursal)
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Proveedores_ListadoConStock @id_Sucursal=" & id_Sucursal)
        End If

    End Function

    'Funcion que trae TODOS los proveedores.
    Function ListadoProveedoresCompleto() As DataSet
        Return clsDatos.ConsultarBaseRemoto("execute sp_Proveedores_ListadoCompleto")
    End Function

    'Funcion para consultar un proveedor.
    Public Function TraerProveedor(ByVal id_Proveedor As Integer) As Proveedores
        Dim daProveedor As New SqlDataAdapter
        Dim dsProveedor As New DataSet
        Dim sqlcomando As New SqlCommand
        Dim entProveedor As New Entidades.Proveedores

        sqlcomando.CommandText = ("select * from PROVEEDORES where id_Proveedor ='" & id_Proveedor & "'")
        sqlcomando.Connection = con.ConectarRemoto

        If (Funciones.HayInternet) Then
            sqlcomando.Connection = con.ConectarRemoto
        Else
            sqlcomando.Connection = con.ConectarLocal
        End If

        daProveedor = New SqlDataAdapter(sqlcomando)
        daProveedor.Fill(dsProveedor)

        If dsProveedor.Tables(0).Rows.Count <> 0 Then
            entProveedor = ObtenerEntidadProveedor(dsProveedor.Tables(0).Rows(0))
        End If

        If (Funciones.HayInternet) Then
            con.DesconectarRemoto()
        Else
            con.DesconectarLocal()
        End If

        Return entProveedor

    End Function

    'Funcion para consultar todos los proveedores.
    Public Function TraerProveedor() As List(Of Proveedores)
        Dim daProveedor As New SqlDataAdapter
        Dim dsProveedor As New DataSet
        Dim sqlcomando As New SqlCommand
        Dim proveedores As List(Of Proveedores) = New List(Of Proveedores)()


        sqlcomando.CommandText = ("select * from PROVEEDORES where Habilitado = 1")
        If (Funciones.HayInternet) Then
            sqlcomando.Connection = con.ConectarRemoto
        Else
            sqlcomando.Connection = con.ConectarLocal
        End If

        daProveedor = New SqlDataAdapter(sqlcomando)
        daProveedor.Fill(dsProveedor)

        If dsProveedor.Tables(0).Rows.Count <> 0 Then
            For Each dr As DataRow In dsProveedor.Tables(0).Rows
                proveedores.Add(ObtenerEntidadProveedor(dr))
            Next
        End If

        If (Funciones.HayInternet) Then
            con.DesconectarRemoto()
        Else
            con.DesconectarLocal()
        End If

        Return proveedores
    End Function

    Private Shared Function ObtenerEntidadProveedor(dr As DataRow) As Proveedores
        Dim entProveedor As New Proveedores
        entProveedor.id_Proveedor = dr.Item("id_Proveedor").ToString
        entProveedor.RazonSocial = dr.Item("RazonSocial").ToString
        entProveedor.Nombre = dr.Item("Nombre").ToString
        entProveedor.Direccion = dr.Item("Direccion").ToString
        entProveedor.Mail = dr.Item("Mail").ToString
        entProveedor.Telefono = dr.Item("Telefono").ToString
        entProveedor.Mail_Alternativo = dr.Item("Mail_Alternativo").ToString
        entProveedor.id_CondicionIva = dr.Item("id_CondicionIva").ToString
        entProveedor.Habilitado = dr.Item("Habilitado").ToString
        entProveedor.DiaPreferentePedido = If(String.IsNullOrEmpty(dr.Item("DiaPreferentePedido").ToString), -1, dr.Item("DiaPreferentePedido").ToString)
        entProveedor.PlazoEntrega = If(String.IsNullOrEmpty(dr.Item("DiaPreferentePedido").ToString), 0, dr.Item("PlazoEntrega").ToString)
        Return entProveedor
    End Function

    'Funcion para insertar un proveedor.
    Function AltaProveedor(ByVal eproveedor As Entidades.Proveedores) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Proveedores_Alta"
            With cmd.Parameters
                .AddWithValue("@id_Proveedor", eproveedor.id_Proveedor)
                .AddWithValue("@id_CondicionIva", eproveedor.id_CondicionIva)
                .AddWithValue("@RazonSocial", eproveedor.RazonSocial)
                .AddWithValue("@Nombre", eproveedor.Nombre)
                .AddWithValue("@Direccion", eproveedor.Direccion)
                .AddWithValue("@Mail", eproveedor.Mail)
                .AddWithValue("@Telefono", eproveedor.Telefono)
                .AddWithValue("@Mail_Alternativo", eproveedor.Mail_Alternativo)
                .AddWithValue("@DiaPreferentePedido", eproveedor.DiaPreferentePedido)
                .AddWithValue("@PlazoEntrega", eproveedor.PlazoEntrega)
                .AddWithValue("@Habilitado", eproveedor.Habilitado)
                .AddWithValue("@Fecha", DateTime.Now)
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

    'Funcion para modificar un proveedor.
    Function ModificacionProveedor(ByVal eproveedores As Entidades.Proveedores) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Proveedores_Modificacion"
            With cmd.Parameters
                .AddWithValue("@id_Proveedor", eproveedores.id_Proveedor)
                .AddWithValue("@RazonSocial", eproveedores.RazonSocial)
                .AddWithValue("@Nombre", eproveedores.Nombre)
                .AddWithValue("@Direccion", eproveedores.Direccion)
                .AddWithValue("@Mail", eproveedores.Mail)
                .AddWithValue("@Telefono", eproveedores.Telefono)
                .AddWithValue("@Mail_Alternativo", eproveedores.Mail_Alternativo)
                .AddWithValue("@id_CondicionIva", eproveedores.id_CondicionIva)
                .AddWithValue("@DiaPreferentePedido", eproveedores.DiaPreferentePedido)
                .AddWithValue("@PlazoEntrega", eproveedores.PlazoEntrega)
                .AddWithValue("@Habilitado", eproveedores.Habilitado)
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

    'Funcion para eliminar un proveedor.
    Function EliminarProveedor(ByVal id_Proveedor As Integer) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Proveedores_Eliminar"
            With cmd.Parameters
                .AddWithValue("@id_Proveedor", id_Proveedor)
            End With
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)

            cmd.ExecuteNonQuery()
            clsDatos.DesconectarRemoto()

            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

End Class
