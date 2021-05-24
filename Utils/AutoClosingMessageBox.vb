Public Class AutoClosingMessageBox
    Private _timeoutTimer As System.Threading.Timer
    Private _caption As String
    Private _result As DialogResult
    Private _timerResult As DialogResult

    Private Sub New(ByVal text As String, ByVal caption As String, ByVal timeout As Integer, ByVal Optional buttons As MessageBoxButtons = MessageBoxButtons.OK, ByVal Optional timerResult As DialogResult = DialogResult.None)
        _caption = caption
        _timeoutTimer = New System.Threading.Timer(AddressOf OnTimerElapsed, Nothing, timeout, System.Threading.Timeout.Infinite)
        _timerResult = timerResult

        Using _timeoutTimer
            _result = MessageBox.Show(text, caption, buttons)
        End Using
    End Sub

    Public Shared Function Show(ByVal text As String, ByVal caption As String, ByVal timeout As Integer, ByVal Optional buttons As MessageBoxButtons = MessageBoxButtons.OK, ByVal Optional timerResult As DialogResult = DialogResult.None) As DialogResult
        Return New AutoClosingMessageBox(text, caption, timeout, buttons, timerResult)._result
    End Function

    Private Sub OnTimerElapsed(ByVal state As Object)
        Dim mbWnd As IntPtr = FindWindow("#32770", _caption)
        If mbWnd <> IntPtr.Zero Then SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero)
        _timeoutTimer.Dispose()
        _result = _timerResult
    End Sub

    Const WM_CLOSE As Integer = &H10
    <System.Runtime.InteropServices.DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr

    End Function
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInt32, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    End Function
End Class
