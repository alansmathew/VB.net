Public Class Form1

  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text > TextBox2.Text Then
            MsgBox(TextBox1.Text & " is  greater")
        ElseIf TextBox2.Text > TextBox1.Text Then
            MsgBox(TextBox2.Text & " is  greater")
        Else
            MsgBox(TextBox1.Text & " & " & TextBox2.Text & " are equal !!")
        End If

        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class
