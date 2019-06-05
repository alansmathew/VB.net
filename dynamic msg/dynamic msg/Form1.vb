Public Class Form1

   

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Entered data is " & TextBox1.Text)
        TextBox1.Clear()
    End Sub
End Class
