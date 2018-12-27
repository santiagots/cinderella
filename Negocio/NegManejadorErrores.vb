Imports System.Text.RegularExpressions
Public Class NegManejadorErrores
    Function SoloNumeros(ByVal Keyascii As Integer) As Integer
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii

        End Select
    End Function

    Function SoloNumerosConDecimales(ByVal Keyascii As Integer) As Integer
        If InStr("1234567890,", Chr(Keyascii)) = 0 Then
            SoloNumerosConDecimales = 0
        Else
            SoloNumerosConDecimales = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumerosConDecimales = Keyascii

        End Select
    End Function

    Function SoloNumerosConEspacio(ByVal Keyascii As Integer) As Integer
        If InStr("1234567890 ", Chr(Keyascii)) = 0 Then
            SoloNumerosConEspacio = 0
        Else
            SoloNumerosConEspacio = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumerosConEspacio = Keyascii

        End Select
    End Function
    Function SoloLetras(ByVal KeyAscii As Integer) As Integer
        KeyAscii = Asc(UCase(Chr(KeyAscii))) 'Transformar letras minusculas a Mayúsculas
        ' Intercepta un código ASCII recibido admitiendo solamente
        ' letras, además:
        ' deja pasar sin afectar si recibe tecla de Backspace o enter

        If InStr("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ ", Chr(KeyAscii)) = 0 Then
            SoloLetras = 0
        Else
            SoloLetras = KeyAscii
        End If

        ' teclas adicionales permitidas
        If KeyAscii = 8 Then SoloLetras = KeyAscii ' Backspace
        If KeyAscii = 13 Then SoloLetras = KeyAscii ' Enter
    End Function

    Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail, _
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

    Function SoloCurrency(ByVal Keyascii As Integer) As Integer
        If InStr("1234567890,", Chr(Keyascii)) = 0 Then
            SoloCurrency = 0
        Else
            SoloCurrency = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloCurrency = Keyascii

        End Select
    End Function

    Function SoloCurrencyNegative(ByVal Keyascii As Integer) As Integer
        If InStr("1234567890,-", Chr(Keyascii)) = 0 Then
            SoloCurrencyNegative = 0
        Else
            SoloCurrencyNegative = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloCurrencyNegative = Keyascii

        End Select
    End Function

    Function ValidarCuit(ByVal mk_p_nro As String) As Boolean
        Dim mk_suma As Integer
        Dim mk_valido As String
        mk_p_nro = mk_p_nro.Replace("-", "")
        If IsNumeric(mk_p_nro) Then
            If mk_p_nro.Length <> 11 Then
                mk_valido = False
            Else
                mk_suma = 0
                mk_suma += CInt(mk_p_nro.Substring(0, 1)) * 5
                mk_suma += CInt(mk_p_nro.Substring(1, 1)) * 4
                mk_suma += CInt(mk_p_nro.Substring(2, 1)) * 3
                mk_suma += CInt(mk_p_nro.Substring(3, 1)) * 2
                mk_suma += CInt(mk_p_nro.Substring(4, 1)) * 7
                mk_suma += CInt(mk_p_nro.Substring(5, 1)) * 6
                mk_suma += CInt(mk_p_nro.Substring(6, 1)) * 5
                mk_suma += CInt(mk_p_nro.Substring(7, 1)) * 4
                mk_suma += CInt(mk_p_nro.Substring(8, 1)) * 3
                mk_suma += CInt(mk_p_nro.Substring(9, 1)) * 2
                mk_suma += CInt(mk_p_nro.Substring(10, 1))
            End If

            If Math.Round(mk_suma / 11, 0) = (mk_suma / 11) Then
                mk_valido = True
            Else
                mk_valido = False
            End If
        Else
            mk_valido = False
        End If
        Return (mk_valido)
    End Function
End Class
