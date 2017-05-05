Imports Entidades
Imports System.Data.SqlClient
Imports Datos

Public Class NegBanco

    'Funcion que inserta un nuevo registro en la tabla BANCO.
    Public Shared Function AltaModificacionCheque(ByVal banco As Entidades.Banco) As String
        'Declaro variables
        Dim cmd As SqlCommand = New SqlCommand()
        Dim ClsFunciones As New Funciones
        Dim clsDatos As New Datos.Conexion
        Dim HayInternet As Boolean = Funciones.HayInternet
        Dim msg As String = ""

        Try
            'Conecto a la bdd.
            If HayInternet Then
                cmd.Connection = clsDatos.ConectarRemoto()
            Else
                cmd.Connection = clsDatos.ConectarLocal()
            End If

            'Cargo y ejecuto el stored.
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "sp_Banco_AltaModificacion"
            With cmd.Parameters
                .AddWithValue("@BancoId", banco.BancoId)
                .AddWithValue("@Nombre", banco.Nombre)
                .AddWithValue("@Habilitado", banco.Habilitado)
            End With

            'Respuesta del stored.
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

            'retorno valor
            Return respuesta.Value
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function TraerBancos() As List(Of Banco)
        'Declaro variables
        Dim cmd As SqlCommand = New SqlCommand()
        Dim ClsFunciones As New Funciones
        Dim clsDatos As New Datos.Conexion
        Dim msg As String = ""
        Dim dsBancos As DataSet
        Dim respuesta As List(Of Banco) = New List(Of Banco)()

        'Conecto a la bdd.
        If (Funciones.HayInternet) Then
            dsBancos = clsDatos.ConsultarBaseRemoto("execute sp_Banco_Listado")
        Else
            dsBancos = clsDatos.ConsultarBaseLocal("execute sp_Banco_Listado")
        End If

        If dsBancos.Tables(0).Rows.Count > 0 Then
            For Each row As DataRow In dsBancos.Tables(0).Rows
                respuesta.Add(GetBancoFromRow(row))
            Next
        End If

        'retorno valor
        Return respuesta
    End Function

    Private Shared Function GetBancoFromRow(row As DataRow) As Banco
        Dim banco As Banco = New Banco
        banco.BancoId = row.Item("BancoId").ToString
        banco.Habilitado = row.Item("Habilitado").ToString
        banco.Nombre = row.Item("Nombre").ToString
        Return banco
    End Function
End Class
