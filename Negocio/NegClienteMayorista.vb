Imports Entidades
Imports System.Data.SqlClient
Imports Datos

Public Class NegClienteMayorista
    Dim objCliente As Entidades.ClienteMayorista
    Dim clsDatos As New Datos.Conexion
    Dim con As New Conexion
    Dim ClsFunciones As New Funciones

    'Funcion para consultar un cliente.
    Public Function TraerCliente(ByVal id_Cliente As Integer) As ClienteMayorista
        Dim dsCliente As New DataSet
        Dim entCliente As New Entidades.ClienteMayorista

        If (Funciones.HayInternet) Then
            dsCliente = clsDatos.ConsultarBaseRemoto("execute sp_ClienteMayorista_Detalle @id_Cliente=" & id_Cliente)
        Else
            dsCliente = clsDatos.ConsultarBaseLocal("execute sp_ClienteMayorista_Detalle @id_Cliente=" & id_Cliente)
        End If

        'Lleno la Entidad Clientes.
        If dsCliente.Tables.Count > 0 AndAlso dsCliente.Tables(0).Rows.Count > 0 Then
            entCliente = ObtenerClienteDesdeDataRow(dsCliente.Tables(0).Rows(0))
        End If

        'Retorno
        Return entCliente
    End Function

    Public Function TraerCliente(ByVal RazonSocial As String) As List(Of Entidades.ClienteMayorista)
        Dim dsCliente As New DataSet
        Dim clientes As List(Of Entidades.ClienteMayorista) = New List(Of ClienteMayorista)()

        dsCliente = clsDatos.ConsultarBaseLocal("execute sp_ClienteMayorista_Razon_Social @RazonSocial='" & RazonSocial & "'")

        'Lleno la Entidad Clientes.
        If dsCliente.Tables(0).Rows.Count <> 0 Then
            For Each cliente As DataRow In dsCliente.Tables(0).Rows
                clientes.Add(ObtenerClienteDesdeDataRow(cliente))
            Next
        End If

        'Retorno
        Return clientes
    End Function

    'Funcion para insertar un cliente.
    Sub AltaCliente(ByVal cliente As Entidades.ClienteMayorista)
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim msg As String = ""

        cmd.Connection = clsDatos.ConectarRemoto()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_ClienteMayorista_Alta"
        With cmd.Parameters
            .AddWithValue("@RazonSocial", cliente.RazonSocial)
            .AddWithValue("@Nombre", cliente.Nombre)
            .AddWithValue("@Cuit", cliente.Cuit)
            .AddWithValue("@IdCondicionIva", cliente.IdCondicionIva)
            .AddWithValue("@IdCorredor", cliente.IdCorredor)
            .AddWithValue("@Comision", cliente.Comision)
            .AddWithValue("@Transporte", cliente.Transporte)
            .AddWithValue("@Bonificacion", cliente.Bonificacion)
            .AddWithValue("@Lista", cliente.Lista)
            .AddWithValue("@CondicionPago", cliente.CondicionPago)
            .AddWithValue("@IdEmpresa", cliente.IdEmpresa)
            .AddWithValue("@IdListaPrecio", cliente.IdListaPrecio)
            .AddWithValue("@IdDireccionFacturacion", cliente.IdDireccionFacturacion)
            .AddWithValue("@IdDireccionEntrega", If(cliente.IdDireccionEntrega = 0, DBNull.Value, cliente.IdDireccionEntrega))
            .AddWithValue("@Observaciones", cliente.Observaciones)
            .AddWithValue("@Habilitado", cliente.Habilitado)
        End With

        cmd.ExecuteNonQuery()
        clsDatos.DesconectarRemoto()
    End Sub

    'Funcion para insertar un cliente.
    Function AltaClienteConsumidorFinal(ByVal ecliente As Entidades.ConsumidorFinal, ByVal idSucursal As Integer) As Int64
        'Declaro variables
        Dim cmd As New SqlCommand
        Try
            ecliente.id = clsDatos.ObtenerCalveUnica(idSucursal)
            cmd.Connection = clsDatos.ConectarLocal()
            AltaClienteConsumidorFinal(ecliente, cmd)
            clsDatos.ConectarLocal()

            If (Funciones.HayInternet) Then
                cmd = New SqlCommand()
                cmd.Connection = clsDatos.ConectarRemoto()
                AltaClienteConsumidorFinal(ecliente, cmd)
                clsDatos.ConectarRemoto()
            End If

            Return ecliente.id

        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Shared Sub AltaClienteConsumidorFinal(ecliente As ConsumidorFinal, ByRef cmd As SqlCommand)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Clientes_ConsumidorFinal_Alta"
        With cmd.Parameters
            .AddWithValue("@id", ecliente.id)
            .AddWithValue("@nombre", ecliente.Nombre)
            .AddWithValue("@apellido", ecliente.Apellido)
            .AddWithValue("@email", ecliente.Email)
        End With

        cmd.ExecuteNonQuery()
    End Sub

    Public Function ConsultaClienteConsumidorFinal(ByVal id_Cliente As Integer) As ConsumidorFinal
        Dim dsCliente As New DataSet

        If (Funciones.HayInternet) Then
            dsCliente = clsDatos.ConsultarBaseRemoto("execute sp_Clientes_ConsumidorFinal_Consulta @id_Cliente=" & id_Cliente)
        Else
            dsCliente = clsDatos.ConsultarBaseLocal("execute sp_Clientes_ConsumidorFinal_Consulta @id_Cliente=" & id_Cliente)
        End If

        Dim clienteMinorista As ConsumidorFinal = New ConsumidorFinal()

        If dsCliente.Tables(0).Rows.Count > 0 Then
            clienteMinorista.Apellido = dsCliente.Tables(0).Rows(0)("Apellido")
            clienteMinorista.Nombre = dsCliente.Tables(0).Rows(0)("Nombre")
            clienteMinorista.Email = dsCliente.Tables(0).Rows(0)("Email")
        End If

        Return clienteMinorista
    End Function

    'Funcion para modificar un cliente.
    Sub ModificacionCliente(ByVal cliente As Entidades.ClienteMayorista)
        Dim cmd As New SqlCommand
        cmd.Connection = clsDatos.ConectarRemoto()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_ClienteMayorista_Modificacion"
        With cmd.Parameters
            .AddWithValue("@id_Cliente", cliente.Id)
            .AddWithValue("@RazonSocial", cliente.RazonSocial)
            .AddWithValue("@Nombre", cliente.Nombre)
            .AddWithValue("@Cuit", cliente.Cuit)
            .AddWithValue("@IdCondicionIva", cliente.IdCondicionIva)
            .AddWithValue("@IdCorredor", cliente.IdCorredor)
            .AddWithValue("@Comision", cliente.Comision)
            .AddWithValue("@Transporte", cliente.Transporte)
            .AddWithValue("@Bonificacion", cliente.Bonificacion)
            .AddWithValue("@Lista", cliente.Lista)
            .AddWithValue("@CondicionPago", cliente.CondicionPago)
            .AddWithValue("@IdEmpresa", cliente.IdEmpresa)
            .AddWithValue("@IdListaPrecio", cliente.IdListaPrecio)
            .AddWithValue("@IdDireccionFacturacion", cliente.IdDireccionFacturacion)
            .AddWithValue("@IdDireccionEntrega", If(cliente.IdDireccionEntrega = 0, DBNull.Value, cliente.IdDireccionEntrega))
            .AddWithValue("@Observaciones", cliente.Observaciones)
            .AddWithValue("@Habilitado", cliente.Habilitado)
        End With

        cmd.ExecuteNonQuery()
            clsDatos.DesconectarRemoto()
    End Sub

    'Funcion para eliminar un cliente.
    Sub EliminarCliente(ByVal id_Cliente As Integer)
        Dim cmd As New SqlCommand
        cmd.Connection = clsDatos.ConectarRemoto()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_ClienteMayorista_Eliminar"
        With cmd.Parameters
            .AddWithValue("@id_Cliente", id_Cliente)
        End With

        cmd.ExecuteNonQuery()
        clsDatos.DesconectarRemoto()
    End Sub

    'Funcion para listar todos los clientes activos.
    Function ListadoClientes() As List(Of Entidades.ClienteMayorista)

        Dim ds As DataSet = New DataSet
        Dim clientes As List(Of Entidades.ClienteMayorista) = New List(Of Entidades.ClienteMayorista)

        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_ClienteMayorista_Listado")
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_ClienteMayorista_Listado")
        End If

        If (ds.Tables.Count > 0) Then

            For Each row As DataRow In ds.Tables(0).Rows
                clientes.Add(ObtenerClienteDesdeDataRow(row))
            Next

        End If
        Return clientes
    End Function

    Private Function ObtenerClienteDesdeDataRow(row As DataRow) As ClienteMayorista
        Dim cliente As ClienteMayorista = New ClienteMayorista()
        With cliente
            .Bonificacion = row("Bonificacion")
            .Comision = row("Comision")
            .CondicionPago = row("CondicionPago")
            .Cuit = row("Cuit")
            .Habilitado = row("Habilitado")
            .Id = row("id_Cliente")
            .IdCondicionIva = row("id_CondicionIva")
            .IdCorredor = row("Id_Corredor")
            .IdDireccionEntrega = If(row("id_DireccionEntrega") Is DBNull.Value, 0, row("id_DireccionEntrega"))
            .IdDireccionFacturacion = row("id_DireccionFacturacion")
            .IdEmpresa = row("id_Empresa")
            .IdListaPrecio = row("id_ListaPrecio")
            .Lista = row("Lista")
            .Nombre = row("Nombre")
            .Observaciones = row("Observaciones")
            .RazonSocial = row("RazonSocial")
            .SaldoCuentaCorriente = 0
            .SaldoNotaPedido = row("SaldoNotaPedido")
            .Transporte = row("Transporte")
        End With
        Return cliente
    End Function
End Class
