Imports System.Runtime.InteropServices
Imports System.Net
Imports System.Net.NetworkInformation

Public Class Funciones
    Public Shared SistemaConConexioInternet As Boolean
    Public Shared HayInternet As Boolean
    Public Shared Ip As String
    Public Shared TimeOut As Integer

    Public Shared ActualizarEstadoConexionInternet As Action(Of Boolean)

    Public Shared Function HayConexionInternet() As Boolean

        'Si por configuracion se define que la aplicacion trabaja sin internet 
        If (Not SistemaConConexioInternet) Then
            'muestro el estado del MIDContenedor sin acceso a internet
            If (ActualizarEstadoConexionInternet IsNot Nothing) Then
                Funciones.HayInternet = False
                ActualizarEstadoConexionInternet(False)
            End If
            Return False
        End If

        If CheckForInternetConnection() AndAlso Datos.Conexion.EstaDisponible(Datos.Conexion.STRING_CONEXION_BASE_REMOTA, True) Then
            'Actualizo el estado del MIDContenedor para mostrar que se tiene acceso a internet
            If (ActualizarEstadoConexionInternet IsNot Nothing) Then
                ActualizarEstadoConexionInternet(True)
            End If
            Funciones.HayInternet = True
            Return True
        Else
            'Actualizo el estado del MIDContenedor para mostrar que no se tiene acceso a internet
            If (ActualizarEstadoConexionInternet IsNot Nothing) Then
                ActualizarEstadoConexionInternet(False)
            End If
            Funciones.HayInternet = False
            Return False
        End If


    End Function

    Private Shared Function CheckForInternetConnection() As Boolean
        Dim sw As Stopwatch = New Stopwatch()
        sw.Start()
        Try
            Dim myPing As Ping = New Ping()
            Dim buffer(23) As Byte
            Dim PingOptions As PingOptions = New PingOptions()
            Dim reply As PingReply = myPing.Send(Ip, TimeOut, buffer, PingOptions)
            sw.Stop()
            Debug.WriteLine("Hay internet " + sw.ElapsedMilliseconds.ToString())
            Return (reply.Status = IPStatus.Success)

        Catch ex As Exception
            sw.Stop()
            Debug.WriteLine("NO Hay internet " + sw.ElapsedMilliseconds.ToString())
            Return False
        End Try
    End Function
End Class

