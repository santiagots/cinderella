Imports System.Runtime.InteropServices
Imports System.Net
Imports System.Net.NetworkInformation

Public Class Funciones
    Public Shared SistemaConConexioInternet As Boolean
    Public Shared HayInternet As Boolean

    Public Shared actualizarEstadoConexionInternet As Action(Of Boolean)

    'Public Shared Function HayConexionInternet() As Boolean
    '    Dim Url As New System.Uri("http://www.google.com")
    '    Dim peticion As System.Net.WebRequest
    '    Dim respuesta As System.Net.WebResponse

    '    If (Not sistemaConConexioInternet) Then
    '        If (actualizarEstadoConexionInternet IsNot Nothing) Then
    '            actualizarEstadoConexionInternet(False)
    '        End If
    '        Return False
    '    End If
    '    Dim sw As Stopwatch = New Stopwatch()
    '    sw.Start()

    '    Try
    '        'Creamos la peticion
    '        peticion = System.Net.WebRequest.Create(Url)

    '        'POnemos un tiempo limite
    '        peticion.Timeout = 5000

    '        'ejecutamos la peticion
    '        respuesta = peticion.GetResponse
    '        respuesta.Close()
    '        peticion = Nothing
    '        Debug.WriteLine(String.Format("Test internet OK {0}", sw.ElapsedMilliseconds))
    '        If (actualizarEstadoConexionInternet IsNot Nothing) Then
    '            actualizarEstadoConexionInternet(True)
    '        End If

    '        Return True
    '    Catch ex As Exception
    '        'si ocurre un error, devolvemos error
    '        Debug.WriteLine(String.Format("Test internet NO {0}", sw.ElapsedMilliseconds))
    '        If (actualizarEstadoConexionInternet IsNot Nothing) Then
    '            actualizarEstadoConexionInternet(False)
    '        End If

    '        peticion = Nothing
    '        Return False
    '    End Try
    'End Function

    Public Shared Function HayConexionInternet() As Boolean
        Dim sw As Stopwatch = New Stopwatch()
        sw.Start()
        'Si por configuracion se define que la aplicacion trabaja sin internet 
        If (Not SistemaConConexioInternet) Then
            'muestro el estado del MIDContenedor sin acceso a internet
            If (actualizarEstadoConexionInternet IsNot Nothing) Then
                Funciones.HayInternet = False
                actualizarEstadoConexionInternet(False)
            End If
            Return False
        End If

        If CheckForInternetConnection() Then
            'Actualizo el estado del MIDContenedor para mostrar que se tiene acceso a internet
            If (actualizarEstadoConexionInternet IsNot Nothing) Then
                actualizarEstadoConexionInternet(True)
            End If
            Debug.WriteLine(String.Format("conexion OK {0}", sw.ElapsedMilliseconds))
            Funciones.HayInternet = True
            Return True
        Else
            'Actualizo el estado del MIDContenedor para mostrar que no se tiene acceso a internet
            If (actualizarEstadoConexionInternet IsNot Nothing) Then
                actualizarEstadoConexionInternet(False)
            End If
            Debug.WriteLine(String.Format("conexion NO {0}", sw.ElapsedMilliseconds))
            Funciones.HayInternet = False
            Return False
        End If
    End Function

    Private Shared Function CheckForInternetConnection() As Boolean
        Dim sw As Stopwatch = New Stopwatch()
        sw.Start()

#If DEBUG Then
        Return True
#End If
        Try
            Dim myPing As Ping = New Ping()
            Dim host As String = "8.8.8.8"
            Dim buffer(23) As Byte
            Dim timeout As Integer = 2000
            Dim PingOptions As PingOptions = New PingOptions()
            Dim reply As PingReply = myPing.Send(host, timeout, buffer, PingOptions)
            sw.Stop()
            Debug.WriteLine("Hay internet " + sw.ElapsedMilliseconds.ToString())
            Return (reply.Status = IPStatus.Success)

        Catch ex As Exception
            sw.Stop()
            Debug.WriteLine("NO Hay internet " + sw.ElapsedMilliseconds.ToString())
            Return False
        End Try
    End Function

    'Private Shared Function CheckForInternetConnection() As Boolean
    '    Dim sw As Stopwatch = New Stopwatch()
    '    sw.Start()
    '    Try
    '        Using client = New WebClient()
    '            Using stream = client.OpenRead("http://www.google.com")
    '                sw.Stop()
    '                Debug.WriteLine("Hay internet " + sw.ElapsedMilliseconds.ToString())
    '                Return True
    '            End Using
    '        End Using
    '    Catch
    '        sw.Stop()
    '        Debug.WriteLine("NO Hay internet " + sw.ElapsedMilliseconds.ToString())
    '        Return False
    '    End Try
    'End Function

End Class

