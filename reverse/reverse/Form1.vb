Public Class Form1


    Public Sub reverse(ByVal a As Integer)
        Dim temp, rev As Integer
        a = TextBox1.Text
        While a > 0
            temp = a Mod 10
            rev *= 10
            rev += temp
            a /= 10
        End While

        TextBox1.Text = rev
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Visible = False
        Label2.Visible = True
        Dim a As Integer
        a = TextBox1.Text
        reverse(a)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
