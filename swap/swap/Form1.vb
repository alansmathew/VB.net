Public Class Form1

    Public Sub swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp As Integer
        temp = a
        a = b
        b = temp
        TextBox1.Text = a
        TextBox2.Text = b


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        swap(a, b)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
