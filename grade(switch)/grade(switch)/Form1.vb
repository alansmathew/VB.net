Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mark1, mark2, mark3, avg As Integer
        mark1 = TextBox1.Text
        mark2 = TextBox3.Text
        mark3 = TextBox4.Text

        avg = (mark1 + mark2 + mark2) \ 3

        Select Case avg
            Case 90 To 100
                MsgBox("Grade is A+")
            Case 80 To 89
                MsgBox("Grade is A")
            Case 70 To 79
                MsgBox("Grade is B")
            Case 60 To 69
                MsgBox("Grade is C")
            Case 50 To 59
                MsgBox("Grade is P")
            Case Is < 50
                MsgBox("Reappere again !!")
            Case Else
                MsgBox("invalid input")
        End Select
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class
