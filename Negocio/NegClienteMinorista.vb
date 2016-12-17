Imports System.Data.SqlClient

Public Class NegClienteMinorista

    Dim clsDatos As New Datos.Conexion

    Public Function CrearCliente(clienteMinorista As Entidades.ClienteMinorista) As Integer
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim IdCliente As Integer = 0

        cmd.Connection = clsDatos.ConectarLocal()
        IdCliente = CrearCliente(clienteMinorista, cmd)
        clsDatos.DesconectarLocal()

        If HayInternet Then
            cmd = New SqlCommand()
            cmd.Connection = clsDatos.ConectarRemoto()
            IdCliente = CrearCliente(clienteMinorista, cmd)
            clsDatos.DesconectarRemoto()
        End If

        Return IdCliente
    End Function

    Public Function CrearCliente(clienteMinorista As Entidades.ClienteMinorista, ByRef cmd As SqlCommand) As Integer
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_ClienteMinorista_Alta"
        With cmd.Parameters
            .AddWithValue("@Apellido", clienteMinorista.Apellido)
            .AddWithValue("@Nombre", clienteMinorista.Nombre)
            .AddWithValue("@Telefono", clienteMinorista.Telefono)
            .AddWithValue("@Email", clienteMinorista.Email)
            .AddWithValue("@EnviarNovedades", clienteMinorista.EnviarNovedades)
            .AddWithValue("@Direccion", clienteMinorista.Direccion)
        End With

        Dim respuesta As New SqlParameter("@id_ClienteMinorista", SqlDbType.Int)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)

        cmd.ExecuteNonQuery()

        Return respuesta.Value
    End Function

    Public Sub ModificarCliente(clienteMinorista As Entidades.ClienteMinorista)
        'Declaro variables
        Dim cmd As New SqlCommand
        Dim HayInternet As Boolean = Funciones.HayInternet

        cmd.Connection = clsDatos.ConectarLocal()
        ModificarCliente(clienteMinorista, cmd)
        clsDatos.DesconectarLocal()

        If HayInternet Then
            cmd = New SqlCommand()
            cmd.Connection = clsDatos.ConectarRemoto()
            ModificarCliente(clienteMinorista, cmd)
            clsDatos.DesconectarRemoto()
        End If
    End Sub

    Public Sub ModificarCliente(clienteMinorista As Entidades.ClienteMinorista, ByRef cmd As SqlCommand)
        'Cargo y ejecuto el stored.
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_ClienteMinorista_Modificar"
        With cmd.Parameters
            .AddWithValue("@Id_ClienteMinorista", clienteMinorista.Id)
            .AddWithValue("@Apellido", clienteMinorista.Apellido)
            .AddWithValue("@Nombre", clienteMinorista.Nombre)
            .AddWithValue("@Telefono", clienteMinorista.Telefono)
            .AddWithValue("@Email", clienteMinorista.Email)
            .AddWithValue("@EnviarNovedades", clienteMinorista.EnviarNovedades)
            .AddWithValue("@Direccion", clienteMinorista.Direccion)
        End With

        cmd.ExecuteNonQuery()
    End Sub

    Public Function TraerCliente() As IList(Of Entidades.ClienteMinorista)
        Dim dsCliente As New DataSet

        If (Funciones.HayInternet) Then
            dsCliente = clsDatos.ConsultarBaseRemoto("execute sp_ClienteMinorista_Obtener")
        Else
            dsCliente = clsDatos.ConsultarBaseLocal("execute sp_ClienteMinorista_Obtener")
        End If
        If (dsCliente.Tables.Count > 0) Then
            Return ObtenerClienteMinorista(dsCliente.Tables(0))
        Else
            Return New List(Of Entidades.ClienteMinorista)
        End If
    End Function

    Public Function TraerCliente(idCliente As Integer) As Entidades.ClienteMinorista
        Dim dsCliente As New DataSet

        If (Funciones.HayInternet) Then
            dsCliente = clsDatos.ConsultarBaseRemoto("execute sp_ClienteMinorista_Detalle @Id_ClienteMinorista=" & idCliente)
        Else
            dsCliente = clsDatos.ConsultarBaseLocal("execute sp_ClienteMinorista_Detalle @Id_ClienteMinorista=" & idCliente)
        End If
        If (dsCliente.Tables.Count > 0 AndAlso dsCliente.Tables(0).Rows.Count > 0) Then
            Return ObtenerClienteMinorista(dsCliente.Tables(0).Rows(0))
        Else
            Return New Entidades.ClienteMinorista()
        End If
    End Function

    Private Function ObtenerClienteMinorista(clienteMinoristaTable As DataTable) As IList(Of Entidades.ClienteMinorista)

        Dim Resultado As IList(Of Entidades.ClienteMinorista) = New List(Of Entidades.ClienteMinorista)()

        For Each row As DataRow In clienteMinoristaTable.Rows
            Dim clienteMinoristas As Entidades.ClienteMinorista = ObtenerClienteMinorista(row)

            Resultado.Add(clienteMinoristas)
        Next

        Return Resultado
    End Function

    Private Shared Function ObtenerClienteMinorista(row As DataRow) As Entidades.ClienteMinorista
        Dim clienteMinoristas As Entidades.ClienteMinorista = New Entidades.ClienteMinorista()
        clienteMinoristas.Id = row("Id_ClienteMinorista")
        clienteMinoristas.Apellido = row("Apellido")
        clienteMinoristas.Nombre = row("Nombre")
        clienteMinoristas.Telefono = row("Telefono")
        clienteMinoristas.Email = row("Email")
        clienteMinoristas.EnviarNovedades = row("EnviarNovedades")
        clienteMinoristas.Direccion = row("Direccion")
        Return clienteMinoristas
    End Function
End Class

