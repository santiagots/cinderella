Imports System.Data.SqlClient
Public Class NegSucursales
    Dim ClsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    'Funcion para listar todas las sucursales activas.
    Function ListadoSucursales() As DataSet
        Dim dsSucursales As DataSet

        If Funciones.HayInternet Then
            dsSucursales = ClsDatos.ConsultarBaseRemoto("execute sp_Sucursales_Listado")
        Else
            dsSucursales = ClsDatos.ConsultarBaseLocal("execute sp_Sucursales_Listado")
        End If
        Return dsSucursales
    End Function

    Function ListadoSucursalesEntidad() As List(Of Entidades.Sucursales)

        Dim Sucursales As List(Of Entidades.Sucursales) = New List(Of Entidades.Sucursales)
        Dim dsSucursales As DataSet

        If Funciones.HayInternet Then
            dsSucursales = ClsDatos.ConsultarBaseRemoto("execute sp_Sucursales_Listado")
        Else
            dsSucursales = ClsDatos.ConsultarBaseLocal("execute sp_Sucursales_Listado")
        End If

        If dsSucursales.Tables(0).Rows.Count <> 0 Then
            For Each row As DataRow In dsSucursales.Tables(0).Rows
                Dim Sucursal As Entidades.Sucursales = New Entidades.Sucursales()

                Sucursal.id_Sucursal = row.Item("id_Sucursal").ToString
                Sucursal.Nombre = row.Item("Nombre").ToString
                Sucursal.Direccion = row.Item("Direccion").ToString
                Sucursal.Codigo_Postal = CInt(row.Item("Codigo_Postal"))
                Sucursal.Telefono = row.Item("Telefono").ToString
                Sucursal.Habilitado = row.Item("Habilitado").ToString
                Sucursal.id_Provincia = row.Item("id_Provincia").ToString
                Sucursal.id_Localidad = row.Item("id_Localidad").ToString
                Sucursal.id_Distrito = row.Item("id_Departamento").ToString
                Sucursal.id_ListaGrupoPrecio = row.Item("id_ListaGrupoPrecio").ToString
                Sucursal.ComisionEncargado = CDbl(row.Item("Comision_Encargado"))
                Sucursal.ComisionVendedor = CDbl(row.Item("Comision_Vendedor"))
                Sucursal.ComisionEncargadoFeriado = CDbl(row.Item("Comision_Encargado_Feriado"))
                Sucursal.ComisionVendedorFeriado = CDbl(row.Item("Comision_Vendedor_Feriado"))
                Sucursal.ComisionEncargadoMayor = CDbl(row.Item("Comision_Encargado_Mayor"))
                Sucursal.ComisionVendedorMayor = CDbl(row.Item("Comision_Vendedor_Mayor"))
                Sucursal.CodigoVenta = row.Item("Codigo_Venta").ToString

                Sucursales.Add(Sucursal)
            Next
        End If

        Return Sucursales

    End Function


    'Funcion para consultar una sucursal determinada.
    Public Function TraerSucursal(ByVal id_Sucursal As Integer)
        Dim dsSucursal As New DataSet
        Dim entSucursal As New Entidades.Sucursales

        If Funciones.HayInternet Then
            dsSucursal = ClsDatos.ConsultarBaseRemoto("execute sp_Sucursal_Detalle @id_Sucursal=" & id_Sucursal)
        Else
            dsSucursal = ClsDatos.ConsultarBaseLocal("execute sp_Sucursal_Detalle @id_Sucursal=" & id_Sucursal)
        End If

        If dsSucursal.Tables(0).Rows.Count <> 0 Then
            entSucursal.id_Sucursal = dsSucursal.Tables(0).Rows(0).Item("id_Sucursal").ToString
            entSucursal.Nombre = dsSucursal.Tables(0).Rows(0).Item("Nombre").ToString
            entSucursal.Direccion = dsSucursal.Tables(0).Rows(0).Item("Direccion").ToString
            entSucursal.Codigo_Postal = CInt(dsSucursal.Tables(0).Rows(0).Item("Codigo_Postal"))
            entSucursal.Telefono = dsSucursal.Tables(0).Rows(0).Item("Telefono").ToString
            entSucursal.Habilitado = dsSucursal.Tables(0).Rows(0).Item("Habilitado").ToString
            entSucursal.id_Provincia = dsSucursal.Tables(0).Rows(0).Item("id_Provincia").ToString
            entSucursal.id_Localidad = dsSucursal.Tables(0).Rows(0).Item("id_Localidad").ToString
            entSucursal.id_Distrito = dsSucursal.Tables(0).Rows(0).Item("id_Departamento").ToString
            entSucursal.id_ListaGrupoPrecio = dsSucursal.Tables(0).Rows(0).Item("id_ListaGrupoPrecio").ToString
            entSucursal.ComisionEncargado = CDbl(dsSucursal.Tables(0).Rows(0).Item("Comision_Encargado"))
            entSucursal.ComisionVendedor = CDbl(dsSucursal.Tables(0).Rows(0).Item("Comision_Vendedor"))
            entSucursal.ComisionEncargadoFeriado = CDbl(dsSucursal.Tables(0).Rows(0).Item("Comision_Encargado_Feriado"))
            entSucursal.ComisionVendedorFeriado = CDbl(dsSucursal.Tables(0).Rows(0).Item("Comision_Vendedor_Feriado"))
            entSucursal.ComisionEncargadoMayor = CDbl(dsSucursal.Tables(0).Rows(0).Item("Comision_Encargado_Mayor"))
            entSucursal.ComisionVendedorMayor = CDbl(dsSucursal.Tables(0).Rows(0).Item("Comision_Vendedor_Mayor"))
            entSucursal.CodigoVenta = dsSucursal.Tables(0).Rows(0).Item("Codigo_Venta").ToString
        End If
        Return entSucursal
    End Function

    'Funcion para insertar una sucursal.
    Function AltaSucursal(ByVal esucursales As Entidades.Sucursales) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            If Funciones.HayInternet Then
                cmd.Connection = ClsDatos.ConectarRemoto()
            Else
                cmd.Connection = ClsDatos.ConectarLocal()
            End If

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Sucursales_Alta"

            With cmd.Parameters
                .AddWithValue("@Nombre", esucursales.Nombre)
                .AddWithValue("@Direccion", esucursales.Direccion)
                .AddWithValue("@id_Provincia", esucursales.id_Provincia)
                .AddWithValue("@id_Departamento", esucursales.id_Distrito)
                .AddWithValue("@id_Localidad", esucursales.id_Localidad)
                .AddWithValue("@id_ListaGrupoPrecio", esucursales.id_ListaGrupoPrecio)
                .AddWithValue("@ComisionVendedor", esucursales.ComisionVendedor)
                .AddWithValue("@ComisionEncargado", esucursales.ComisionEncargado)
                .AddWithValue("@ComisionVendedorFeriado", esucursales.ComisionVendedorFeriado)
                .AddWithValue("@ComisionEncargadoFeriado", esucursales.ComisionEncargadoFeriado)
                .AddWithValue("@ComisionVendedorMayor", esucursales.ComisionVendedorMayor)
                .AddWithValue("@ComisionEncargadoMayor", esucursales.ComisionEncargadoMayor)
                .AddWithValue("@CodigoPostal", esucursales.Codigo_Postal)
                .AddWithValue("@Telefono", esucursales.Telefono)
                .AddWithValue("@CodigoVenta", esucursales.CodigoVenta)
                .AddWithValue("@Habilitado", esucursales.Habilitado)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()

            'desconecto la bdd
            ClsDatos.ConectarRemoto()

            'Creo las patentes de la sucursal
            Dim id_Sucursal As Integer = 0
            id_Sucursal = UltimaSucursal()
            ClsDatos.ConsultarBaseRemoto("execute sp_Sucursales_AltaPatentes @Nombre='" & esucursales.Nombre & "', @id_Sucursal=" & id_Sucursal)

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para modificar una sucursal.
    Function ModificacionSucursal(ByVal esucursales As Entidades.Sucursales) As String
        Dim cmd As New SqlCommand
        Try

            If Funciones.HayInternet Then
                cmd.Connection = ClsDatos.ConectarRemoto()
            Else
                cmd.Connection = ClsDatos.ConectarLocal()
            End If

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Sucursales_Modificacion"

            With cmd.Parameters
                .AddWithValue("@id_Sucursal", esucursales.id_Sucursal)
                .AddWithValue("@Nombre", esucursales.Nombre)
                .AddWithValue("@Direccion", esucursales.Direccion)
                .AddWithValue("@id_Provincia", esucursales.id_Provincia)
                .AddWithValue("@id_Departamento", esucursales.id_Distrito)
                .AddWithValue("@id_Localidad", esucursales.id_Localidad)
                .AddWithValue("@id_ListaGrupoPrecio", esucursales.id_ListaGrupoPrecio)
                .AddWithValue("@CodigoPostal", esucursales.Codigo_Postal)
                .AddWithValue("@ComisionVendedor", esucursales.ComisionVendedor)
                .AddWithValue("@ComisionEncargado", esucursales.ComisionEncargado)
                .AddWithValue("@ComisionVendedorFeriado", esucursales.ComisionVendedorFeriado)
                .AddWithValue("@ComisionEncargadoFeriado", esucursales.ComisionEncargadoFeriado)
                .AddWithValue("@ComisionVendedorMayor", esucursales.ComisionVendedorMayor)
                .AddWithValue("@ComisionEncargadoMayor", esucursales.ComisionEncargadoMayor)
                .AddWithValue("@Telefono", esucursales.Telefono)
                .AddWithValue("@CodigoVenta", esucursales.CodigoVenta)
                .AddWithValue("@Habilitado", esucursales.Habilitado)
            End With
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)

            cmd.ExecuteNonQuery()
            ClsDatos.DesconectarRemoto()

            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para eliminar una Sucursal.
    Function EliminarSucursal(ByVal id_Sucursal As Integer) As String
        Dim cmd As New SqlCommand
        Try

            If Funciones.HayInternet Then
                cmd.Connection = ClsDatos.ConectarRemoto()
            Else
                cmd.Connection = ClsDatos.ConectarLocal()
            End If

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Sucursales_Eliminar"
            With cmd.Parameters
                .AddWithValue("@id_Sucursal", id_Sucursal)
            End With
            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)

            cmd.ExecuteNonQuery()
            ClsDatos.DesconectarRemoto()

            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para listar todas las sucursales.
    Function ListadoSucursalesCompleto() As DataSet
        If Funciones.HayInternet Then
            Return ClsDatos.ConsultarBaseRemoto("execute sp_Sucursales_ListadoCompleto")
        Else
            Return ClsDatos.ConsultarBaseLocal("execute sp_Sucursales_ListadoCompleto")
        End If
    End Function

    'Funcion para listar todas las sucursales de un determinado empleado.
    Function ListadoSucursalesEmpleado(ByVal id_Empleado As Integer) As DataSet
        If Funciones.HayInternet Then
            Return ClsDatos.ConsultarBaseRemoto("execute sp_SucursalesEmpleado_Listado @id_Empleado=" & id_Empleado)
        Else
            Return ClsDatos.ConsultarBaseLocal("execute sp_SucursalesEmpleado_Listado @id_Empleado=" & id_Empleado)
        End If
    End Function

    'Funcion que me trae el id de la ultima sucursal
    Function UltimaSucursal() As Integer
        Dim ds As DataSet
        If (Funciones.HayInternet) Then
            ds = ClsDatos.ConsultarBaseLocal("Select IDENT_CURRENT('SUCURSALES') as id_Sucursal")
        Else
            ds = ClsDatos.ConsultarBaseLocal("Select IDENT_CURRENT('SUCURSALES')  as id_Sucursal")
        End If

        If ds.Tables(0).Rows.Count = 1 And CInt(ds.Tables(0).Rows(0).Item("id_Sucursal")) > 0 Then
            Return ds.Tables(0).Rows(0).Item("id_Sucursal").ToString
        Else
            Return 1
        End If
    End Function

End Class
