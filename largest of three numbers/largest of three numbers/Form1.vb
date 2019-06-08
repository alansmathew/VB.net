Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text > TextBox2.Text > TextBox3.Text) Then
            MsgBox(TextBox1.Text + " is Grater")
        ElseIf (TextBox2.Text > TextBox3.Text > TextBox1.Text) Then
            MsgBox(TextBox2.Text + " is Grater")
        ElseIf (TextBox3.Text > TextBox2.Text > TextBox1.Text) Then
            MsgBox(TextBox3.Text + " is Grater")
        Else
            MsgBox("All are equal")
        End If
    End Sub
End Class
