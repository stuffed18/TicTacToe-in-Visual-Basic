Public Class Form3
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim FirstForm As New Form1
        FirstForm.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim FifthForm As New Form5
        FifthForm.Show()
        Me.Hide()

    End Sub
End Class