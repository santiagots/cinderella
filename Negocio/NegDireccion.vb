Imports System.Data.SqlClient
Imports Entidades

Public Class NegDireccion
    Dim clsDatos As New Datos.Conexion
    Dim ClsFunciones As New Funciones

    Function Consulta(ByVal id_Direccion As Integer) As Direccion
        Dim ds As DataSet = New DataSet

        If Funciones.HayInternet Then
            ds = clsDatos.ConsultarBaseRemoto("execute sp_Direccion_Consultar @id_Direccion = " & id_Direccion)
        Else
            ds = clsDatos.ConsultarBaseLocal("execute sp_Direccion_Consultar @id_Direccion = " & id_Direccion)
        End If

        If (ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0) Then
            Return ObtenerDireccionDesdeDataRow(ds.Tables(0).Rows(0))
        Else
            Return New Direccion()
        End If
    End Function

    Function Alta(ByVal direccion As Direccion) As Integer
        Dim cmd As New SqlCommand

        If Funciones.HayInternet Then
            cmd.Connection = clsDatos.ConectarRemoto()
        Else
            cmd.Connection = clsDatos.ConectarLocal()
        End If

        cmd.Connection = clsDatos.ConectarRemoto()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Direccion_Alta"
        With cmd.Parameters
            .AddWithValue("@Direccion", direccion.Direccion)
            .AddWithValue("@IdProvincia", direccion.IdProvincia)
            .AddWithValue("@IdDistrito", direccion.IdDistito)
            .AddWithValue("@IdLocalidad", direccion.IdLocalidad)
            .AddWithValue("@CodigoPostal", direccion.CodigoPostal)
            .AddWithValue("@Telefono", direccion.Telefono)
            .AddWithValue("@Email", direccion.Email)
        End With

        Dim respuesta As New SqlParameter("@id_Direccion", SqlDbType.Int)
        respuesta.Direction = ParameterDirection.Output
        cmd.Parameters.Add(respuesta)

        cmd.ExecuteNonQuery()
        cmd.Connection.Close()

        Return respuesta.Value
    End Function

    Sub Modificacion(ByVal direccion As Direccion)
        Dim cmd As New SqlCommand

        If Funciones.HayInternet Then
            cmd.Connection = clsDatos.ConectarRemoto()
        Else
            cmd.Connection = clsDatos.ConectarLocal()
        End If

        cmd.Connection = clsDatos.ConectarRemoto()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Direccion_Actualizar"
        With cmd.Parameters
            .AddWithValue("@id_Direccion", direccion.Id)
            .AddWithValue("@Direccion", direccion.Direccion)
            .AddWithValue("@IdProvincia", direccion.IdProvincia)
            .AddWithValue("@IdDistrito", direccion.IdDistito)
            .AddWithValue("@IdLocalidad", direccion.IdLocalidad)
            .AddWithValue("@CodigoPostal", direccion.CodigoPostal)
            .AddWithValue("@Telefono", direccion.Telefono)
            .AddWithValue("@Email", direccion.Email)
        End With

        cmd.ExecuteNonQuery()

        cmd.ExecuteNonQuery()
    End Sub

    Sub Eliminar(ByVal id_direccion As Integer)
        Dim cmd As New SqlCommand

        If Funciones.HayInternet Then
            cmd.Connection = clsDatos.ConectarRemoto()
        Else
            cmd.Connection = clsDatos.ConectarLocal()
        End If

        cmd.Connection = clsDatos.ConectarRemoto()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_Direccion_Eliminar"
        With cmd.Parameters
            .AddWithValue("@id_Direccion", id_direccion)
        End With

        cmd.ExecuteNonQuery()

        cmd.ExecuteNonQuery()
    End Sub

    Private Function ObtenerDireccionDesdeDataRow(row As DataRow) As Direccion
        Dim direccion As Direccion = New Direccion()
        With direccion
            .CodigoPostal = row("CodigoPostal")
            .Direccion = row("Direccion")
            .Email = row("Mail")
            .Id = Long.Parse(row("id_Direccion"))
            .IdDistito = row("id_Distrito")
            .IdLocalidad = row("id_Localidad")
            .IdProvincia = row("id_Provincia")
            .Telefono = row("Telefono")
        End With
        Return direccion
    End Function
End Class
