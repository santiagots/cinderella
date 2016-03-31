Imports Entidades
Imports System.Data.SqlClient
Imports Datos

Public Class NegClientes
    Dim objCliente As Entidades.Clientes
    Dim clsDatos As New Datos.Conexion
    Dim con As New Conexion
    Dim ClsFunciones As New Funciones
    Dim HayInternet As Boolean = ClsFunciones.GotInternet

    'Funcion para consultar un cliente.
    Public Function TraerCliente(ByVal id_Cliente As Integer)
        Dim dsCliente As New DataSet
        Dim entCliente As New Entidades.Clientes

        If (HayInternet) Then
            dsCliente = clsDatos.ConsultarBaseRemoto("execute sp_Clientes_Detalle @id_Cliente=" & id_Cliente)
        Else
            dsCliente = clsDatos.ConsultarBaseLocal("execute sp_Clientes_Detalle @id_Cliente=" & id_Cliente)
        End If

        'Lleno la Entidad Clientes.
        If dsCliente.Tables(0).Rows.Count <> 0 Then
            entCliente.Codigo_Postal = dsCliente.Tables(0).Rows(0).Item("CodigoPostal").ToString
            entCliente.Contacto = dsCliente.Tables(0).Rows(0).Item("Contacto").ToString
            entCliente.Cuit = dsCliente.Tables(0).Rows(0).Item("Cuit").ToString
            entCliente.Direccion = dsCliente.Tables(0).Rows(0).Item("Direccion").ToString
            entCliente.Habilitado = dsCliente.Tables(0).Rows(0).Item("Habilitado").ToString
            entCliente.id_Cliente = dsCliente.Tables(0).Rows(0).Item("id_Cliente").ToString
            entCliente.id_CondicionIva = dsCliente.Tables(0).Rows(0).Item("id_CondicionIva").ToString
            entCliente.id_Distrito = dsCliente.Tables(0).Rows(0).Item("id_Departamento").ToString
            entCliente.id_Localidad = dsCliente.Tables(0).Rows(0).Item("id_Localidad").ToString
            entCliente.id_Precio = dsCliente.Tables(0).Rows(0).Item("id_ListaPrecio").ToString
            entCliente.id_Provincia = dsCliente.Tables(0).Rows(0).Item("id_Provincia").ToString
            entCliente.Mail = dsCliente.Tables(0).Rows(0).Item("Mail").ToString
            entCliente.Observaciones = dsCliente.Tables(0).Rows(0).Item("Observaciones").ToString
            entCliente.RazonSocial = dsCliente.Tables(0).Rows(0).Item("RazonSocial").ToString
            entCliente.Telefono = dsCliente.Tables(0).Rows(0).Item("Telefono").ToString
            entCliente.Transporte = dsCliente.Tables(0).Rows(0).Item("Transporte").ToString
        End If

        'Retorno
        Return entCliente
    End Function

    Public Function TraerCliente(ByVal RazonSocial As String) As List(Of Entidades.Clientes)
        Dim dsCliente As New DataSet
        Dim clientes As List(Of Entidades.Clientes) = New List(Of Clientes)()

        If (HayInternet) Then
            dsCliente = clsDatos.ConsultarBaseRemoto("execute sp_Clientes_Razon_Social @RazonSocial='" & RazonSocial & "'")
        Else
            dsCliente = clsDatos.ConsultarBaseLocal("execute sp_Clientes_Razon_Social @RazonSocial='" & RazonSocial & "'")
        End If

        'Lleno la Entidad Clientes.
        If dsCliente.Tables(0).Rows.Count <> 0 Then
            For Each cliente As DataRow In dsCliente.Tables(0).Rows
                Dim entCliente As Entidades.Clientes = New Clientes()
                entCliente.Codigo_Postal = cliente.Item("CodigoPostal").ToString
                entCliente.Contacto = cliente.Item("Contacto").ToString
                entCliente.Cuit = cliente.Item("Cuit").ToString
                entCliente.Direccion = cliente.Item("Direccion").ToString
                entCliente.Habilitado = cliente.Item("Habilitado").ToString
                entCliente.id_Cliente = cliente.Item("id_Cliente").ToString
                entCliente.id_CondicionIva = cliente.Item("id_CondicionIva").ToString
                entCliente.id_Distrito = cliente.Item("id_Departamento").ToString
                entCliente.id_Localidad = cliente.Item("id_Localidad").ToString
                entCliente.id_Precio = cliente.Item("id_ListaPrecio").ToString
                entCliente.id_Provincia = cliente.Item("id_Provincia").ToString
                entCliente.Mail = cliente.Item("Mail").ToString
                entCliente.Observaciones = cliente.Item("Observaciones").ToString
                entCliente.RazonSocial = cliente.Item("RazonSocial").ToString
                entCliente.Telefono = cliente.Item("Telefono").ToString
                entCliente.Transporte = cliente.Item("Transporte").ToString

                clientes.Add(entCliente)
            Next
        End If

        'Retorno
        Return clientes
    End Function

    'Funcion para consultar un cliente reducido. Solo trae razon, cuit, condicion y lista de precio
    Public Function TraerClienteReducido(ByVal id_Cliente As Integer)
        Dim dsCliente As New DataSet

        If (HayInternet) Then
            dsCliente = clsDatos.ConsultarBaseRemoto("execute sp_Clientes_DetalleReducido @id_Cliente=" & id_Cliente)
        Else
            dsCliente = clsDatos.ConsultarBaseLocal("execute sp_Clientes_DetalleReducido @id_Cliente=" & id_Cliente)
        End If

        If dsCliente.Tables(0).Rows.Count > 0 Then
            Return dsCliente
        Else
            Return Nothing
        End If
    End Function

    'Funcion para insertar un cliente.
    Function AltaCliente(ByVal eclientes As Entidades.Clientes) As String
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try            
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Clientes_Alta"
            With cmd.Parameters
                .AddWithValue("@id_ListaPrecio", eclientes.id_Precio)
                .AddWithValue("@id_CondicionIva", eclientes.id_CondicionIva)
                .AddWithValue("@RazonSocial", eclientes.RazonSocial)
                .AddWithValue("@Contacto", eclientes.Contacto)
                .AddWithValue("@Cuit", eclientes.Cuit)
                .AddWithValue("@Transporte", eclientes.Transporte)
                .AddWithValue("@Direccion", eclientes.Direccion)
                .AddWithValue("@id_Provincia", eclientes.id_Provincia)
                .AddWithValue("@id_Departamento", eclientes.id_Distrito)
                .AddWithValue("@id_Localidad", eclientes.id_Localidad)
                .AddWithValue("@CodigoPostal", eclientes.Codigo_Postal)
                .AddWithValue("@Telefono", eclientes.Telefono)
                .AddWithValue("@Mail", eclientes.Mail)
                .AddWithValue("@Observaciones", eclientes.Observaciones)
                .AddWithValue("@Habilitado", eclientes.Habilitado)
            End With

            Dim respuesta As New SqlParameter("@msg", SqlDbType.VarChar, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()
            'desconecto la bdd
            clsDatos.ConectarRemoto()

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para insertar un cliente.
    Function AltaClienteConsumidorFinal(ByVal ecliente As Entidades.ConsumidorFinal) As Integer
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Clientes_ConsumidorFinal_Alta"
            With cmd.Parameters
                .AddWithValue("@nombre", ecliente.Nombre)
                .AddWithValue("@apellido", ecliente.Apellido)
                .AddWithValue("@email", ecliente.Email)
            End With

            Dim respuesta As New SqlParameter("@id", SqlDbType.Int, 255)
            respuesta.Direction = ParameterDirection.Output
            cmd.Parameters.Add(respuesta)
            cmd.ExecuteNonQuery()
            'desconecto la bdd
            clsDatos.ConectarRemoto()

            'muestro el mensaje
            Return respuesta.Value
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    'Funcion para modificar un cliente.
    Function ModificacionCliente(ByVal eclientes As Entidades.Clientes) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Clientes_Modificacion"
            With cmd.Parameters
                .AddWithValue("@id_Cliente", eclientes.id_Cliente)
                .AddWithValue("@id_ListaPrecio", eclientes.id_Precio)
                .AddWithValue("@id_CondicionIva", eclientes.id_CondicionIva)
                .AddWithValue("@RazonSocial", eclientes.RazonSocial)
                .AddWithValue("@Contacto", eclientes.Contacto)
                .AddWithValue("@Cuit", eclientes.Cuit)
                .AddWithValue("@Transporte", eclientes.Transporte)
                .AddWithValue("@Direccion", eclientes.Direccion)
                .AddWithValue("@id_Provincia", eclientes.id_Provincia)
                .AddWithValue("@id_Departamento", eclientes.id_Distrito)
                .AddWithValue("@id_Localidad", eclientes.id_Localidad)
                .AddWithValue("@CodigoPostal", eclientes.Codigo_Postal)
                .AddWithValue("@Telefono", eclientes.Telefono)
                .AddWithValue("@Mail", eclientes.Mail)
                .AddWithValue("@Observaciones", eclientes.Observaciones)
                .AddWithValue("@Habilitado", eclientes.Habilitado)
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

    'Funcion para eliminar un cliente.
    Function EliminarCliente(ByVal id_Cliente As Integer) As String
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = clsDatos.ConectarRemoto()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Clientes_Eliminar"
            With cmd.Parameters
                .AddWithValue("@id_Cliente", id_Cliente)
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

    'Funcion para listar todos los clientes activos.
    Function ListadoClientes() As DataSet
        If HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Clientes_Listado")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Clientes_Listado")
        End If
    End Function

    'Funcion para listar todos los clientes.
    Function ListadoClientesCompleto() As DataSet
        If HayInternet Then
            Return clsDatos.ConsultarBaseRemoto("execute sp_Clientes_ListadoCompleto")
        Else
            Return clsDatos.ConsultarBaseLocal("execute sp_Clientes_ListadoCompleto")
        End If
    End Function

End Class
