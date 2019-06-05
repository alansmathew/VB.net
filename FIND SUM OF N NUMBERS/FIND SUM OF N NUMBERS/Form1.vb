Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num, sum As Integer
        num = TextBox2.Text
        While num >= 0
            sum += num
            num -= 1
        End While
        MsgBox("sum is " & sum)
    End Sub
End Class
