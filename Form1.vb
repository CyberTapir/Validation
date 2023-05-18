Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstDebug.Items.Add(ValidateInteger("hello17world", 0, 20, 5))
    End Sub
    Public Function ValidateInteger(ByVal InputString As String, ByVal Min As Integer, ByVal Max As Integer, ByVal DefaultVal As Integer) As Integer
        Dim StringInteger As String, TempChar As String
        Dim Counter As Integer, IsADigit As Boolean

        StringInteger = ""

        'Consider each character in turn
        'If it is a digit then add it to StringInteger
        For Counter = 1 To Len(InputString)
            TempChar = Mid$(InputString, Counter, 1)
            'The ASCII code for the 10 digits range from 48 to 57
            IsADigit = Asc(TempChar) > 47 And Asc(TempChar) < 58
            If IsADigit Then
                StringInteger = StringInteger & TempChar
            End If
        Next Counter
        ValidateInteger = Val(StringInteger)

        'Check for at least some digits and that number is within the required range
        If StringInteger = "" Or ValidateInteger < Min Or ValidateInteger > Max Then
            ValidateInteger = DefaultVal
            'MsgBox("A number from " & Min & " to " & Max & " is required.")
        End If
        Return ValidateInteger
    End Function

End Class
