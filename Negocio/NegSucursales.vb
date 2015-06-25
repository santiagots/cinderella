Imports System.Data.SqlClient
Public Class NegSucursales
    Dim ClsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones
    Dim HayInternet As Boolean = ClsFunciones.GotInternet

    'Funcion para listar todas las sucursales activas.
    Function ListadoSucursales() As DataSet
        Return ClsDatos.ConsultarBaseRemoto("execute sp_Sucursales_Listado")
    End Function

    'Funcion para consultar una sucursal determinada.
    Public Function TraerSucursal(ByVal id_Sucursal As Integer)
        Dim dsSucursal As New DataSet
        Dim entSucursal As New Entidades.Sucursales
        dsSucursal = ClsDatos.ConsultarBaseRemoto("execute sp_Sucursal_Detalle @id_Sucursal=" & id_Sucursal)
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
            entSucursal.ComisionEncargado = CDbl(dsSucursal.Tables(0).Rows(0).Item("Comision_Encargado"))
            entSucursal.ComisionVendedor = CDbl(dsSucursal.Tables(0).Rows(0).Item("Comision_Vendedor"))
            entSucursal.ComisionEncargadoFeriado = CDbl(dsSucursal.Tables(0).Rows(0).Item("Comision_Encargado_Feriado"))
            entSucursal.ComisionVendedorFeriado = CDbl(dsSucursal.Tables(0).Rows(0).Item("Comision_Vendedor_Feriado"))
            entSucursal.ComisionEncargadoMayor = CDbl(dsSucursal.Tables(0).Rows(0).Item("Comision_Encargado_Mayor"))
            entSucursal.ComisionVendedorMayor = CDbl(dsSucursal.Tables(0).Rows(0).Item("Comision_Vendedor_Mayor"))
        End If
        Return entSucursal
    End Function

    'Funcion para insertar una sucursal.
    Function AltaSucursal(ByVal esucursales As Entidades.Sucursales) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            cmd.Connection = ClsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Sucursales_Alta"
            With cmd.Parameters
                .AddWithValue("@Nombre", esucursales.Nombre)
                .AddWithValue("@Direccion", esucursales.Direccion)
                .AddWithValue("@id_Provincia", esucursales.id_Provincia)
                .AddWithValue("@id_Departamento", esucursales.id_Distrito)
                .AddWithValue("@id_Localidad", esucursales.id_Localidad)
                .AddWithValue("@ComisionVendedor", esucursales.ComisionVendedor)
                .AddWithValue("@ComisionEncargado", esucursales.ComisionEncargado)
                .AddWithValue("@ComisionVendedorFeriado", esucursales.ComisionVendedorFeriado)
                .AddWithValue("@ComisionEncargadoFeriado", esucursales.ComisionEncargadoFeriado)
                .AddWithValue("@ComisionVendedorMayor", esucursales.ComisionVendedorMayor)
                .AddWithValue("@ComisionEncargadoMayor", esucursales.ComisionEncargadoMayor)
                .AddWithValue("@CodigoPostal", esucursales.Codigo_Postal)
                .AddWithValue("@Telefono", esucursales.Telefono)
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
            cmd.Connection = ClsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Sucursales_Modificacion"
            With cmd.Parameters
                .AddWithValue("@id_Sucursal", esucursales.id_Sucursal)
                .AddWithValue("@Nombre", esucursales.Nombre)
                .AddWithValue("@Direccion", esucursales.Direccion)
                .AddWithValue("@id_Provincia", esucursales.id_Provincia)
                .AddWithValue("@id_Departamento", esucursales.id_Distrito)
                .AddWithValue("@id_Localidad", esucursales.id_Localidad)
                .AddWithValue("@CodigoPostal", esucursales.Codigo_Postal)
                .AddWithValue("@ComisionVendedor", esucursales.ComisionVendedor)
                .AddWithValue("@ComisionEncargado", esucursales.ComisionEncargado)
                .AddWithValue("@ComisionVendedorFeriado", esucursales.ComisionVendedorFeriado)
                .AddWithValue("@ComisionEncargadoFeriado", esucursales.ComisionEncargadoFeriado)
                .AddWithValue("@ComisionVendedorMayor", esucursales.ComisionVendedorMayor)
                .AddWithValue("@ComisionEncargadoMayor", esucursales.ComisionEncargadoMayor)
                .AddWithValue("@Telefono", esucursales.Telefono)
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
            cmd.Connection = ClsDatos.ConectarRemoto()
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
        Return ClsDatos.ConsultarBaseRemoto("execute sp_Sucursales_ListadoCompleto")
    End Function

    'Funcion para listar todas las sucursales de un determinado empleado.
    Function ListadoSucursalesEmpleado(ByVal id_Empleado As Integer) As DataSet
        Return ClsDatos.ConsultarBaseRemoto("execute sp_SucursalesEmpleado_Listado @id_Empleado=" & id_Empleado)
    End Function

    'Funcion que me trae el id de la ultima sucursal
    Function UltimaSucursal() As Integer
        Dim ds As DataSet
        If (HayInternet) Then
            ds = ClsDatos.ConsultarBaseRemoto("Select IDENT_CURRENT('SUCURSALES') as id_Sucursal")
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
