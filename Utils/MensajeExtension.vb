Imports System.Runtime.CompilerServices
Imports FluentValidation.Results

Module LINQExtension

    ' Extension method for the IEnumerable(of T) interface.   
    ' The method accepts only values of the Double type.  
    <Extension()>
    Function Mensaje(ByVal source As IEnumerable(Of ValidationFailure)) As String
        If source.Count = 0 Then
            Return ""
        End If

        Return String.Join(Environment.NewLine, source.Select(Function(x) x.ErrorMessage).ToList())
    End Function
End Module