Imports System.Reflection.Emit

Public Class Form6
    Public Shared PlayerVsComputerModeEnabled As Boolean = False
    Public Shared MinesweeperModeEnabled As Boolean = False

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

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim wallpaper As New PictureBox()
        wallpaper.SizeMode = PictureBoxSizeMode.StretchImage
        wallpaper.Dock = DockStyle.Fill
        wallpaper.BackColor = Color.Transparent
        Me.Controls.Add(wallpaper)

        wallpaper.Image = Image.FromFile("assets\mountainlandscape.png")

        Button1.Parent = wallpaper
        Button2.Parent = wallpaper
        Button3.Parent = wallpaper

        wallpaper.SendToBack()

        Dim semiTransparentColor As Color = Color.FromArgb(128, Color.Black)

        Button1.BackColor = semiTransparentColor
        Button2.BackColor = semiTransparentColor
        Button3.BackColor = semiTransparentColor
        Label1.Parent = wallpaper
        PictureBox1.Parent = wallpaper
        PictureBox2.Parent = wallpaper
        PictureBox3.Parent = wallpaper

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MinesweeperModeEnabled = True
        Dim fifthform As New Form5
        fifthform.Show()
        Me.Hide()


    End Sub
End Class