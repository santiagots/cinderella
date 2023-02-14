Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO
Imports System.Text
Imports Common.Core.Helper
Imports Microsoft.SqlServer.Management.Common
Imports Microsoft.SqlServer.Management.Smo

Public Class ConfigurarBaseDatos

    Public Shared Sub Iniciar(nombreAplicacion As String, rutaEjecucionAplicacion As String)
        Dim rutaAppData As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        Dim rutaDestinoBaseDatos As String = Path.Combine(rutaAppData, nombreAplicacion)

        'Verifico si se deployo por red y si es la primera ejecucion por instalacion o actualizacion
        If (ApplicationDeployment.IsNetworkDeployed AndAlso ApplicationDeployment.CurrentDeployment.IsFirstRun) Then
            'Copio la base de datos a una carpeta segura

            InstalarBaseDatos(rutaDestinoBaseDatos, rutaEjecucionAplicacion, New String() {"CINDERELLA_LOCAL.mdf", "CINDERELLA_LOCAL_log.ldf"})
            DefinirDataDirectory(rutaDestinoBaseDatos)
            ActualizarBaseDatos(rutaEjecucionAplicacion)
        Else
            DefinirDataDirectory(rutaDestinoBaseDatos)
        End If

    End Sub

    Private Shared Sub InstalarBaseDatos(rutaDestinoBaseDatos As String, rutaEjecucionAplicacion As String, nombresArchivos As String())

        If Not Directory.Exists(rutaDestinoBaseDatos) Then
            Directory.CreateDirectory(rutaDestinoBaseDatos)
        End If

        For Each nombreArchivo As String In nombresArchivos
            Dim rutaOrigen As String = Path.Combine(rutaEjecucionAplicacion, nombreArchivo)
            Dim rutaDestino As String = Path.Combine(rutaDestinoBaseDatos, nombreArchivo)
            If (Not File.Exists(rutaDestino)) Then
                File.Copy(rutaOrigen, rutaDestino)
            End If
        Next
    End Sub

    Private Shared Sub DefinirDataDirectory(rutaDestinoBaseDatos As String)
        AppDomain.CurrentDomain.SetData("DataDirectory", rutaDestinoBaseDatos)
    End Sub

    Private Shared Sub ActualizarBaseDatos(rutaEjecucionAplicacion As String)
        Try
            Dim scriptFiles As String() = Directory.GetFiles(Path.Combine(rutaEjecucionAplicacion, "Script"), "*.sql")
            Dim conexion As Conexion = New Conexion()

            For Each scriptFile As String In scriptFiles
                Dim script As String = File.ReadAllText(scriptFile, Encoding.GetEncoding("iso-8859-1"))

                Log.Info("Base local" + Conexion.STRING_CONEXION_BASE_LOCAL)
                Log.Info("Base remota" + Conexion.STRING_CONEXION_BASE_LOCAL)
                Log.Info("--SCRIPT--")
                Log.Info(script)


                Dim conn As SqlConnection = conexion.ConectarLocal()
                Dim server As Server = New Server(New ServerConnection(conn))
                server.ConnectionContext.ExecuteNonQuery(script)
                conexion.DesconectarLocal()
            Next
        Catch ex As Exception
            Log.Error(ex)
            Throw
        End Try
    End Sub

End Class
