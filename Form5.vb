
Imports System.Linq.Expressions
Imports Microsoft.VisualBasic.Devices

Public Class Form5
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Form6.PlayerVsComputerModeEnabled = False Then
            Dim playerone As String = TextBox1.Text
            Dim playertwo As String = TextBox2.Text
            If TextBox1.Text = "" OrElse TextBox2.Text = "" Then
                MessageBox.Show("Please fill in both textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim secondform As New Form2
            secondform.Show()
            secondform.SetTexts(playerone, playertwo)

            Dim fourthform As New Form4
            fourthform.SetTexts(playerone, playertwo)


            Me.Hide()
        End If

        If Form6.PlayerVsComputerModeEnabled = True Then
            Dim playerone As String = TextBox1.Text
            Dim playertwo As String = "Computer"
            If TextBox1.Text = "" Then
                MessageBox.Show("Please fill the textboxe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim secondform As New Form2
            secondform.Show()
            secondform.SetTexts(playerone, playertwo)

            Dim fourthform As New Form4
            fourthform.SetTexts(playerone, playertwo)

        End If

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pictureBox1 As New PictureBox()
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox1.Dock = DockStyle.Fill
        pictureBox1.BackColor = Color.Transparent
        Me.Controls.Add(pictureBox1)

        pictureBox1.Image = Image.FromFile("assets\landscape.png") ' 

        Label3.Parent = pictureBox1
        Button1.Parent = pictureBox1

        pictureBox1.SendToBack()

        Dim semiTransparentColor As Color = Color.FromArgb(128, Color.Black)

        Button1.BackColor = semiTransparentColor

        Label3.Parent = pictureBox1
        Label2.Parent = pictureBox1
        Label1.Parent = pictureBox1

        If Form6.PlayerVsComputerModeEnabled = True Then
            TextBox2.Text = "Computer"
            TextBox2.Enabled = False

        End If
    End Sub
End Class