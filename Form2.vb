﻿Imports System.Media
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Public Class Form2
    Dim Flag As Boolean = True
    Dim button1X As Boolean = False
    Dim button2X As Boolean = False
    Dim button3X As Boolean = False
    Dim button4X As Boolean = False
    Dim button5X As Boolean = False
    Dim button6X As Boolean = False
    Dim button7X As Boolean = False
    Dim button8X As Boolean = False
    Dim button9X As Boolean = False
    Dim button1o As Boolean = False
    Dim button2o As Boolean = False
    Dim button3o As Boolean = False
    Dim button4o As Boolean = False
    Dim button5o As Boolean = False
    Dim button6o As Boolean = False
    Dim button7o As Boolean = False
    Dim button8o As Boolean = False
    Dim button9o As Boolean = False
    Dim clicked As Integer = 0
    Dim FourthForm As New Form4


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Flag = True Then
            Flag = False
            Button1.Image = ImageList1.Images(0)
            button1X = True

        Else
            Flag = True
            Button1.Image = ImageList1.Images(1)
            button1o = True

        End If
        RemoveHandler Button1.Click, AddressOf Button1_Click
        CheckForWin()
        clicked += 1
        clickSound.Play()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Flag = True Then
            Flag = False
            Button2.Image = ImageList1.Images(0)
            button2X = True

        Else
            Flag = True
            Button2.Image = ImageList1.Images(1)
            button2o = True

        End If
        RemoveHandler Button2.Click, AddressOf Button2_Click
        CheckForWin()
        clicked += 1
        clickSound.Play()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Flag = True Then
            Flag = False
            Button3.Image = ImageList1.Images(0)
            button3X = True

        Else
            Flag = True
            Button3.Image = ImageList1.Images(1)
            button3o = True

        End If
        RemoveHandler Button3.Click, AddressOf Button3_Click
        CheckForWin()
        clicked += 1
        clickSound.Play()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Flag = True Then
            Flag = False
            Button4.Image = ImageList1.Images(0)
            button4X = True

        Else
            Flag = True
            Button4.Image = ImageList1.Images(1)
            button4o = True

        End If
        RemoveHandler Button4.Click, AddressOf Button4_Click
        CheckForWin()
        clicked += 1
        clickSound.Play()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Flag = True Then
            Flag = False
            Button5.Image = ImageList1.Images(0)
            button5X = True

        Else
            Flag = True
            Button5.Image = ImageList1.Images(1)
            button5o = True

        End If
        RemoveHandler Button5.Click, AddressOf Button5_Click
        CheckForWin()
        clicked += 1
        clickSound.Play()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Flag = True Then
            Flag = False
            Button6.Image = ImageList1.Images(0)
            button6X = True

        Else
            Flag = True
            Button6.Image = ImageList1.Images(1)
            button6o = True

        End If
        RemoveHandler Button6.Click, AddressOf Button6_Click
        CheckForWin()
        clicked += 1
        clickSound.Play()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Flag = True Then
            Flag = False
            Button7.Image = ImageList1.Images(0)
            button7X = True

        Else
            Flag = True
            Button7.Image = ImageList1.Images(1)
            button7o = True

        End If
        RemoveHandler Button7.Click, AddressOf Button7_Click
        CheckForWin()
        clicked += 1
        clickSound.Play()


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Flag = True Then
            Flag = False
            Button8.Image = ImageList1.Images(0)
            button8X = True

        Else
            Flag = True
            Button8.Image = ImageList1.Images(1)
            button8o = True

        End If
        RemoveHandler Button8.Click, AddressOf Button8_Click
        CheckForWin()
        clicked += 1
        clickSound.Play()


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Flag = True Then
            Flag = False
            Button9.Image = ImageList1.Images(0)
            button9X = True

        Else
            Flag = True
            Button9.Image = ImageList1.Images(1)
            button9o = True

        End If
        RemoveHandler Button9.Click, AddressOf Button9_Click
        CheckForWin()
        clicked += 1
        clickSound.Play()


    End Sub

    Public Sub SetTexts(playerone As String, playertwo As String)
        Label4.Text = playerone
        Label5.Text = playertwo
    End Sub


    Private Sub CheckForWin()
        If button1X AndAlso button2X AndAlso button3X Then
            Label3.Text = "winner x"
            Button1.BackColor = ColorTranslator.FromHtml("#000000")
            Button2.BackColor = ColorTranslator.FromHtml("#000000")
            Button3.BackColor = ColorTranslator.FromHtml("#000000")
            Button1.Image = ImageList1.Images(2)
            Button2.Image = ImageList1.Images(2)
            Button3.Image = ImageList1.Images(2)
            Label8.Text = "Winner X: " & Label4.Text

        ElseIf button4X AndAlso button5X AndAlso button6X Then
            Label3.Text = "winner x"
            Button4.BackColor = ColorTranslator.FromHtml("#000000")
            Button5.BackColor = ColorTranslator.FromHtml("#000000")
            Button6.BackColor = ColorTranslator.FromHtml("#000000")
            Button4.Image = ImageList1.Images(2)
            Button5.Image = ImageList1.Images(2)
            Button6.Image = ImageList1.Images(2)
            Label8.Text = "Winner X: " & Label4.Text


        ElseIf button7X AndAlso button8X AndAlso button9X Then
            Label3.Text = "winner x"
            Button7.BackColor = ColorTranslator.FromHtml("#000000")
            Button8.BackColor = ColorTranslator.FromHtml("#000000")
            Button9.BackColor = ColorTranslator.FromHtml("#000000")
            Button7.Image = ImageList1.Images(2)
            Button8.Image = ImageList1.Images(2)
            Button9.Image = ImageList1.Images(2)
            Label8.Text = "Winner X: " & Label4.Text


        ElseIf button1X AndAlso button6X AndAlso button7X Then
            Label3.Text = "winner x"
            Button1.BackColor = ColorTranslator.FromHtml("#000000")
            Button6.BackColor = ColorTranslator.FromHtml("#000000")
            Button7.BackColor = ColorTranslator.FromHtml("#000000")
            Button1.Image = ImageList1.Images(2)
            Button6.Image = ImageList1.Images(2)
            Button7.Image = ImageList1.Images(2)
            Label8.Text = "Winner X: " & Label4.Text


        ElseIf button3X AndAlso button4X AndAlso button9X Then
            Label3.Text = "winner x"
            Button3.BackColor = ColorTranslator.FromHtml("#000000")
            Button4.BackColor = ColorTranslator.FromHtml("#000000")
            Button9.BackColor = ColorTranslator.FromHtml("#000000")
            Button3.Image = ImageList1.Images(2)
            Button4.Image = ImageList1.Images(2)
            Button9.Image = ImageList1.Images(2)
            Label8.Text = "Winner X: " & Label4.Text


        ElseIf button2X AndAlso button5X AndAlso button8X Then
            Label3.Text = "winner x"
            Button2.BackColor = ColorTranslator.FromHtml("#000000")
            Button5.BackColor = ColorTranslator.FromHtml("#000000")
            Button8.BackColor = ColorTranslator.FromHtml("#000000")
            Button2.Image = ImageList1.Images(2)
            Button5.Image = ImageList1.Images(2)
            Button8.Image = ImageList1.Images(2)
            Label8.Text = "Winner X: " & Label4.Text


        ElseIf button1X AndAlso button5X AndAlso button9X Then
            Label3.Text = "winner x"
            Button1.BackColor = ColorTranslator.FromHtml("#000000")
            Button5.BackColor = ColorTranslator.FromHtml("#000000")
            Button9.BackColor = ColorTranslator.FromHtml("#000000")
            Button1.Image = ImageList1.Images(2)
            Button5.Image = ImageList1.Images(2)
            Button9.Image = ImageList1.Images(2)
            Label8.Text = "Winner X: " & Label4.Text


        ElseIf button3X AndAlso button5X AndAlso button7X Then
            Label3.Text = "winner x"
            Button3.BackColor = ColorTranslator.FromHtml("#000000")
            Button5.BackColor = ColorTranslator.FromHtml("#000000")
            Button7.BackColor = ColorTranslator.FromHtml("#000000")
            Button3.Image = ImageList1.Images(2)
            Button5.Image = ImageList1.Images(2)
            Button7.Image = ImageList1.Images(2)
            Label8.Text = "Winner X: " & Label4.Text


        End If

        If (Label3.Text = "winner x") Then
            playerXscore += 1
            DisableButtons()
        End If
        If Label3.Text = "Winner O" Then
            playerOscore += 1
            DisableButtons()
        End If

        If button1o AndAlso button2o AndAlso button3o Then
            Label3.Text = "Winner O"
            Button1.BackColor = ColorTranslator.FromHtml("#000000")
            Button2.BackColor = ColorTranslator.FromHtml("#000000")
            Button3.BackColor = ColorTranslator.FromHtml("#000000")
            Button1.Image = ImageList1.Images(3)
            Button2.Image = ImageList1.Images(3)
            Button3.Image = ImageList1.Images(3)
            Label8.Text = "Winner O: " & Label5.Text


        ElseIf button4o AndAlso button5o AndAlso button6o Then
            Label3.Text = "Winner O"
            Button4.BackColor = ColorTranslator.FromHtml("#000000")
            Button5.BackColor = ColorTranslator.FromHtml("#000000")
            Button6.BackColor = ColorTranslator.FromHtml("#000000")
            Button4.Image = ImageList1.Images(3)
            Button5.Image = ImageList1.Images(3)
            Button6.Image = ImageList1.Images(3)
            Label8.Text = "Winner O: " & Label5.Text


        ElseIf button7o AndAlso button8o AndAlso button9o Then
            Label3.Text = "Winner O"
            Button7.BackColor = ColorTranslator.FromHtml("#000000")
            Button8.BackColor = ColorTranslator.FromHtml("#000000")
            Button9.BackColor = ColorTranslator.FromHtml("#000000")
            Button7.Image = ImageList1.Images(3)
            Button8.Image = ImageList1.Images(3)
            Button9.Image = ImageList1.Images(3)
            Label8.Text = "Winner O: " & Label5.Text


        ElseIf button1o AndAlso button6o AndAlso button7o Then
            Label3.Text = "Winner O"
            Button1.BackColor = ColorTranslator.FromHtml("#000000")
            Button6.BackColor = ColorTranslator.FromHtml("#000000")
            Button7.BackColor = ColorTranslator.FromHtml("#000000")
            Button1.Image = ImageList1.Images(3)
            Button6.Image = ImageList1.Images(3)
            Button7.Image = ImageList1.Images(3)
            Label8.Text = "Winner O: " & Label5.Text


        ElseIf button3o AndAlso button4o AndAlso button9o Then
            Label3.Text = "Winner O"
            Button3.BackColor = ColorTranslator.FromHtml("#000000")
            Button4.BackColor = ColorTranslator.FromHtml("#000000")
            Button9.BackColor = ColorTranslator.FromHtml("#000000")
            Button3.Image = ImageList1.Images(3)
            Button4.Image = ImageList1.Images(3)
            Button9.Image = ImageList1.Images(3)
            Label8.Text = "Winner O: " & Label5.Text


        ElseIf button2o AndAlso button5o AndAlso button8o Then
            Label3.Text = "Winner O"
            Button2.BackColor = ColorTranslator.FromHtml("#000000")
            Button5.BackColor = ColorTranslator.FromHtml("#000000")
            Button8.BackColor = ColorTranslator.FromHtml("#000000")
            Button2.Image = ImageList1.Images(3)
            Button5.Image = ImageList1.Images(3)
            Button8.Image = ImageList1.Images(3)
            Label8.Text = "Winner O: " & Label5.Text


        ElseIf button1o AndAlso button5o AndAlso button9o Then
            Label3.Text = "Winner O"
            Button1.BackColor = ColorTranslator.FromHtml("#000000")
            Button5.BackColor = ColorTranslator.FromHtml("#000000")
            Button9.BackColor = ColorTranslator.FromHtml("#000000")
            Button1.Image = ImageList1.Images(3)
            Button5.Image = ImageList1.Images(3)
            Button9.Image = ImageList1.Images(3)
            Label8.Text = "Winner O: " & Label5.Text


        ElseIf button3o AndAlso button5o AndAlso button7o Then
            Label3.Text = "Winner O"
            Button3.BackColor = ColorTranslator.FromHtml("#000000")
            Button5.BackColor = ColorTranslator.FromHtml("#000000")
            Button7.BackColor = ColorTranslator.FromHtml("#000000")
            Button3.Image = ImageList1.Images(3)
            Button5.Image = ImageList1.Images(3)
            Button7.Image = ImageList1.Images(3)
            Label8.Text = "Winner O: " & Label5.Text

        End If

        If clicked = 8 AndAlso Not (Label3.Text = "winner x") AndAlso Not (Label3.Text = "Winner O") Then
            Label8.Text = "DRAW"
        End If

        UpdateScores()


    End Sub

    Private Sub UpdateScores()
        If Label3.Text = "Winner X" Then
            playerXscore += 1
        ElseIf Label3.Text = "Winner O" Then
            playerOscore += 1
        ElseIf Label3.Text = "mine o" Then
            playerOscore += 1
        ElseIf Label3.Text = "mine x" Then
            playerXscore += 1
        End If
        Label6.Text = "Score: " & playerXscore.ToString()
        Label7.Text = "Score: " & playerOscore.ToString()
    End Sub

    Private Sub DisableButtons()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
    End Sub

    Private playerXscore As Integer = 0
    Private playerOscore As Integer = 0

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim currentScoresX As Integer = playerXscore
        Dim currentScoresO As Integer = playerOscore
        Dim currentPlayerOne As String = Label4.Text
        Dim currentPlayerTwo As String = Label5.Text

        Me.Close()

        Dim newForm As New Form2()

        newForm.playerXscore = currentScoresX
        newForm.playerOscore = currentScoresO
        newForm.Label6.Text = "Score: " & currentScoresX.ToString()
        newForm.Label7.Text = "Score: " & currentScoresO.ToString()
        newForm.SetTexts(currentPlayerOne, currentPlayerTwo)

        newForm.Show()
    End Sub

    Private clickSound As New SoundPlayer()
    Private mineSound As New SoundPlayer()


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button10.Image = ImageList2.Images(0)
        Button11.Image = ImageList2.Images(1)
        clickSound.SoundLocation = "assets\buttonclick.wav"
        clickSound.LoadAsync()
        mineSound.SoundLocation = "assets\smallexplosion.wav"
        mineSound.LoadAsync()

        wallpaper1()

        If Form6.MinesweeperModeEnabled Then
            MinesweeperMode()
            MineInstructions()
        End If

        Label3.Visible = False

        SetLabelsParent()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form6.PlayerVsComputerModeEnabled = False
        Form6.MinesweeperModeEnabled = False

        Dim firstform As New Form1
        firstform.Show()
        Me.Hide()

    End Sub

    Private random As New Random()

    Private Sub ComputerMove()
        If Not GameOver() Then
            Dim gameGridButtons As New List(Of Button) From {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9}

            Dim availableButtons As New List(Of Button)

            For Each btn As Button In gameGridButtons
                If btn.Enabled Then
                    availableButtons.Add(btn)
                End If
            Next


            If availableButtons.Count > 0 Then
                Dim randomButtonIndex As Integer = random.Next(availableButtons.Count)
                Dim selectedButton As Button = availableButtons(randomButtonIndex)

                ' simulate a click on the randomly selected button
                selectedButton.PerformClick()
                Flag = True


            End If
        End If
    End Sub


    Private Function GameOver() As Boolean
        If Label8.Text.StartsWith("Winner O:") OrElse Label8.Text.StartsWith("Winner X:") OrElse Label8.Text = "DRAW" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        If Form6.PlayerVsComputerModeEnabled Then
            If Flag = False Then
                ComputerMove()
            End If
        End If

    End Sub

    Private Sub MinesweeperMode()
        Dim gameGridButtons As New List(Of Button) From {Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9}
        Dim mineButtonIndex As Integer = random.Next(0, gameGridButtons.Count)
        Dim mineButton As Button = gameGridButtons(mineButtonIndex)
        AddHandler mineButton.Click, AddressOf MineButton_Click

    End Sub
    Private Sub MineButton_Click(sender As Object, e As EventArgs)
        If Form6.MinesweeperModeEnabled = True Then

            Dim mineButton As Button = DirectCast(sender, Button)
            If Flag = True Then
                mineButton.Image = ImageList1.Images(5)
                Label8.Text = "Winner X: " & Label4.Text
                Label3.Text = "mine x"
                UpdateScores()
                mineSound.Play()

            End If
            If Flag = False Then
                mineButton.Image = ImageList1.Images(5)
                Label8.Text = "Winner O: " & Label5.Text
                Label3.Text = "mine o"
                UpdateScores()
                mineSound.Play()

            End If
            DisableButtons()

        End If

    End Sub

    Private Sub MineInstructions()
        Dim newLabel As New Label()

        newLabel.Size = New Size(240, 110)
        newLabel.Location = New Point(30, 245)
        newLabel.ForeColor = Color.White
        newLabel.BackColor = Color.Transparent
        newLabel.BorderStyle = BorderStyle.FixedSingle
        newLabel.Text = "You have enabled MINESWEEPER Mode. One mine is placed randomly on the board. If you click on it, it will explode."
        newLabel.AutoSize = False
        newLabel.Font = New Font(newLabel.Font.FontFamily, 12)
        newLabel.TextAlign = ContentAlignment.TopLeft
        newLabel.Parent = wallpaper
        newLabel.Padding = New Padding(10)

        Dim textSize As Size = TextRenderer.MeasureText(newLabel.Text, newLabel.Font, New Size(newLabel.Width - newLabel.Padding.Horizontal, Integer.MaxValue), TextFormatFlags.WordBreak)

        Dim bufferHeight As Integer = 10
        newLabel.Height = textSize.Height + newLabel.Padding.Vertical + bufferHeight

        Me.Controls.Add(newLabel)
        newLabel.BringToFront()
    End Sub

    Dim wallpaper As New PictureBox()

    Public Sub wallpaper1()
        wallpaper.SizeMode = PictureBoxSizeMode.StretchImage
        wallpaper.Dock = DockStyle.Fill
        wallpaper.BackColor = Color.Transparent
        Me.Controls.Add(wallpaper)

        wallpaper.Image = Image.FromFile("assets\landscape3.png")

        Label1.Parent = wallpaper
        Label2.Parent = wallpaper
        Label3.Parent = wallpaper
        Label4.Parent = wallpaper
        Label5.Parent = wallpaper
        Label6.Parent = wallpaper
        Label7.Parent = wallpaper
        Label8.Parent = wallpaper
        PictureBox1.Parent = wallpaper
        PictureBox2.Parent = wallpaper
        Button10.Parent = wallpaper
        Button11.Parent = wallpaper
    End Sub

    Private Sub SetLabelsParent()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Label Then
                ctrl.Parent = wallpaper
            End If
        Next
    End Sub



End Class