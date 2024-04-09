Public Class Form3
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sixthForm As New Form6
        sixthForm.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim FirstForm As New Form1
        FirstForm.Show()
        Me.Hide()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim wallpaper As New PictureBox()

        wallpaper.SizeMode = PictureBoxSizeMode.StretchImage
        wallpaper.Dock = DockStyle.Fill
        wallpaper.BackColor = Color.Transparent
        Me.Controls.Add(wallpaper)

        wallpaper.Image = Image.FromFile("assets\howtoplay2.png")

        Dim semiTransparentColor As Color = Color.FromArgb(128, Color.Black)

        Button3.Parent = wallpaper
        PictureBox1.Parent = wallpaper

    End Sub
End Class