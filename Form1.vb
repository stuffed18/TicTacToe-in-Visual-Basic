Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim SecondForm As New Form2
        SecondForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ThirdForm As New Form3
        ThirdForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim fifthform As New Form5
        fifthform.Show()
        Me.Hide()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pictureBox As New PictureBox()
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox.Dock = DockStyle.Fill
        pictureBox.BackColor = Color.Transparent
        Me.Controls.Add(pictureBox)

        pictureBox.Image = Image.FromFile("assets\landscape.png")

        Label3.Parent = pictureBox
        Button4.Parent = pictureBox
        Button2.Parent = pictureBox
        Button3.Parent = pictureBox

        pictureBox.SendToBack()
        Dim semiTransparentBlack As Color = Color.FromArgb(128, Color.Black)
        Button4.BackColor = semiTransparentBlack
        Button3.BackColor = semiTransparentBlack
        Button2.BackColor = semiTransparentBlack

    End Sub
End Class
