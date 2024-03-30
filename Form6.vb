Public Class Form6
    Public Shared PlayerVsComputerModeEnabled As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PlayerVsComputerModeEnabled = False
        Dim fifthform As New Form5
        fifthform.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PlayerVsComputerModeEnabled = True
        Dim fifthform As New Form5
        fifthform.Show()
        Me.Hide()

    End Sub
End Class