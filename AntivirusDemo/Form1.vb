Imports System.Diagnostics
Imports AntivirusDemo.GlobalVariables
Imports AntivirusDemo.GlobalFunctions

Public Class Form1
    Private MouseIsDown As Boolean = False
    Private MouseIsDownLoc As Point = Nothing
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove

        If e.Button = MouseButtons.Left Then
            If MouseIsDown = False Then
                MouseIsDown = True
                MouseIsDownLoc = New Point(e.X, e.Y)
            End If

            Me.Location = New Point(Me.Location.X + e.X - MouseIsDownLoc.X, Me.Location.Y + e.Y - MouseIsDownLoc.Y)
        End If
    End Sub
    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        MouseIsDown = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles SettingsBtn.Click, ResultsBtn.Click, PrivacyBtn.Click, ProtectionBtn.Click, HomeBtn.Click
        For Each btnArray As Button In Panel2.Controls.OfType(Of Button)()
            btnArray.BackColor = Color.FromArgb(46, 53, 77)
        Next

        btn = DirectCast(sender, Button)
        btn.BackColor = Color.FromArgb(15, 17, 25)

        clickedBtn = btn.Tag
        currentPage = clickedBtn
        ' Debug.Print(clickedBtn)

        Call PageCtrlChange()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim URL As String = "http://www.CodeProject.Com"
        Dim NewProcess As Diagnostics.ProcessStartInfo = New Diagnostics.ProcessStartInfo(URL)
        NewProcess.UseShellExecute = True
        Process.Start(NewProcess)
    End Sub
End Class