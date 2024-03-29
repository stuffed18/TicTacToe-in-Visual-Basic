Imports System.Reflection.Emit

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Image = ImageList1.Images(0)

    End Sub

    Public Sub SetTexts(playerone As String, playertwo As String)
        Label3.Text = playerone
    End Sub

End Class