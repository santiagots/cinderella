Imports Entidades
Imports System.Data.SqlClient
Imports Datos
Public Class NegSincronizacion
    Dim objUsuario As Entidades.Usuario
    Dim clsDatos As New Datos.Conexion
    Dim con As New Conexion
    Dim negFunciones As New Negocio.Funciones
    Private CadenaConexion As String
    Dim miconexion As SqlConnection
    Dim miconexionRemoto As SqlConnection
    Dim encripta As New ClsEncriptacion


    Public Function ProbarConectarLocal()
        Dim estado As Boolean
        estado = False
        Try
            CadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.Conexion").ToString
            miconexion = New SqlConnection
            miconexion.ConnectionString = CadenaConexion
            miconexion.Open()
            estado = True
            miconexion.Dispose()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error conectando con la base de datos local." & ex.Message)
        End Try
        Return estado
    End Function

    Public Function ProbarConectarRemoto()
        Dim estado As Boolean
        estado = False
        Try
            CadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.ConexionRemoto").ToString
            miconexionRemoto = New SqlConnection
            miconexionRemoto.ConnectionString = encripta.DesencriptarMD5(CadenaConexion)
            miconexionRemoto.Open()
            estado = True
            miconexionRemoto.Dispose()
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Error conectando con la base de datos remota." & ex.Message)
        End Try
        Return estado
    End Function

    Public Function Sincronizar(ByVal Tabla As String) As Integer
        Dim estado As Integer = 0
        Dim reader As SqlDataReader

        Try
            'conexion remota
            CadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.ConexionRemoto").ToString
            miconexionRemoto = New SqlConnection
            miconexionRemoto.ConnectionString = encripta.DesencriptarMD5(CadenaConexion)
            miconexionRemoto.Open()

            'conexion local
            CadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings("SistemaCinderella.My.MySettings.Conexion").ToString
            miconexion = New SqlConnection
            miconexion.ConnectionString = CadenaConexion
            miconexion.Open()

            Dim transaccion As SqlTransaction
            transaccion = miconexion.BeginTransaction()

            ' obtengo los datos a copiar.
            Dim commandSourceData As SqlCommand = New SqlCommand("SELECT * FROM " + Tabla, miconexionRemoto)
            reader = commandSourceData.ExecuteReader

            If (reader.HasRows) Then
                'elimino los datos locales: "la gente esta muy loca jonhy"
                Dim commandEliminoData As SqlCommand = New SqlCommand("DELETE  FROM " + Tabla, miconexion, transaccion)
                commandEliminoData.ExecuteNonQuery()

                'copio los datos a base local
                Dim BulkCopy As New SqlBulkCopy(miconexion, SqlBulkCopyOptions.KeepIdentity, transaccion)
                BulkCopy.DestinationTableName = Tabla

                Try
                    BulkCopy.WriteToServer(reader)
                    transaccion.Commit()
                    BulkCopy.Close()
                    estado = 1
                Catch ex As Exception
                    transaccion.Rollback()
                    BulkCopy.Close()
                Finally
                    reader.Close()
                End Try
            Else
                estado = 2
                reader.Close()
            End If

        Catch ex As Exception
            Windows.Forms.MessageBox.Show("Se produjo un error sincronizando los datos de " & Tabla & ": " & ex.Message, "Actualizacion fallida")
            miconexion.Dispose()
            miconexionRemoto.Dispose()

        Finally
            miconexion.Dispose()
            miconexionRemoto.Dispose()
        End Try

        Return estado
    End Function

End Class
