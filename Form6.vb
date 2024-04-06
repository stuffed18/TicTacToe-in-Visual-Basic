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

        Dim pictureBox3 As New PictureBox()
        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox3.Dock = DockStyle.Fill
        pictureBox3.BackColor = Color.Transparent
        Me.Controls.Add(pictureBox3)

        pictureBox3.Image = Image.FromFile("assets\mountainlandscape.png")

        Button1.Parent = pictureBox3
        Button2.Parent = pictureBox3

        pictureBox3.SendToBack()

        Dim semiTransparentColor As Color = Color.FromArgb(128, Color.Black)

        Button1.BackColor = semiTransparentColor
        Button2.BackColor = semiTransparentColor
        Label1.Parent = pictureBox3
        PictureBox1.Parent = pictureBox3
        PictureBox2.Parent = pictureBox3

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MinesweeperModeEnabled = True
        Dim fifthform As New Form5
        fifthform.Show()
        Me.Hide()


    End Sub
End Class