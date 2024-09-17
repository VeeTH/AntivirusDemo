Imports AntivirusDemo.GlobalVariables

Public Class GlobalFunctions
    Shared Function PageCtrlChange()
        If currentPage = "home" Then
            Form1.CtlHome1.BringToFront()
        ElseIf currentPage = "protection" Then
            Form1.CtlProtection1.BringToFront()
        ElseIf currentPage = "privacy" Then
            ' code here
        ElseIf currentPage = "results" Then
            ' code here
        ElseIf currentPage = "settings" Then
            ' code here
        End If
    End Function
End Class
