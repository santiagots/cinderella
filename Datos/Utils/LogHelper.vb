Imports System.IO

Public Class LogHelper

    Public Shared Sub WriteLog(message As String)
        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        Using outputFile As New StreamWriter(mydocpath & Convert.ToString("\Log.txt"), True)
            outputFile.WriteLine("INICIO---------------------------------------------")
            outputFile.WriteLine(DateTime.Now.ToString() + " " + message)
            outputFile.WriteLine("FIN---------------------------------------------" + Environment.NewLine + Environment.NewLine)
        End Using
    End Sub

End Class
